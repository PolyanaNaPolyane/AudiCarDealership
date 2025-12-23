using System.Text;
using CarDealership.Data.Entities;
using CarDealership.Enums;
using CarDealership.Services.Interfaces;
using CarDealership.Utils;

namespace CarDealership.Forms;

public partial class UpsertOrderForm : Form
{
    private readonly bool _isEditing;
    private readonly Order _order = null;

    private readonly IOrderService _orderService;
    private readonly IAccountService _accountService;
    private readonly ICarService _carService;

    public UpsertOrderForm(
        IOrderService orderService,
        IAccountService accountService,
        ICarService carService)
    {
        InitializeComponent();

        Text = "Створення замовлення";
        _orderService = orderService;
        _accountService = accountService;
        _carService = carService;
        _isEditing = false;
    }

    public UpsertOrderForm(
        IOrderService orderService,
        IAccountService accountService,
        ICarService carService,
        Order order)
    {
        InitializeComponent();

        _isEditing = true;
        Text = "Редагування замовлення";
        _orderService = orderService;
        _accountService = accountService;
        _carService = carService;
        _order = order;
    }

    private async void UpsertOrderForm_Load(object sender, EventArgs e)
    {
        var accounts = await _accountService.GetAllAsync();
        var cars = (await _carService.GetAllAvailableAsync()).ToList();

        if (_isEditing)
        {
            cars.Add(_order.Car);
        }

        accountComboBox.DataSource = accounts;
        accountComboBox.DisplayMember = "Email";
        accountComboBox.ValueMember = "Id";

        carComboBox.DataSource = cars;
        carComboBox.DisplayMember = "ModelName";
        carComboBox.ValueMember = "Id";

        statusComboBox.DataSource = new List<KeyValuePair<int, string>>
        {
            new(0, "Очікує підтверження"),
            new(1, "Підтверджений"),
            new(2, "Відхилений")
        };
        statusComboBox.DisplayMember = "Value";
        statusComboBox.ValueMember = "Key";

        if (!_isEditing)
        {
            accountComboBox.SelectedIndex = -1;
            carComboBox.SelectedIndex = -1;
            orderCreationDateTimePicker.Value = DateTime.Now;
            statusComboBox.SelectedIndex = 0;
        }
        else
        {
            accountComboBox.SelectedValue = _order.AccountId;
            carComboBox.SelectedValue = _order.CarId;
            orderCreationDateTimePicker.Value = _order.CreatedDate;
            overallPriceTextBox.Text = _order.OverallPrice.ToString();
            statusComboBox.SelectedIndex = (int)_order.Status;
        }
    }

    private async void okButton_Click(object sender, EventArgs e)
    {
        var errors = GetValidationErrors();

        if (!string.IsNullOrWhiteSpace(errors))
        {
            MessageUtil.ShowError(errors);
            return;
        }

        var order = new Order
        {
            Id = _order.Id,
            AccountId = (int)accountComboBox.SelectedValue,
            CarId = (int)carComboBox.SelectedValue,
            CreatedDate = orderCreationDateTimePicker.Value,
            OverallPrice = Convert.ToDecimal(overallPriceTextBox.Text),
            Status = (OrderStatus)statusComboBox.SelectedValue,
            StatusChangedDate = (OrderStatus)statusComboBox.SelectedValue == _order?.Status ? null : DateTime.Now,
        };

        if (_isEditing)
        {
            await _orderService.UpdateAsync(order);

            if (order.CarId != _order.CarId)
            {
                await _carService.ChangeStatusAsync(_order.CarId, CarStatus.Available);
            }
        }
        else
        {
            await _orderService.AddAsync(order);
        }

        switch (order.Status)
        {
            case OrderStatus.Pending:
                await _carService.ChangeStatusAsync(order.CarId, CarStatus.Reserved);
                break;
            case OrderStatus.Approved:
                await _carService.ChangeStatusAsync(order.CarId, CarStatus.Sold);
                break;
            case OrderStatus.Rejected:
                await _carService.ChangeStatusAsync(order.CarId, CarStatus.Available);
                break;
        }

        Close();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private string GetValidationErrors()
    {
        var errorIndex = 0;
        var errors = new StringBuilder();

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            accountComboBox.IsValidAccount(out var invalidAccountMessage),
            invalidAccountMessage);

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            carComboBox.IsValidCar(out var invalidCarMessage),
            invalidCarMessage);

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            overallPriceTextBox.IsValidOverallPrice(out var invalidOverallPriceMessage),
            invalidOverallPriceMessage);

        return errors.ToString();
    }
}