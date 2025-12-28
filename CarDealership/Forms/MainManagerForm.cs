using CarDealership.Services;
using CarDealership.Services.Interfaces;

namespace CarDealership.Forms;

public partial class MainManagerForm : Form
{
    private readonly ICarService _carService;
    private readonly IOrderService _orderService;
    private readonly IFormNavigation _formNavigation;

    public MainManagerForm(
        ICarService carService,
        IOrderService orderService,
        IFormNavigation formNavigation,
        AccountContext accountContext)
    {
        InitializeComponent();

        _carService = carService;
        _orderService = orderService;
        _formNavigation = formNavigation;

        accountLabel.Text = $"{accountContext.CurrentAccount.FirstName} {accountContext.CurrentAccount.LastName}";
    }

    private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _formNavigation.NavigateTo<ManagerTablesForm>(this);
    }

    protected override async void OnActivated(EventArgs e)
    {
        base.OnActivated(e);

        var carsCount = await _carService.GetAvailableByAllDealersAsync();
        var mostPopularModels = await _carService.GetMostPopularModelsAsync();
        var overallProfit = await _orderService.GetOverallProfitAsync();

        carsCountLabel.Text = carsCount.ToString();
        mostPopularCarsLabel.Text = string.Join(", ", mostPopularModels);
        overallProfitLabel.Text = overallProfit.ToString();
    }
}