using CarDealership.Data.Entities;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CarDealership.Utils;

public static class PdfGenerator
{
    public static void GeneratePdf(this Order order, string path)
    {
        var rootPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
        var backgroundImagePath = Path.Combine(rootPath, "Data", "Images", "details-background.png");

        var car = order.Car!;
        var account = order.Account!;
        var model = car.TechnicalCharacteristics!.Model!;
        var dealer = car.Dealer!;

        Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1f, Unit.Centimetre);

                    page.Background()
                        .Image(backgroundImagePath)
                        .FitArea();

                    page.DefaultTextStyle(x => x.FontSize(12).FontFamily("Arial"));

                    page.Header()
                        .Text("Замовлення користувача")
                        .SemiBold()
                        .FontSize(18)
                        .FontColor(Colors.Blue.Medium)
                        .AlignCenter();

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(column =>
                        {
                            column.Spacing(14);

                            column.Item().Text("— Інформація про замовлення —")
                                .Bold().FontSize(14).FontColor(Colors.Grey.Darken2);

                            column.Item().Text($"Номер замовлення: {order.Id}");
                            column.Item().Text($"Статус: {order.Status.GetDisplayName()}");
                            column.Item().Text($"Дата створення: {order.CreatedDate:dd.MM.yyyy HH:mm}");
                            column.Item()
                                .Text(
                                    $"Дата зміни статусу: {(order.StatusChangedDate.HasValue ? order.StatusChangedDate.Value.ToString("dd.MM.yyyy HH:mm") : "—")}");
                            column.Item().Text($"Загальна вартість: {order.OverallPrice}$");

                            column.Item().Text(" ");

                            column.Item().Text("— Дані покупця —")
                                .Bold().FontSize(14).FontColor(Colors.Grey.Darken2);

                            column.Item().Text($"ПІБ: {account.FirstName} {account.LastName}");
                            column.Item().Text($"Email: {account.Email}");

                            if (account.ContactDetails != null)
                            {
                                column.Item().Text($"Телефон: {account.ContactDetails.PhoneNumber}");
                                column.Item()
                                    .Text(
                                        $"Адреса: {account.ContactDetails.Country}, {account.ContactDetails.City}, {account.ContactDetails.Address}");
                            }
                            else
                            {
                                column.Item().Text("Контактні дані: —");
                            }

                            column.Item().Text(" ");

                            column.Item().Text("— Вибраний автомобіль —")
                                .Bold().FontSize(14).FontColor(Colors.Grey.Darken2);

                            column.Item().Text($"Модель: {model.Name}");
                            column.Item().Text($"Бренд: {model.Brand}");
                            column.Item().Text($"Рік: {car.Year}");
                            column.Item().Text($"Колір: {car.Color}");
                            column.Item().Text($"VIN: {car.VIN}");
                            column.Item().Text($"Ціна авто: {car.Price}$");

                            column.Item().Text(" ");

                            column.Item().Text("— Дилер (автосалон) —")
                                .Bold().FontSize(14).FontColor(Colors.Grey.Darken2);

                            column.Item().Text($"Назва автосалону: {dealer.Name}");
                            column.Item().Text($"Графік роботи: {dealer.Schedule}");
                            column.Item().Text($"Можливість лізингу: {(dealer.LeasingCapability ? "Так" : "Ні")}");
                            column.Item()
                                .Text($"Тест-драйв: {(dealer.TestDriveCapability ? "Доступний" : "Недоступний")}");

                            if (dealer.ContactDetails != null)
                            {
                                column.Item().Text($"Контакти дилера: {dealer.ContactDetails.PhoneNumber}");
                                column.Item()
                                    .Text(
                                        $"Адреса: {dealer.ContactDetails.Country}, {dealer.ContactDetails.City}, {dealer.ContactDetails.Address}");
                            }
                        });
                });
            })
            .GeneratePdf(path);
    }

    public static void GeneratePdf(this Car car, string path)
    {
        var rootPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
        var backgroundImagePath = Path.Combine(rootPath, "Data", "Images", "details-background.png");

        Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.ContinuousSize(PageSizes.A4.Width);
                    page.Margin(0.9f, Unit.Centimetre);

                    page.Background()
                        .Image(backgroundImagePath)
                        .FitArea();

                    page.DefaultTextStyle(x => x.FontSize(12).FontFamily("Arial"));

                    page.Header()
                        .Text("Технічні характеристики автомобіля")
                        .SemiBold()
                        .FontSize(16)
                        .FontColor(Colors.Blue.Medium)
                        .AlignCenter();

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(column =>
                        {
                            column.Spacing(10);
                            column.Item().Text($"Модель: {car.TechnicalCharacteristics.Model.Name}");
                            column.Item().Text($"Бренд: {car.TechnicalCharacteristics.Model.Brand ?? "N/A"}");
                            column.Item().Text($"Рік: {car.Year}");
                            column.Item().Text($"VIN: {car.VIN}");
                            column.Item().Text($"Ціна: {car.Price}$");
                            column.Item().Text($"Колір: {car.Color}");
                            column.Item().Text($"Тип кузова: {car.TechnicalCharacteristics.BodyType.GetDisplayName()}");
                            column.Item()
                                .Text($"Максимальна швидкість: {car.TechnicalCharacteristics.MaxSpeed} км/год");
                            column.Item()
                                .Text(
                                    $"Тип трансмісії: {car.TechnicalCharacteristics.TransmissionType.GetDisplayName()}");
                            column.Item()
                                .Text($"Витрата палива: {car.TechnicalCharacteristics.FuelConsumption} л/100км");
                            column.Item().Text($"Потужність: {car.TechnicalCharacteristics.Power} к.с.");
                            column.Item()
                                .Text($"Тип приводу: {car.TechnicalCharacteristics.DrivetrainType.GetDisplayName()}");
                            column.Item()
                                .Text($"Тип двигуна: {car.TechnicalCharacteristics.EngineType.GetDisplayName()}");
                            column.Item().Text($"Клас: {car.TechnicalCharacteristics.Model.Class}");
                        });
                });
            })
            .GeneratePdf(path);
    }
}