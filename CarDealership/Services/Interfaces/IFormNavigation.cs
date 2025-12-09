namespace CarDealership.Services.Interfaces;

public interface IFormNavigation
{
    void NavigateTo<T>(Form formToNavigateFrom) where T : Form;
}