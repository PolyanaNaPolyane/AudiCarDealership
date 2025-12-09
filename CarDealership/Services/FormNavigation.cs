using Microsoft.Extensions.DependencyInjection;

using CarDealership.Services.Interfaces;

namespace CarDealership.Services;

public class FormNavigation(IServiceProvider serviceProvider) : IFormNavigation
{
    public void NavigateTo<T>(Form formToNavigateFrom) where T : Form
    {
        var formToNavigateTo = serviceProvider.GetRequiredService<T>();
        formToNavigateTo.FormClosed += (sender, args) => formToNavigateFrom.Show();
        formToNavigateTo.Show();
        formToNavigateFrom.Hide();
    }
}