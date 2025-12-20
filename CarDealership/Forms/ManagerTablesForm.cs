using System.Data;
using CarDealership.Data.Entities;
using CarDealership.Services.Interfaces;
using CarDealership.Utils;

namespace CarDealership.Forms;

public partial class ManagerTablesForm : Form
{
    private readonly ICarService _carService;
    private readonly IOrderService _orderService;
    private readonly IAccountService _accountService;

    private readonly BindingSource _data = new();

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
        IAccountService accountService)
    {
        InitializeComponent();

        _carService = carService;
        _orderService = orderService;
        _accountService = accountService;
    }

    private void ManagerTablesForm_Load(object sender, EventArgs e)
    {
        tableLabel.Text = "Моделі";
        LoadCarsAsync();
    }
    
    private async Task LoadCarsAsync()
    {
        var cars = await _carService.GetAllAsync();
        _data.DataSource = ToCarsTable(cars);
        dataGridView.DataSource = _data;
        dataGridView.Columns["Id"].Visible = false;
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
}