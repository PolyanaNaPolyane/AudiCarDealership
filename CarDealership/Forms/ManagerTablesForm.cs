using CarDealership.Services.Interfaces;

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
    }
}