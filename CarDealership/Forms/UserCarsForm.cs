using System.Data;
using CarDealership.Data.Entities;
using CarDealership.Enums;
using CarDealership.Services.Interfaces;

namespace CarDealership.Forms;

public partial class UserCarsForm : Form
{
    private readonly BindingSource _carsBindingSource = new();
    private readonly ICarService _carService;
    private readonly IOrderService _orderService;

    private IEnumerable<Car> _allCars = [];

    private CarsFilter _carsFilter = new()
    {
        PriceFrom = null,
        PriceTo = null,
        SelectedColors = [],
        SelectedBodyTypes = [],
        SelectedEngineTypes = [],
        SelectedTransmissionTypes = []
    };

    public UserCarsForm(ICarService carService, IOrderService orderService)
    {
        _carService = carService;
        _orderService = orderService;

        InitializeComponent();
    }

    private async void CarsForm_Load(object sender, EventArgs e)
    {
        await LoadCarsAsync();
    }

    private async Task LoadCarsAsync()
    {
        _allCars = await _carService.GetAllAvailableAsync();
        _carsBindingSource.DataSource = ToCarsTable(_allCars);
        carsDataGridView.DataSource = _carsBindingSource;
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        string searchText = searchTextBox.Text.Trim();

        foreach (DataGridViewRow row in carsDataGridView.Rows)
        {
            row.DefaultCellStyle.BackColor = Color.White;
        }

        if (string.IsNullOrWhiteSpace(searchText))
        {
            return;
        }

        int foundRowsCount = 0;

        foreach (DataGridViewRow row in carsDataGridView.Rows)
        {
            if (row.IsNewRow)
            {
                continue;
            }

            var modelName = row.Cells[1].Value.ToString();

            if (!modelName.Contains(searchText))
            {
                continue;
            }

            foundRowsCount++;
            row.DefaultCellStyle.BackColor = Color.LightGreen;
        }

        if (foundRowsCount == 0)
        {
            MessageBox.Show("Записів не було знайдено", "Попередження", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
        }
    }

    private void applyButton_Click(object sender, EventArgs e)
    {
        var carFilteringForm = new CarsFilteringForm(_carsFilter);
        carFilteringForm.ShowDialog();
        _carsFilter = carFilteringForm.CarsFilter;

        var filteredCars = _allCars;

        if (_carsFilter.PriceFrom.HasValue)
        {
            filteredCars = filteredCars.Where(car => car.Price >= _carsFilter.PriceFrom.Value);
        }

        if (_carsFilter.PriceTo.HasValue)
        {
            filteredCars = filteredCars.Where(car => car.Price <= _carsFilter.PriceFrom.Value);
        }

        if (_carsFilter.SelectedColors.Count != 0)
        {
            filteredCars =
                filteredCars.Where(car => _carsFilter.SelectedColors.Any(color => car.Color.Contains(color)));
        }

        if (_carsFilter.SelectedBodyTypes.Count != 0)
        {
            filteredCars = filteredCars.Where(car =>
                _carsFilter.SelectedBodyTypes.Contains((int)car.TechnicalCharacteristics.BodyType));
        }

        if (_carsFilter.SelectedTransmissionTypes.Count != 0)
        {
            filteredCars = filteredCars.Where(car =>
                _carsFilter.SelectedTransmissionTypes.Contains((int)car.TechnicalCharacteristics.TransmissionType));
        }

        if (_carsFilter.SelectedEngineTypes.Count != 0)
        {
            filteredCars = filteredCars.Where(car =>
                _carsFilter.SelectedEngineTypes.Contains((int)car.TechnicalCharacteristics.EngineType));
        }

        _carsBindingSource.DataSource = ToCarsTable(filteredCars);
        carsDataGridView.Columns["Id"].Visible = false;
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        _carsFilter = new CarsFilter
        {
            PriceFrom = null,
            PriceTo = null,
            SelectedColors = [],
            SelectedBodyTypes = [],
            SelectedEngineTypes = [],
            SelectedTransmissionTypes = []
        };

        _carsBindingSource.DataSource = ToCarsTable(_allCars);
        carsDataGridView.Columns["Id"].Visible = false;
    }

    private DataTable ToCarsTable(IEnumerable<Car> cars)
    {
        var carsTable = new DataTable();
        carsTable.Columns.Add("Id", typeof(int));
        carsTable.Columns.Add("Модель", typeof(string));
        carsTable.Columns.Add("Ціна", typeof(decimal));
        carsTable.Columns.Add("Колір", typeof(string));
        carsTable.Columns.Add("Рік випуску", typeof(int));
        carsTable.Columns.Add("Статус", typeof(CarStatus));

        foreach (var car in cars)
        {
            carsTable.Rows.Add(car.Id, car.TechnicalCharacteristics.Model.Name, car.Price, car.Color, car.Year,
                car.Status);
        }

        return carsTable;
    }

    private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var selectedRowView = (DataRowView)carsDataGridView.CurrentRow.DataBoundItem;
        var selectedRow = selectedRowView.Row;
        var selectedCar = _allCars.First(car => car.Id == selectedRow.Field<int>("Id"));
        var carDetailsForm = new CarDetailsForm(selectedCar);
        carDetailsForm.ShowDialog();
    }

    private async void orderToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var selectedRowView = (DataRowView)carsDataGridView.CurrentRow.DataBoundItem;
        var selectedRow = selectedRowView.Row;
        var selectedCar = _allCars.First(car => car.Id == selectedRow.Field<int>("Id"));
        await _orderService.AddAsync(selectedCar);
        _allCars = _allCars.Where(car => car.Id != selectedRow.Field<int>("Id"));
    }
}