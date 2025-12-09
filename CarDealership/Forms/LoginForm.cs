using System.Text;
using CarDealership.Enums;
using CarDealership.Services;
using CarDealership.Services.Interfaces;
using CarDealership.Utils;

namespace CarDealership.Forms;

public partial class LoginForm : Form
{
    private readonly IFormNavigation _formNavigation;
    private readonly IAccountService _accountService;
    private readonly AccountContext _accountContext;

    public LoginForm(
        IFormNavigation formNavigation,
        IAccountService accountService,
        AccountContext accountContext)
    {
        _formNavigation = formNavigation;
        _accountService = accountService;
        _accountContext = accountContext;

        InitializeComponent();
    }

    private async void loginButton_Click(object sender, EventArgs e)
    {
        var validation = ValidateLoginForm();

        if (!string.IsNullOrEmpty(validation))
        {
            MessageUtil.ShowError(validation);
            return;
        }

        var account = await _accountService.LoginAsync(emailTextBox.Text, passwordTextBox.Text);

        if (account == null)
        {
            MessageUtil.ShowError("Неправильно введена пошта чи пароль");
            return;
        }

        _accountContext.CurrentAccount = account;

        switch (_accountContext.CurrentAccount.Type)
        {
            case AccountType.Customer:
                _formNavigation.NavigateTo<MainCustomerForm>(this);
                break;
            case AccountType.Manager:
                _formNavigation.NavigateTo<MainManagerForm>(this);
                break;
        }

        emailTextBox.Text = string.Empty;
        passwordTextBox.Text = string.Empty;
    }

    private string ValidateLoginForm()
    {
        var errorIndex = 0;
        var errors = new StringBuilder();

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            emailTextBox.IsEmailValid(out var invalidEmailMessage),
            invalidEmailMessage);

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            passwordTextBox.IsPasswordValid(out var invalidPasswordMessage),
            invalidPasswordMessage);

        return errors.ToString();
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        _formNavigation.NavigateTo<RegistrationForm>(this);
    }
}