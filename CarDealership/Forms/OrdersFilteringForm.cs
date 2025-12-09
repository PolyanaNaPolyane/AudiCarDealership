using System.Text;
using CarDealership.Utils;

namespace CarDealership.Forms
{
    public partial class OrdersFilteringForm : Form
    {
        public OrdersFilteringForm(OrdersFilter ordersFilter)
        {
            InitializeComponent();

            OrdersFilter = ordersFilter;

            priceFromTextBox.Text = OrdersFilter.PriceFrom?.ToString();
            priceToTextBox.Text = OrdersFilter.PriceTo?.ToString();

            foreach (int index in OrdersFilter.SelectedStatuses)
            {
                if (index >= 0 && index < statusCheckedListBox.Items.Count)
                {
                    statusCheckedListBox.SetItemChecked(index, true);
                }
            }
        }

        public OrdersFilter OrdersFilter { get; private set; }

        private void okButton_Click(object sender, EventArgs e)
        {
            var errors = GetValidationErrors();

            if (!string.IsNullOrWhiteSpace(errors))
            {
                MessageBox.Show(errors, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OrdersFilter.PriceFrom = string.IsNullOrEmpty(priceFromTextBox.Text)
                ? null
                : int.Parse(priceFromTextBox.Text);

            OrdersFilter.PriceTo = string.IsNullOrEmpty(priceToTextBox.Text)
                ? null
                : int.Parse(priceToTextBox.Text);

            OrdersFilter.SelectedStatuses = new List<int>();

            foreach (var item in statusCheckedListBox.CheckedIndices)
            {
                OrdersFilter.SelectedStatuses.Add((int)item);
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

    public class OrdersFilter
    {
        public int? PriceFrom { get; set; }
        public int? PriceTo { get; set; }
        public List<int> SelectedStatuses { get; set; }
    }
}