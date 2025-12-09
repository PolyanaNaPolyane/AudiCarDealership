using CarDealership.Services.Interfaces;

namespace CarDealership.Forms;

public partial class MainForm : Form
{
    private readonly BindingSource _carsBindingSource = new();
    private readonly BindingSource _ordersBindingSource = new();
    private readonly BindingSource _accountsBindingSource = new();
    
    private readonly ICarService _carService;
    private readonly IAccountService _accountService;
    private readonly IOrderService _orderService;
    
    public MainForm(
        ICarService carService,
        IAccountService accountService,
        IOrderService orderService)
    {
        _carService = carService;
        _accountService = accountService;
        _orderService = orderService;
        
        InitializeComponent();
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        await LoadCarsAsync();
        await LoadOrdersAsync();
        await LoadAccountsAsync();
    }
    
    private async  Task LoadCarsAsync()
    {
        var cars = await _carService.GetAllAvailableAsync();
        _carsBindingSource.DataSource = cars;
        carsDataGridView.DataSource = _carsBindingSource;
    }

    private async Task LoadOrdersAsync()
    {
        var orders = await _orderService.GetAllAsync();
        _ordersBindingSource.DataSource = orders;
        ordersDataGridView.DataSource = _ordersBindingSource;
    }

    private async Task LoadAccountsAsync()
    {
        var accounts = await _accountService.GetAllAsync();
        _accountsBindingSource.DataSource = accounts;
        accountsDataGridView.DataSource = _accountsBindingSource;
    }
}