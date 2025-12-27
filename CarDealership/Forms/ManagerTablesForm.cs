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

    private CarsFilter _carsFilter = new()
    {
        PriceFrom = null,
        PriceTo = null,
        SelectedColors = [],
        SelectedBodyTypes = [],
        SelectedEngineTypes = [],
        SelectedTransmissionTypes = []
    };

    private OrdersFilter _ordersFilter = new()
    {
        PriceFrom = null,
        PriceTo = null,
        SelectedStatuses = []
    };

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
        await LoadModelsAsync();
    }

    private async Task LoadModelsAsync()
    {
        var models = await _modelService.GetAllAsync();
        _data.DataSource = ToModelsTable(models);
        dataGridView.DataSource = _data;
    }

    private async Task LoadTechnicalCharacteristicsAsync()
    {
        var technicalCharacteristics = await _technicalCharacteristicsService.GetAllAsync();
        _data.DataSource = ToTechnicalCharacteristicsTable(technicalCharacteristics);
        dataGridView.DataSource = _data;
    }

    private async Task LoadOrdersAsync()
    {
        _allOrders = await _orderService.GetAllAsync();
        _data.DataSource = ToOrdersTable(_allOrders);
        dataGridView.DataSource = _data;
    }

    private async Task LoadAccountsAsync()
    {
        var accounts = await _accountService.GetAllAsync();
        _data.DataSource = ToAccountsTable(accounts);
        dataGridView.DataSource = _data;
    }

    private async Task LoadDealersAsync()
    {
        var dealers = await _dealerService.GetAllAsync();
        _data.DataSource = ToDelaersTable(dealers);
        dataGridView.DataSource = _data;
    }

    private async Task LoadContactDetailsAsync()
    {
        var contacts = await _contactDetailsService.GetAllAsync();
        _data.DataSource = ToContactDetailsTable(contacts);
        dataGridView.DataSource = _data;
    }

    private async Task LoadCarsAsync()
    {
        _allCars = await _carService.GetAllAsync();
        _data.DataSource = ToCarsTable(_allCars);
        dataGridView.DataSource = _data;
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
        technicalCharacteristicsTable.Columns.Add("Тип кузова", typeof(string));
        technicalCharacteristicsTable.Columns.Add("Максимальна швидкість", typeof(int));
        technicalCharacteristicsTable.Columns.Add("Тип трансміссії", typeof(string));
        technicalCharacteristicsTable.Columns.Add("Витрата палива", typeof(decimal));
        technicalCharacteristicsTable.Columns.Add("Потужність", typeof(int));
        technicalCharacteristicsTable.Columns.Add("Тип приводу", typeof(string));
        technicalCharacteristicsTable.Columns.Add("Тип двигуна", typeof(string));


        foreach (var characteristics in technicalCharacteristics)
        {
            technicalCharacteristicsTable.Rows.Add(characteristics.Id, characteristics.BodyType.GetDisplayName(),
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
            ordersTable.Rows.Add(order.Id, order.Account.Email,
                $"{order.Car.TechnicalCharacteristics.Model.Brand} {order.Car.TechnicalCharacteristics.Model}",
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
        actionsToolStripMenuItem.Visible = false;
        await LoadModelsAsync();
    }

    private async void technicalCharacteristicsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Технічні характеристики";
        actionsToolStripMenuItem.Visible = false;
        await LoadTechnicalCharacteristicsAsync();
    }

    private async void carsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Автомобілі";
        actionsToolStripMenuItem.Visible = true;
        await LoadCarsAsync();
    }

    private async void dealersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Дилери";
        actionsToolStripMenuItem.Visible = false;
        await LoadDealersAsync();
    }

    private async void accountsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Акаунти";
        actionsToolStripMenuItem.Visible = false;
        await LoadAccountsAsync();
    }

    private async void ordersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Замовлення";
        actionsToolStripMenuItem.Visible = true;
        await LoadOrdersAsync();
    }

    private async void contactDetailsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tableLabel.Text = "Контакні дані";
        actionsToolStripMenuItem.Visible = false;
        await LoadContactDetailsAsync();
    }

    private void addToolStripMenuItem_Click(object sender, EventArgs e)
    {
        switch (tableLabel.Text)
        {
            case "Автомобілі":
                var addCarForm = new UpsertCarForm(_carService, _technicalCharacteristicsService, _dealerService);
                addCarForm.ShowDialog();
                break;
            case "Замовлення":
                var addOrderForm = new UpsertOrderForm(_orderService, _accountService, _carService);
                addOrderForm.ShowDialog();
                break;
        }
    }

    private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var selectedRowView = (DataRowView)dataGridView.CurrentRow.DataBoundItem;
        var selectedRow = selectedRowView.Row;

        switch (tableLabel.Text)
        {
            case "Автомобілі":
                var selectedCar = _allCars.First(car => car.Id == selectedRow.Field<int>("Id"));

                if (selectedCar.Status != CarStatus.Available)
                {
                    MessageUtil.ShowError("Неможливо видалити автомобіль");
                    return;
                }
                
                await _carService.DeleteAsync(selectedCar.Id);
                break;
            case "Змовлення":
                var selectedOrder = _allOrders.First(car => car.Id == selectedRow.Field<int>("Id"));

                if (selectedOrder.Status != OrderStatus.Pending)
                {
                    MessageUtil.ShowError("Неможливо видалити замовлення");
                    return;
                }

                await _orderService.DeleteAsync(selectedOrder.Id);
                await _carService.ChangeStatusAsync(selectedOrder.CarId, CarStatus.Available);
                break;
        }
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var selectedRowView = (DataRowView)dataGridView.CurrentRow.DataBoundItem;
        var selectedRow = selectedRowView.Row;

        switch (tableLabel.Text)
        {
            case "Автомобілі":
                var carToUpdate = _allCars.First(car => car.Id == selectedRow.Field<int>("Id"));
                var updateCarForm = new UpsertCarForm(_carService, _technicalCharacteristicsService, _dealerService, carToUpdate);
                updateCarForm.ShowDialog();
                break;
            case "Замовлення":
                var orderToUpdate = _allOrders.First(car => car.Id == selectedRow.Field<int>("Id"));
                var updateOrderForm = new UpsertOrderForm(_orderService, _accountService, _carService, orderToUpdate);
                updateOrderForm.ShowDialog();
                break;
        }
    }
}