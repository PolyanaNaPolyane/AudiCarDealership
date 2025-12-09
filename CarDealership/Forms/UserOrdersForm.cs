using System.Data;
using CarDealership.Data.Entities;
using CarDealership.Enums;
using CarDealership.Services.Interfaces;
using CarDealership.Utils;

namespace CarDealership.Forms
{
    public partial class UserOrdersForm : Form
    {
        private readonly BindingSource _ordersBindingSource = new();
        private readonly IOrderService _orderService;

        private IEnumerable<Order> _allOrders = [];

        private OrdersFilter _ordersFilter = new()
        {
            PriceFrom = null,
            PriceTo = null,
            SelectedStatuses = []
        };

        public UserOrdersForm(IOrderService orderService)
        {
            InitializeComponent();

            _orderService = orderService;
        }

        private async void UserOrdersForm_Load(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
        }

        private async Task LoadOrdersAsync()
        {
            _allOrders = await _orderService.GetAllAsync();
            _ordersBindingSource.DataSource = ToOrdersTable(_allOrders);
            ordersDataGridView.DataSource = _ordersBindingSource;
            ordersDataGridView.Columns["Id"].Visible = false;
        }

        private DataTable ToOrdersTable(IEnumerable<Order> orders)
        {
            var ordersTable = new DataTable();
            ordersTable.Columns.Add("Id", typeof(int));
            ordersTable.Columns.Add("Автомобіль", typeof(string));
            ordersTable.Columns.Add("Загальна ціна", typeof(decimal));
            ordersTable.Columns.Add("Дата створення", typeof(DateTime));
            ordersTable.Columns.Add("Статус", typeof(OrderStatus));

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
            ordersDataGridView.Columns["Id"].Visible = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            _ordersFilter = new OrdersFilter
            {
                PriceFrom = null,
                PriceTo = null,
                SelectedStatuses = []
            };

            _ordersBindingSource.DataSource = ToOrdersTable(_allOrders);
            ordersDataGridView.Columns["Id"].Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
        }
    }
}