using System.Text;
using CarDealership.Utils;

namespace CarDealership.Forms;

public partial class CarsFilteringForm : Form
{
    public CarsFilteringForm(CarsFilter carsFilter)
    {
        InitializeComponent();

        CarsFilter = carsFilter;

        priceFromTextBox.Text = CarsFilter.PriceFrom?.ToString();
        priceToTextBox.Text = CarsFilter.PriceTo?.ToString();

        for (int i = 0; i < colorCheckedListBox.Items.Count; i++)
        {
            string item = colorCheckedListBox.Items[i].ToString();

            if (CarsFilter.SelectedColors != null && CarsFilter.SelectedColors.Contains(item))
            {
                colorCheckedListBox.SetItemChecked(i, true);
            }
        }
        
        foreach (int index in CarsFilter.SelectedBodyTypes)
        {
            if (index >= 0 && index < bodyTypeCheckedListBox.Items.Count)
            {
                bodyTypeCheckedListBox.SetItemChecked(index, true);
            }
        }
        
        foreach (int index in CarsFilter.SelectedTransmissionTypes)
        {
            if (index >= 0 && index < transmissionCheckedListBox.Items.Count)
            {
                transmissionCheckedListBox.SetItemChecked(index, true);
            }
        }
        
        foreach (int index in CarsFilter.SelectedEngineTypes)
        {
            if (index >= 0 && index < engineCheckedListBox.Items.Count)
            {
                engineCheckedListBox.SetItemChecked(index, true);
            }
        }
    }

    public CarsFilter CarsFilter { get; private set; }

    private void okButton_Click(object sender, EventArgs e)
    {
        var errors = GetValidationErrors();

        if (!string.IsNullOrWhiteSpace(errors))
        {
            MessageBox.Show(errors, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        CarsFilter.PriceFrom = string.IsNullOrEmpty(priceFromTextBox.Text)
            ? null
            : int.Parse(priceFromTextBox.Text);

        CarsFilter.PriceTo = string.IsNullOrEmpty(priceToTextBox.Text)
            ? null
            : int.Parse(priceToTextBox.Text);

        CarsFilter.SelectedColors = new List<string>();

        foreach (var item in colorCheckedListBox.CheckedItems)
        {
            CarsFilter.SelectedColors.Add(item.ToString());
        }

        foreach (var item in bodyTypeCheckedListBox.CheckedIndices)
        {
            CarsFilter.SelectedBodyTypes.Add((int)item);
        }
        
        foreach (var item in transmissionCheckedListBox.CheckedIndices)
        {
            CarsFilter.SelectedTransmissionTypes.Add((int)item);
        }
        
        foreach (var item in engineCheckedListBox.CheckedIndices)
        {
            CarsFilter.SelectedEngineTypes.Add((int)item);
        }
        
        DialogResult = DialogResult.OK;
        Close();
    }

    private string GetValidationErrors()
    {
        var errorIndex = 0;
        var errors = new StringBuilder();

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            priceFromTextBox.IsValidPriceFrom(out var invalidPriceFromMessage),
            invalidPriceFromMessage);

        int.TryParse(priceFromTextBox.Text, out var priceFrom);

        errors.AppendValidationErrorIfInvalid(
            ref errorIndex,
            priceToTextBox.IsValidPriceTo(priceFrom, out var invalidPriceToMessage),
            invalidPriceToMessage);

        return errors.ToString();
    }
}

public class CarsFilter
{
    public int? PriceFrom { get; set; }
    public int? PriceTo { get; set; }
    public List<string> SelectedColors { get; set; }
    public List<int> SelectedBodyTypes { get; set; }
    public List<int> SelectedEngineTypes { get; set; }
    public List<int> SelectedTransmissionTypes { get; set; }
}