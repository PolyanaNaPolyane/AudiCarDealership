using System.Collections;
using System.Data;
using CarDealership.Data.Entities;
using CarDealership.Enums;
using CarDealership.Services.Interfaces;
using CarDealership.Utils;

namespace CarDealership.Forms;

public partial class ManagerTablesForm : Form
{
    private readonly IModelService _modelService;
    private readonly ITechnicalCharacteristicsService _technicalCharacteristicsService;
    private readonly IDealerService _dealerService;
    private readonly ICarService _carService;
    private readonly IOrderService _orderService;
    private readonly IAccountService _accountService;
    private readonly IContactDetailsService _contactDetailsService;

    private readonly BindingSource _data = new();

    private IEnumerable<Order> _allOrders = [];
    private IEnumerable<Car> _allCars = [];

    private CarsFilter _carsFilter = GetEmptyCarsFilter();
    private OrdersFilter _ordersFilter = GetEmptyOrdersFilter();

    public ManagerTablesForm(
        ICarService carService,
        IOrderService orderService,
        IAccountService accountService,
        IContactDetailsService contactDetailsService,
        ITechnicalCharacteristicsService technicalCharacteristicsService,
        IDealerService dealerService,
        IModelService modelService)
    {
        InitializeComponent();

        _carService = carService;
        _orderService = orderService;
        _accountService = accountService;
        _contactDetailsService = contactDetailsService;
        _technicalCharacteristicsService = technicalCharacteristicsService;
        _dealerService = dealerService;
        _modelService = modelService;
    }

    private async void ManagerTablesForm_Load(object sender, EventArgs e)
    {
        tableLabel.Text = "Моделі";
        actionsToolStripMenuItem.Visible = false;
        filterGroupBox.Visible = false;
        await LoadModelsAsync();
    }

    private async Task LoadModelsAsync()
    {
        var models = await _modelService.GetAllAsync();
        _data.DataSource = ToModelsTable(models);
        dataGridView.DataSource = _data;
        dataGridView.ClearSelection();
    }

    private async Task LoadTechnicalCharacteristicsAsync()
    {
        var technicalCharacteristics = await _technicalCharacteristicsService.GetAllAsync();
        _data.DataSource = ToTechnicalCharacteristicsTable(technicalCharacteristics);
        dataGridView.DataSource = _data;
        dataGridView.ClearSelection();
    }

    private async Task LoadOrdersAsync()
    {
        _allOrders = await _orderService.GetAllAsync();
        _data.DataSource = ToOrdersTable(_allOrders);
        dataGridView.DataSource = _data;
        dataGridView.ClearSelection();
    }

    private async Task LoadAccountsAsync()
    {
        var accounts = await _accountService.GetAllAsync();
        _data.DataSource = ToAccountsTable(accounts);
        dataGridView.DataSource = _data;
        dataGridView.ClearSelection();
    }

    private async Task LoadDealersAsync()
    {
        var dealers = await _dealerService.GetAllAsync();
        _data.DataSource = ToDelaersTable(dealers);
        dataGridView.DataSource = _data;
        dataGridView.ClearSelection();
    }

    private async Task LoadContactDetailsAsync()
    {
        var contacts = await _contactDetailsService.GetAllAsync();
        _data.DataSource = ToContactDetailsTable(contacts);
        dataGridView.DataSource = _data;
        dataGridView.ClearSelection();
    }

    private async Task LoadCarsAsync()
    {
        _allCars = await _carService.GetAllAsync();
        _data.DataSource = ToCarsTable(_allCars);
        dataGridView.DataSource = _data;
        dataGridView.ClearSelection();
    }

    private DataTable ToModelsTable(IEnumerable<Model> models)
    {
        var modelsTable = new DataTable();
        modelsTable.Columns.Add("Id", typeof(int));
        modelsTable.Columns.Add("Назва", typeof(string));
        modelsTable.Columns.Add("Бренд", typeof(string));
        modelsTable.Columns.Add("Клас", typeof(string));

        foreach (var model in models)
        {
            modelsTable.Rows.Add(model.Id, model.Name, model.Brand, model.Class);
        }

        return modelsTable;
    }

    private DataTable ToTechnicalCharacteristicsTable(IEnumerable<TechnicalCharacteristics> technicalCharacteristics)
    {
        var technicalCharacteristicsTable = new DataTable();
        technicalCharacteristicsTable.Columns.Add("Id", typeof(int));
        technicalCharacteristicsTable.Columns.Add("Модель", typeof(string));
        technicalCharacteristicsTable.Columns.Add("Тип кузова", typeof(string));
        technicalCharacteristicsTable.Columns.Add("Максимальна швидкість", typeof(int));
        technicalCharacteristicsTable.Columns.Add("Тип трансміссії", typeof(string));
        technicalCharacteristicsTable.Columns.Add("Витрата палива", typeof(decimal));
        technicalCharacteristicsTable.Columns.Add("Потужність", typeof(int));
        technicalCharacteristicsTable.Columns.Add("Тип приводу", typeof(string));
        technicalCharacteristicsTable.Columns.Add("Тип двигуна", typeof(string));


        foreach (var characteristics in technicalCharacteristics)
        {
            technicalCharacteristicsTable.Rows.Add(characteristics.Id, $"{characteristics.Model.Brand} {characteristics.Model.Name}", characteristics.BodyType.GetDisplayName(),
                characteristics.MaxSpeed, characteristics.TransmissionType.GetDisplayName(),
                characteristics.FuelConsumption, characteristics.Power, characteristics.DrivetrainType.GetDisplayName(),
                characteristics.EngineType.GetDisplayName());
        }

        return technicalCharacteristicsTable;
    }

    private DataTable ToOrdersTable(IEnumerable<Order> orders)
    {
        var ordersTable = new DataTable();
        ordersTable.Columns.Add("Id", typeof(int));
        ordersTable.Columns.Add("Акаунт", typeof(string));
        ordersTable.Columns.Add("Автомобіль", typeof(string));
        ordersTable.Columns.Add("Дата створення", typeof(DateTime));
        ordersTable.Columns.Add("Загальна ціна", typeof(decimal));
        ordersTable.Columns.Add("Статус", typeof(string));
        ordersTable.Columns.Add("Дата зміни статуса", typeof(DateTime));

        foreach (var order in orders)
        {
            ordersTable.Rows.Add(order.Id, order.Account?.Email ?? "-",
                order.Car != null
                    ? $"{order.Car.TechnicalCharacteristics.Model.Brand} {order.Car.TechnicalCharacteristics.Model.Name}"
                    : "-",
                order.CreatedDate, order.OverallPrice, order.Status.GetDisplayName(), order.StatusChangedDate);
        }

        return ordersTable;
    }

    private DataTable ToAccountsTable(IEnumerable<Account> accounts)
    {
        var accountsTable = new DataTable();
        accountsTable.Columns.Add("Id", typeof(int));
        accountsTable.Columns.Add("Ім'я", typeof(string));
        accountsTable.Columns.Add("Прізвище", typeof(string));
        accountsTable.Columns.Add("Пошта", typeof(string));
        accountsTable.Columns.Add("Тип користувача", typeof(string));

        foreach (var account in accounts)
        {
            accountsTable.Rows.Add(account.Id, account.FirstName, account.LastName, account.Email,
                account.Type.GetDisplayName());
        }

        return accountsTable;
    }

    private DataTable ToDelaersTable(IEnumerable<Dealer> dealers)
    {
        var dealersTable = new DataTable();
        dealersTable.Columns.Add("Id", typeof(int));
        dealersTable.Columns.Add("Назва", typeof(string));
        dealersTable.Columns.Add("Графік", typeof(string));
        dealersTable.Columns.Add("Лізинг", typeof(bool));
        dealersTable.Columns.Add("Тест-драйв", typeof(bool));

        foreach (var dealer in dealers)
        {
            dealersTable.Rows.Add(dealer.Id, dealer.Name, dealer.Schedule, dealer.LeasingCapability,
                dealer.TestDriveCapability);
        }

        return dealersTable;
    }

    private DataTable ToContactDetailsTable(IEnumerable<ContactDetails> contactDetails)
    {
        var contactDetailsTable = new DataTable();
        contactDetailsTable.Columns.Add("Id", typeof(int));
        contactDetailsTable.Columns.Add("Країна", typeof(string));
        contactDetailsTable.Columns.Add("Місто", typeof(string));
        contactDetailsTable.Columns.Add("Адреса", typeof(string));
        contactDetailsTable.Columns.Add("Номер телефону", typeof(string));

        foreach (var contact in contactDetails)
        {
            contactDetailsTable.Rows.Add(contact.Id, contact.Country, contact.City, contact.Address,
                contact.PhoneNumber);
        }

        return contactDetailsTable;
    }

    private DataTable ToCarsTable(IEnumerable<Car> cars)
    {
        var carsTable = new DataTable();
        carsTable.Columns.Add("Id", typeof(int));
        carsTable.Columns.Add("Модель", typeof(string));
        carsTable.Columns.Add("Ціна", typeof(decimal));
        carsTable.Columns.Add("Колір", typeof(string));
        carsTable.Columns.Add("Рік випуску", typeof(int));
        carsTable.Columns.Add("Статус", typeof(string));

        foreach (var car in cars)
        {
            carsTable.Rows.Add(car.Id, car.TechnicalCharacteristics.Model.Name, car.Price, car.Color, car.Year,
                car.Status.GetDisplayName());
        }

        return carsTable;
    }

    private async void modelsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Моделі";
        searchTextBox.Text = string.Empty;
        actionsToolStripMenuItem.Visible = false;
        filterGroupBox.Visible = false;
        await LoadModelsAsync();
    }

    private async void technicalCharacteristicsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Технічні характеристики";
        searchTextBox.Text = string.Empty;
        actionsToolStripMenuItem.Visible = false;
        filterGroupBox.Visible = false;
        await LoadTechnicalCharacteristicsAsync();
    }

    private async void carsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Автомобілі";
        searchTextBox.Text = string.Empty;
        actionsToolStripMenuItem.Visible = true;
        filterGroupBox.Visible = true;
        _carsFilter = GetEmptyCarsFilter();
        await LoadCarsAsync();
    }

    private async void dealersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Дилери";
        searchTextBox.Text = string.Empty;
        actionsToolStripMenuItem.Visible = false;
        filterGroupBox.Visible = false;
        await LoadDealersAsync();
    }

    private async void accountsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Акаунти";
        searchTextBox.Text = string.Empty;
        actionsToolStripMenuItem.Visible = false;
        filterGroupBox.Visible = false;
        await LoadAccountsAsync();
    }

    private async void ordersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Замовлення";
        searchTextBox.Text = string.Empty;
        actionsToolStripMenuItem.Visible = true;
        filterGroupBox.Visible = true;
        _ordersFilter = GetEmptyOrdersFilter();
        await LoadOrdersAsync();
    }

    private async void contactDetailsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Контактні дані";
        searchTextBox.Text = string.Empty;
        actionsToolStripMenuItem.Visible = false;
        filterGroupBox.Visible = false;
        await LoadContactDetailsAsync();
    }

    private async void addToolStripMenuItem_Click(object sender, EventArgs e)
    {
        switch (tableLabel.Text)
        {
            case "Автомобілі":
                var addCarForm = new UpsertCarForm(_carService, _technicalCharacteristicsService, _dealerService);
                addCarForm.ShowDialog();
                await LoadCarsAsync();
                break;
            case "Замовлення":
                var addOrderForm = new UpsertOrderForm(_orderService, _accountService, _carService);
                addOrderForm.ShowDialog();
                await LoadOrdersAsync();
                break;
        }
    }

    private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        switch (tableLabel.Text)
        {
            case "Автомобілі":
                if (dataGridView.SelectedRows.Count == 0)
                {
                    MessageUtil.ShowError("Оберіть запис для видалення");
                    return;
                }

                var selectedCarRowView = (DataRowView)dataGridView.CurrentRow.DataBoundItem;
                var selectedCarRow = selectedCarRowView.Row;

                var selectedCar = _allCars.First(car => car.Id == selectedCarRow.Field<int>("Id"));

                if (selectedCar.Status != CarStatus.Available)
                {
                    MessageUtil.ShowError("Неможливо видалити автомобіль");
                    return;
                }

                var choiceCarDelete = MessageBox.Show("Ви впевнені, що хочете продовжити видалення автомобіля?",
                    "Інформація", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (choiceCarDelete != DialogResult.OK)
                {
                    return;
                }

                await _carService.DeleteAsync(selectedCar.Id);
                await LoadCarsAsync();
                break;
            case "Замовлення":
                if (dataGridView.SelectedRows.Count == 0)
                {
                    MessageUtil.ShowError("Оберіть запис для видалення");
                    return;
                }

                var selectedOrderRowView = (DataRowView)dataGridView.CurrentRow.DataBoundItem;
                var selectedOrderRow = selectedOrderRowView.Row;

                var selectedOrder = _allOrders.First(car => car.Id == selectedOrderRow.Field<int>("Id"));

                if (selectedOrder.Status != OrderStatus.Pending)
                {
                    MessageUtil.ShowError("Неможливо видалити замовлення");
                    return;
                }

                var choiceOrderDelete = MessageBox.Show("Ви впевнені, що хочете продовжити видалення замовлення?",
                    "Інформація", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (choiceOrderDelete != DialogResult.OK)
                {
                    return;
                }

                await _orderService.DeleteAsync(selectedOrder.Id);
                await _carService.ChangeStatusAsync(selectedOrder.CarId, CarStatus.Available);
                await LoadOrdersAsync();
                break;
        }
    }

    private async void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (dataGridView.SelectedRows.Count == 0)
        {
            MessageUtil.ShowError("Оберіть запис для редагування");
            return;
        }
        
        var selectedRowView = (DataRowView)dataGridView.CurrentRow.DataBoundItem;
        var selectedRow = selectedRowView.Row;

        switch (tableLabel.Text)
        {
            case "Автомобілі":
                var carToUpdate = _allCars.First(car => car.Id == selectedRow.Field<int>("Id"));
                
                if (carToUpdate.Status != CarStatus.Available)
                {
                    MessageUtil.ShowError("Неможливо редагувати автомобіль");
                    return;
                }
                
                var updateCarForm = new UpsertCarForm(_carService, _technicalCharacteristicsService, _dealerService,
                    carToUpdate);
                updateCarForm.ShowDialog();
                await LoadCarsAsync();
                break;
            case "Замовлення":
                var orderToUpdate = _allOrders.First(car => car.Id == selectedRow.Field<int>("Id"));
                
                if (orderToUpdate.Status != OrderStatus.Pending)
                {
                    MessageUtil.ShowError("Неможливо редагувати замовлення");
                    return;
                }
                
                var updateOrderForm = new UpsertOrderForm(_orderService, _accountService, _carService, orderToUpdate);
                updateOrderForm.ShowDialog();
                await LoadOrdersAsync();
                break;
        }
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        string searchText = searchTextBox.Text.Trim();

        foreach (DataGridViewRow row in dataGridView.Rows)
        {
            row.DefaultCellStyle.BackColor = Color.White;
        }

        if (string.IsNullOrWhiteSpace(searchText))
        {
            return;
        }

        int foundRowsCount = 0;

        foreach (DataGridViewRow row in dataGridView.Rows)
        {
            if (row.IsNewRow)
            {
                continue;
            }

            var columnToSearch = tableLabel.Text switch
            {
                "Моделі" => row.Cells[1].Value.ToString(),
                "Технічні характеристики" =>
                    $"{row.Cells[1].Value}{row.Cells[3].Value}{row.Cells[6].Value}{row.Cells[7].Value}",
                "Автомобілі" => row.Cells[1].Value.ToString(),
                "Дилери" => row.Cells[1].Value.ToString(),
                "Акаунти" => $"{row.Cells[1].Value}{row.Cells[2].Value}{row.Cells[3].Value}",
                "Замовлення" => $"{row.Cells[1].Value}{row.Cells[2].Value}",
                "Контактні дані" => $"{row.Cells[1].Value}{row.Cells[2].Value}{row.Cells[3].Value}",
            };

            if (!columnToSearch.ToLower().Contains(searchText.ToLower()))
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

    private void applyButton_Click(object sender, EventArgs e)
    {
        IEnumerable filteredData = Enumerable.Empty<object>();
        switch (tableLabel.Text)
        {
            case "Автомобілі":
                var carFilteringForm = new CarsFilteringForm(_carsFilter);
                carFilteringForm.ShowDialog();
                _carsFilter = carFilteringForm.CarsFilter;

                var filteredCars = _allCars;

                if (_carsFilter.PriceFrom.HasValue)
                {
                    filteredCars = filteredCars.Where(car => car.Price >= _carsFilter.PriceFrom.Value);
                }

                if (_carsFilter.PriceTo.HasValue)
                {
                    filteredCars = filteredCars.Where(car => car.Price <= _carsFilter.PriceTo.Value);
                }

                if (_carsFilter.SelectedColors.Count != 0)
                {
                    filteredCars =
                        filteredCars.Where(car => _carsFilter.SelectedColors.Any(color => car.Color.Contains(color)));
                }

                if (_carsFilter.SelectedBodyTypes.Count != 0)
                {
                    filteredCars = filteredCars.Where(car =>
                        _carsFilter.SelectedBodyTypes.Contains((int)car.TechnicalCharacteristics.BodyType));
                }

                if (_carsFilter.SelectedTransmissionTypes.Count != 0)
                {
                    filteredCars = filteredCars.Where(car =>
                        _carsFilter.SelectedTransmissionTypes.Contains((int)car.TechnicalCharacteristics
                            .TransmissionType));
                }

                if (_carsFilter.SelectedEngineTypes.Count != 0)
                {
                    filteredCars = filteredCars.Where(car =>
                        _carsFilter.SelectedEngineTypes.Contains((int)car.TechnicalCharacteristics.EngineType));
                }

                _data.DataSource = ToCarsTable(filteredCars);
                dataGridView.ClearSelection();
                filteredData = filteredCars;
                break;
            case "Замовлення":
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

                _data.DataSource = ToOrdersTable(filteredOrders);
                dataGridView.ClearSelection();
                filteredData = filteredOrders;
                break;
        }


        if (filteredData.Cast<object>().Count() == 0)
        {
            MessageUtil.ShowInformation("Записів не було знайдено");
        }

        searchButton_Click(this, null);
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        searchTextBox.Text = string.Empty;

        switch (tableLabel.Text)
        {
            case "Автомобілі":
                _carsFilter = GetEmptyCarsFilter();
                _data.DataSource = ToCarsTable(_allCars);
                break;
            case "Замовлення":
                _ordersFilter = GetEmptyOrdersFilter();
                _data.DataSource = ToOrdersTable(_allOrders);
                break;
        }

        dataGridView.ClearSelection();
        searchButton_Click(this, null);
    }

    private static CarsFilter GetEmptyCarsFilter() => new()
    {
        PriceFrom = null,
        PriceTo = null,
        SelectedColors = [],
        SelectedBodyTypes = [],
        SelectedEngineTypes = [],
        SelectedTransmissionTypes = []
    };

    private static OrdersFilter GetEmptyOrdersFilter() => new()
    {
        PriceFrom = null,
        PriceTo = null,
        SelectedStatuses = []
    };
}