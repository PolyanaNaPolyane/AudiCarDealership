using System.Text;
using CarDealership.Data.Entities;
using CarDealership.Enums;
using CarDealership.Services.Interfaces;
using CarDealership.Utils;

namespace CarDealership.Forms;

public partial class UpsertCarForm : Form
{
    private readonly bool _isEditing;
    private readonly Car _car = null;

    private readonly ICarService _carService;
    private readonly ITechnicalCharacteristicsService _technicalCharacteristicsService;
    private readonly IDealerService _dealerService;

    public UpsertCarForm(
        ICarService carService,
        ITechnicalCharacteristicsService technicalCharacteristicsService,
        IDealerService dealerService)
    {
        InitializeComponent();

        Text = "Створення автомобіля";
        _carService = carService;
        _technicalCharacteristicsService = technicalCharacteristicsService;
        _dealerService = dealerService;
        _isEditing = false;
    }

    public UpsertCarForm(
        ICarService carService,
        ITechnicalCharacteristicsService technicalCharacteristicsService,
        IDealerService dealerService,
        Car car)
    {
        InitializeComponent();

        Text = "Редагування автомобіля";
        _carService = carService;
        _technicalCharacteristicsService = technicalCharacteristicsService;
        _dealerService = dealerService;
        _car = car;
        _isEditing = true;
    }

    private async void UpsertCarForm_Load(object sender, EventArgs e)
    {
        var dealers = await _dealerService.GetAllAsync();
        var technicalCharacteristics = await _technicalCharacteristicsService.GetAllAsync();

        dealerComboBox.DataSource = dealers;
        dealerComboBox.DisplayMember = "Name";
        dealerComboBox.ValueMember = "Id";

        technicalCharacteristicsComboBox.DataSource = technicalCharacteristics;
        technicalCharacteristicsComboBox.DisplayMember = "CharacteristicsName";
        technicalCharacteristicsComboBox.ValueMember = "Id";

        statusComboBox.DataSource = new List<KeyValuePair<int, string>>
        {
            new(0, "Доступний"),
            new(1, "Зарезервований"),
            new(2, "Проданий")
        };
        statusComboBox.DisplayMember = "Value";
        statusComboBox.ValueMember = "Key";

        if (!_isEditing)
        {
            dealerComboBox.SelectedIndex = -1;
            technicalCharacteristicsComboBox.SelectedIndex = -1;
            statusComboBox.SelectedIndex = 0;
            vinTextBox.Text = Guid.NewGuid().ToString();
        }
        else
        {
            vinTextBox.Text = _car.VIN.ToString();
            priceTextBox.Text = _car.Price.ToString();
            imageUrlTextBox.Text = _car.ImageUrl;
            colorTextBox.Text = _car.Color;
            yearTextBox.Text = _car.Year.ToString();
            statusComboBox.SelectedIndex = (int)_car.Status;
            dealerComboBox.SelectedIndex = _car.DealerId;
            technicalCharacteristicsComboBox.SelectedIndex = _car.TechnicalCharacteristicsId;
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

        var car = new Car
        {
            Id = _car.Id,
            VIN = Guid.Parse(vinTextBox.Text),
            Price = decimal.Parse(priceTextBox.Text),
            ImageUrl = imageUrlTextBox.Text,
            Color = colorTextBox.Text,
            Year = int.Parse(yearTextBox.Text),
            Status = (CarStatus)statusComboBox.SelectedIndex,
            TechnicalCharacteristicsId = (int)technicalCharacteristicsComboBox.SelectedValue,
            DealerId = (int)dealerComboBox.SelectedValue
        };

        if (_isEditing)
        {
            await _carService.UpdateAsync(car);
        }
        else
        {
            await _carService.AddAsync(car);
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
            priceTextBox.IsValidPrice(out var invalidPriceMessage),
            invalidPriceMessage);

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            imageUrlTextBox.IsValidImage(out var invalidImageMessage),
            invalidImageMessage);

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            colorTextBox.IsValidColor(out var invalidColorMessage),
            invalidColorMessage);

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            yearTextBox.IsValidYear(out var invalidYearMessage),
            invalidYearMessage);

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            dealerComboBox.IsValidDealer(out var invalidDealerMessage),
            invalidDealerMessage);

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            technicalCharacteristicsComboBox.IsValidTechnicalCharacteristics(
                out var invalidTechnicalCharacteristicsMessage),
            invalidTechnicalCharacteristicsMessage);

        return errors.ToString();
    }
}