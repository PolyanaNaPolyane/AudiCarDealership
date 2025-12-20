using CarDealership.Services;
using CarDealership.Services.Interfaces;

namespace CarDealership.Forms;

public partial class MainManagerForm : Form
{
    private readonly ICarService _carService;
    private readonly IOrderService _orderService;
    private readonly AccountContext _accountContext;

    public MainManagerForm(ICarService carService, IOrderService orderService, AccountContext accountContext)
    {
        InitializeComponent();

        _carService = carService;
        _orderService = orderService;
        _accountContext = accountContext;

        accountLabel.Text = $"{_accountContext.CurrentAccount.FirstName} {_accountContext.CurrentAccount.LastName}";
    }

    private async void MainManagerForm_Load(object sender, EventArgs e)
    {
        var carsCount = await _carService.GetAvailableByAllDealersAsync();
        var mostPopularModels = await _carService.GetMostPopularModelsAsync();
        var overallProfit = await _orderService.GetOverallProfitAsync();

        carsCountLabel.Text = carsCount.ToString();
        mostPopularCarsLabel.Text = string.Join(", ", mostPopularModels);
        overallProfitLabel.Text = overallProfit.ToString();
    }

    private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
}