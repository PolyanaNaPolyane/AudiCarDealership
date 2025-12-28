using System.Data;
using CarDealership.Data.Entities;
using CarDealership.Enums;
using CarDealership.Services;
using CarDealership.Services.Interfaces;
using CarDealership.Utils;

namespace CarDealership.Forms
{
    public partial class UserOrdersForm : Form
    {
        private readonly BindingSource _ordersBindingSource = new();

        private readonly IOrderService _orderService;
        private readonly ICarService _carService;

        private IEnumerable<Order> _allOrders = [];

        private OrdersFilter _ordersFilter = new()
        {
            PriceFrom = null,
            PriceTo = null,
            SelectedStatuses = []
        };

        public UserOrdersForm(
            AccountContext accountContext,
            IOrderService orderService,
            ICarService carService)
        {
            InitializeComponent();

            _orderService = orderService;
            _carService = carService;
        }

        private async void UserOrdersForm_Load(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
        }

        private async Task LoadOrdersAsync()
        {
            _allOrders = await _orderService.GetAllByAccountAsync();
            _ordersBindingSource.DataSource = ToOrdersTable(_allOrders);
            ordersDataGridView.DataSource = _ordersBindingSource;
            ordersDataGridView.ClearSelection();
            ordersDataGridView.Columns["Id"].Visible = false;
        }

        private DataTable ToOrdersTable(IEnumerable<Order> orders)
        {
            var ordersTable = new DataTable();
            ordersTable.Columns.Add("Id", typeof(int));
            ordersTable.Columns.Add("Автомобіль", typeof(string));
            ordersTable.Columns.Add("Загальна ціна", typeof(decimal));
            ordersTable.Columns.Add("Дата створення", typeof(DateTime));
            ordersTable.Columns.Add("Статус", typeof(string));

            foreach (var order in orders)
            {
                ordersTable.Rows.Add(order.Id, order.Car.TechnicalCharacteristics.Model.Name, order.OverallPrice,
                    order.CreatedDate, order.Status.GetDisplayName());
            }

            return ordersTable;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            var ordersFilteringForm = new OrdersFilteringForm(_ordersFilter);
            ordersFilteringForm.ShowDialog();
            _ordersFilter = ordersFilteringForm.OrdersFilter;

            var filteredOrders = _allOrders;

            if (_ordersFilter.PriceFrom.HasValue)
            {
                filteredOrders = filteredOrders.Where(order => order.OverallPrice >= _ordersFilter.PriceFrom.Value);
            }

            if (_ordersFilter.PriceTo.HasValue)
            {
                filteredOrders = filteredOrders.Where(order => order.OverallPrice <= _ordersFilter.PriceFrom.Value);
            }

            if (_ordersFilter.SelectedStatuses.Count != 0)
            {
                filteredOrders =
                    filteredOrders.Where(order => _ordersFilter.SelectedStatuses.Contains((int)order.Status));
            }

            _ordersBindingSource.DataSource = ToOrdersTable(filteredOrders);
            ordersDataGridView.ClearSelection();

            if (filteredOrders.Count() == 0)
            {
                MessageUtil.ShowInformation("Записів не було знайдено");
                return;
            }

            searchButton_Click(this, null);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            _ordersFilter = new OrdersFilter
            {
                PriceFrom = null,
                PriceTo = null,
                SelectedStatuses = []
            };

            searchTextBox.Text = "";

            _ordersBindingSource.DataSource = ToOrdersTable(_allOrders);
            ordersDataGridView.ClearSelection();

            searchButton_Click(this, null);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim();

            foreach (DataGridViewRow row in ordersDataGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(searchText))
            {
                return;
            }

            int foundRowsCount = 0;

            foreach (DataGridViewRow row in ordersDataGridView.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                var modelName = row.Cells[1].Value.ToString();

                if (!modelName.ToLower().Contains(searchText.ToLower()))
                {
                    continue;
                }

                foundRowsCount++;
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            }

            if (foundRowsCount == 0)
            {
                MessageUtil.ShowInformation("Записів не було знайдено");
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count == 0)
            {
                MessageUtil.ShowError("Оберіть замовлення для експорту детальної інформації");
                return;
            }

            var selectedRowView = (DataRowView)ordersDataGridView.CurrentRow.DataBoundItem;
            var selectedRow = selectedRowView.Row;
            var selectedOrder = _allOrders.First(car => car.Id == selectedRow.Field<int>("Id"));

            using var folderBrowsingDialog = new FolderBrowserDialog();
            folderBrowsingDialog.Description = "Оберіть папку для збереження звіту";
            folderBrowsingDialog.UseDescriptionForTitle = true;

            if (folderBrowsingDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedPath = folderBrowsingDialog.SelectedPath;
                selectedOrder.GeneratePdf(Path.Combine(selectedPath, $"{selectedOrder.Car.VIN}-order-details.pdf"));
                MessageUtil.ShowInformation("Деталі замовлення автомобіля успішно експортовані");
            }
        }

        private async void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count == 0)
            {
                MessageUtil.ShowError("Оберіть замовлення для видалення");
                return;
            }


            var selectedRowView = (DataRowView)ordersDataGridView.CurrentRow.DataBoundItem;
            var selectedRow = selectedRowView.Row;
            var selectedOrder = _allOrders.First(car => car.Id == selectedRow.Field<int>("Id"));

            if (selectedOrder.Status == OrderStatus.Approved)
            {
                MessageUtil.ShowError("Неможливо видалити замовлення");
                return;
            }

            var choice = MessageBox.Show("Ви впевнені, що хочете продовжити видалення замовлення?", "Інформація", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (choice != DialogResult.OK)
            {
                return;
            }

            await _orderService.DeleteAsync(selectedOrder.Id);
            await _carService.ChangeStatusAsync(selectedOrder.CarId, CarStatus.Available);

            _allOrders = _allOrders.Where(order => order.Id != selectedRow.Field<int>("Id"));
            _ordersBindingSource.DataSource = ToOrdersTable(_allOrders);
            ordersDataGridView.ClearSelection();
        }
    }
}