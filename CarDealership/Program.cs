using CarDealership.Data.Repositories;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Forms;
using CarDealership.Services;
using CarDealership.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
        var loginForm = host.Services.GetRequiredService<MainManagerForm>();

        Application.Run(loginForm);
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) => { config.AddUserSecrets<Program>(); })
            .ConfigureServices((context, services) =>
            {
                var connectionString = context.Configuration.GetConnectionString("DefaultConnection");

                services.AddSingleton<AccountContext>();

                services.AddTransient<LoginForm>();
                services.AddTransient<MainCustomerForm>();
                services.AddTransient<MainManagerForm>();
                services.AddTransient<RegistrationForm>();
                services.AddTransient<UserCarsForm>();
                services.AddTransient<UserOrdersForm>();
                services.AddTransient<ManagerTablesForm>();

                services.AddTransient<IFormNavigation, FormNavigation>();
                services.AddTransient<IPasswordHasher, PasswordHasher>();
                services.AddTransient<IAccountService, AccountService>();
                services.AddTransient<ICarService, CarService>();
                services.AddTransient<IOrderService, OrderService>();
                services.AddTransient<IDealerService, DealerService>();
                services.AddTransient<IContactDetailsService, ContactDetailsService>();
                services.AddTransient<IModelService, ModelService>();
                services.AddTransient<ITechnicalCharacteristicsService, TechnicalCharacteristicsService>();

                services.AddTransient<IAccountRepository, AccountRepository>(serviceProvider =>
                    new AccountRepository(connectionString));
                services.AddTransient<IOrderRepository, OrderRepository>(serviceProvider =>
                    new OrderRepository(connectionString));
                services.AddTransient<ICarRepository, CarRepository>(serviceProvider =>
                    new CarRepository(connectionString));
                services.AddTransient<IContactDetailsRepository, ContactDetailsRepository>(serviceProvider =>
                    new ContactDetailsRepository(connectionString));
                services.AddTransient<IModelRepository, ModelRepository>(serviceProvider =>
                    new ModelRepository(connectionString));
                services
                    .AddTransient<ITechnicalCharacteristicsRepository,
                        TechnicalCharacteristicsRepository>(serviceProvider =>
                        new TechnicalCharacteristicsRepository(connectionString));
                services.AddTransient<IDealerRepository, DealerRepository>(serviceProvider =>
                    new DealerRepository(connectionString));
            });
    }
}