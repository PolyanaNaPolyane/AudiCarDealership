using CarDealership.Services;
using CarDealership.Services.Interfaces;

namespace CarDealership.Forms;

public partial class MainManagerForm : Form
{
    private readonly ICarService _carService;
    private readonly AccountContext _accountContext;

    public MainManagerForm(ICarService carService, AccountContext accountContext)
    {
        InitializeComponent();

        _carService = carService;
        _accountContext = accountContext;

        accountLabel.Text = $"{_accountContext.CurrentAccount.FirstName} {_accountContext.CurrentAccount.LastName}";
    }

    private async void MainManagerForm_Load(object sender, EventArgs e)
    {
        var carsCount = await _carService.GetAvailableByAllDealersAsync();
        var mostPopularModels = await _carService.GetMostPopularModelsAsync();

        carsCountLabel.Text = carsCount.ToString();
        mostPopularCarsLabel.Text = string.Join(", ", mostPopularModels);
    }
}