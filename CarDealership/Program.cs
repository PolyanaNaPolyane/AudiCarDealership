using CarDealership.Data.Entities;
using CarDealership.Data.Repositories;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Enums;
using CarDealership.Forms;
using CarDealership.Services;
using CarDealership.Services.Interfaces;
using CarDealership.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CarDealership;

public class Program
{
    [STAThread]
    private static void Main()
    {
        QuestPDF.Settings.License = LicenseType.Community;

        ApplicationConfiguration.Initialize();

        var host = CreateHostBuilder().Build();
        var loginForm = host.Services.GetRequiredService<LoginForm>();

        Application.Run(loginForm);
    }
    
    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddUserSecrets<Program>();
            })
            .ConfigureServices((context, services) =>
            {
                var connectionString = context.Configuration.GetConnectionString("DefaultConnection");

                services.AddSingleton<AccountContext>();
                
                services.AddTransient<MainForm>();
                services.AddTransient<LoginForm>();
                services.AddTransient<MainCustomerForm>();
                services.AddTransient<MainManagerForm>();
                services.AddTransient<RegistrationForm>();
                services.AddTransient<UserCarsForm>();
                services.AddTransient<UserOrdersForm>();

                services.AddTransient<IFormNavigation, FormNavigation>();
                services.AddTransient<IPasswordHasher, PasswordHasher>();
                services.AddTransient<IAccountService, AccountService>();
                services.AddTransient<ICarService, CarService>();
                services.AddTransient<IOrderService, OrderService>();

                services.AddTransient<IAccountRepository, AccountRepository>(serviceProvider => new AccountRepository(connectionString));
                services.AddTransient<IOrderRepository, OrderRepository>(serviceProvider => new OrderRepository(connectionString));
                services.AddTransient<ICarRepository, CarRepository>(serviceProvider => new CarRepository(connectionString));
                services.AddTransient<IContactDetailsRepository, ContactDetailsRepository>(serviceProvider => new ContactDetailsRepository(connectionString));
            });
    }
}