using System.Text;
using CarDealership.Data.Entities;
using CarDealership.Enums;
using CarDealership.Services;
using CarDealership.Services.Interfaces;
using CarDealership.Utils;

namespace CarDealership.Forms;

public partial class RegistrationForm : Form
{
    private readonly IFormNavigation _formNavigation;
    private readonly IAccountService _accountService;
    private readonly AccountContext _accountContext;

    public RegistrationForm(IFormNavigation formNavigation, IAccountService accountService, AccountContext accountContext)
    {
        InitializeComponent();

        _formNavigation = formNavigation;
        _accountService = accountService;
        _accountContext = accountContext;
    }

    private async void registerButton_Click(object sender, EventArgs e)
    {
        var validation = ValidateRegisterForm();

        if (!string.IsNullOrEmpty(validation))
        {
            MessageUtil.ShowError(validation);
            return;
        }
        
        var account = await _accountService.RegisterAsync(new Account
        {
            FirstName = firstNameTextBox.Text,
            LastName = lastNameTextBox.Text,
            Email = emailTextBox.Text,
            PasswordHash = passwordTextBox.Text,
            Type = AccountType.Customer,
            ContactDetails = new ContactDetails
            {
                Country = countryTextBox.Text,
                City = cityTextBox.Text,
                Address = addressTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text
            }
        });

        if (account == null)
        {
            MessageUtil.ShowError("Користувач з такою поштою вже існує");
            return;
        }
        
        _accountContext.CurrentAccount = account;
        _formNavigation.NavigateTo<MainCustomerForm>(this);
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        _formNavigation.NavigateTo<LoginForm>(this);
    }
    
    private string ValidateRegisterForm()
    {
        var errorIndex = 0;
        var errors = new StringBuilder();
        
        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            firstNameTextBox.IsFirstNameValid(out var invalidFirstNameMessage),
            invalidFirstNameMessage);
        
        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            lastNameTextBox.IsLastNameValid(out var invalidLastNameMessage),
            invalidLastNameMessage);

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            emailTextBox.IsEmailValid(out var invalidEmailMessage),
            invalidEmailMessage);
        
        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            passwordTextBox.IsPasswordValid(out var invalidPasswordMessage),
            invalidPasswordMessage);
        
        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            countryTextBox.IsCountryValid(out var invalidCountryMessage),
            invalidCountryMessage);
        
        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            cityTextBox.IsCityValid(out var invalidCityMessage),
            invalidCityMessage);
        
        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            addressTextBox.IsAddressValid(out var invalidAddressMessage),
            invalidAddressMessage);
        
        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            phoneNumberTextBox.IsPhoneNumberValid(out var invalidPhoneMessage),
            invalidPhoneMessage);
        
        return errors.ToString();
    }
}