namespace CarDealership.Forms
{
    public partial class OrdersFilteringForm : Form
    {
        public OrdersFilteringForm()
        {
            InitializeComponent();
        }
    }


    public class OrdersFilter
    {
        public int? PriceFrom { get; set; }
        public int? PriceTo { get; set; }
        public List<int> SelectedStatuses { get; set; }
    }
}