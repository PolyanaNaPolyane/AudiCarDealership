using CarDealership.Services;
using CarDealership.Services.Interfaces;

namespace CarDealership.Forms;

public partial class MainCustomerForm : Form
{
    private readonly IFormNavigation _formNavigation;
    private readonly IAccountService _accountService;
    private readonly AccountContext _accountContext;

    public MainCustomerForm(
        IFormNavigation formNavigation,
        IAccountService accountService,
        AccountContext accountContext)
    {
        _formNavigation = formNavigation;
        _accountService = accountService;
        _accountContext = accountContext;

        InitializeComponent();

        accountLabel.Text = $"{_accountContext.CurrentAccount.FirstName} {_accountContext.CurrentAccount.LastName}";
    }

    private async void MainCustomerForm_Load(object sender, EventArgs e)
    {
        var ordersCount = await _accountService.GetOrdersCountAsync(_accountContext.CurrentAccount.Id);
        var overallSpentMoney = await _accountService.GetOverrallSpentMoneyAsync(_accountContext.CurrentAccount.Id);

        ordersCountLabel.Text = ordersCount.ToString();
        spentMoneyLabel.Text = $@"{overallSpentMoney}$";
    }

    private void carsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _formNavigation.NavigateTo<UserCarsForm>(this);

    }

    private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _formNavigation.NavigateTo<UserOrdersForm>(this);
    }

    private async void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var choice = MessageBox.Show("Ви впевнені, що хочете продовжити видалення акаунта, при цьому усі незавершені замовлення також будуть видалені?", "Інформація", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        if (choice == DialogResult.OK)
        {
            await _accountService.DeleteAsync();
        }

        Close();
    }
}