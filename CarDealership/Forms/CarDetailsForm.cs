using CarDealership.Data.Entities;
using CarDealership.Utils;

namespace CarDealership.Forms;

public partial class CarDetailsForm : Form
{
    private readonly Car _car;

    public CarDetailsForm(Car car)
    {
        InitializeComponent();

        _car = car;
        brandValueLabel.Text = _car.TechnicalCharacteristics.Model.Brand;
        modelValueLabel.Text = _car.TechnicalCharacteristics.Model.Name;
        yearValueLabel.Text = _car.Year.ToString();
        VINValueLabel.Text = _car.VIN.ToString();
        priceValueLabel.Text = _car.Price.ToString();
        colorValueLabel.Text = _car.Color;
        bodyTypeVauleLabel.Text = _car.TechnicalCharacteristics.BodyType.GetDisplayName();
        topSpeedValueLabel.Text = _car.TechnicalCharacteristics.MaxSpeed.ToString();
        transmissionTypeValueLabel.Text =  _car.TechnicalCharacteristics.TransmissionType.GetDisplayName();
        fuelConsumptionValueLabel.Text = _car.TechnicalCharacteristics.FuelConsumption.ToString();
        powerValueLabel.Text = _car.TechnicalCharacteristics.Power.ToString();
        driveTrainTypeValueLabel.Text = _car.TechnicalCharacteristics.DrivetrainType.GetDisplayName();
        engineTypeValueLabel.Text = _car.TechnicalCharacteristics.EngineType.GetDisplayName();
        classValueLabel.Text = _car.TechnicalCharacteristics.Model.Class;
    }

    private void exportButton_Click(object sender, EventArgs e)
    {
        using var folderBrowsingDialog = new FolderBrowserDialog();
        folderBrowsingDialog.Description = "Оберіть папку для збереження звіту";
        folderBrowsingDialog.UseDescriptionForTitle = true;

        if (folderBrowsingDialog.ShowDialog() == DialogResult.OK)
        {
            var selectedPath = folderBrowsingDialog.SelectedPath;
            _car.GeneratePdf(Path.Combine(selectedPath, $"{_car.VIN}-details.pdf"));
            MessageUtil.ShowInformation("Деталі автомобіля успішно експортовані");
        }
    }
}