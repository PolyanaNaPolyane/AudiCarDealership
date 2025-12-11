using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Enums;
using Microsoft.Data.SqlClient;

namespace CarDealership.Data.Repositories;

public class CarRepository(string connectionString) : BaseAdoNetRepository(connectionString), ICarRepository
{
    public async Task ChangeStatus(int id, CarStatus status)
    {
        var sql = "UPDATE [Car] SET Status = @status WHERE Id = @id";

        await using var command = new SqlCommand(sql, Connection);
        command.Parameters.AddWithValue("@status", status);
        command.Parameters.AddWithValue("@id", id);

        await command.ExecuteNonQueryAsync();
    }

    public async Task<IEnumerable<string>> GetMostPopularModelAsync()
    {
        var sql = @"
            WITH ModelOrderCounts AS (
                SELECT 
                    model.Name,
                    COUNT(o.Id) as OrderCount
                FROM [Model] model
                INNER JOIN [TechnicalCharacteristics] technicalCharacteristics ON technicalCharacteristics.ModelId = model.Id
                INNER JOIN [Car] car ON car.TechnicalCharacteristicsId = technicalCharacteristics.Id
                INNER JOIN [Order] o ON o.CarId = car.Id
                WHERE o.Status = 1
                GROUP BY model.Id, model.Name
            ),
            MaxOrderCount AS (
                SELECT MAX(OrderCount) as MaxCount
                FROM ModelOrderCounts
            )
            SELECT modelOrderCounts.Name
            FROM ModelOrderCounts modelOrderCounts
            CROSS JOIN MaxOrderCount maxOrderCount
            WHERE modelOrderCounts.OrderCount = maxOrderCount.MaxCount
            ORDER BY modelOrderCounts.Name
        ";

        var mostPopularModels = new List<string>();
        
        await using var command = new SqlCommand(sql, Connection);
        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            mostPopularModels.Add(reader.GetString(reader.GetOrdinal(nameof(Model.Name))));
        }
        
        return mostPopularModels;
    }

    public async Task<int> GetAvailableCountAsync()
    {
        var sql = "SELECT COUNT(*) FROM [Car] WHERE Status = 0";

        await using var command = new SqlCommand(sql, Connection);
        var result = await command.ExecuteScalarAsync();

        return result != null ? Convert.ToInt32(result) : 0;
    }

    public async Task<IEnumerable<Car>> GetAvaliableAllAsync()
    {
        var cars = new List<Car>();

        var sql = @"
            SELECT 
                car.Id, 
                car.VIN, 
                car.Price, 
                car.ImageUrl, 
                car.Color, 
                car.Year, 
                car.Status, 
                car.TechnicalCharacteristicsId, 
                car.DealerId,
                technicalCharacteristics.BodyType,
                technicalCharacteristics.MaxSpeed, 
                technicalCharacteristics.TransmissionType, 
                technicalCharacteristics.FuelConsumption,
                technicalCharacteristics.Power,
                technicalCharacteristics.DrivetrainType,
                technicalCharacteristics.EngineType,
                technicalCharacteristics.ModelId,
                model.Name,
                model.Brand,
                model.Class
            FROM [Car] car
            JOIN [TechnicalCharacteristics] technicalCharacteristics ON technicalCharacteristics.Id = car.TechnicalCharacteristicsId
            JOIN [Model] model ON model.Id = technicalCharacteristics.ModelId
            WHERE car.Status = 0";

        await using var command = new SqlCommand(sql, Connection);
        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            cars.Add(new Car
            {
                Id = reader.GetInt32(reader.GetOrdinal(nameof(Car.Id))),
                VIN = reader.GetGuid(reader.GetOrdinal(nameof(Car.VIN))),
                Price = reader.GetDecimal(reader.GetOrdinal(nameof(Car.Price))),
                ImageUrl = reader.GetString(reader.GetOrdinal(nameof(Car.ImageUrl))),
                Color = reader.GetString(reader.GetOrdinal(nameof(Car.Color))),
                Year = reader.GetInt32(reader.GetOrdinal(nameof(Car.Year))),
                Status = (CarStatus)reader.GetInt32(reader.GetOrdinal(nameof(Car.Status))),
                TechnicalCharacteristicsId = reader.GetInt32(reader.GetOrdinal(nameof(Car.TechnicalCharacteristicsId))),
                TechnicalCharacteristics = new TechnicalCharacteristics
                {
                    Id = reader.GetInt32(reader.GetOrdinal(nameof(Car.TechnicalCharacteristicsId))),
                    BodyType = (BodyType)reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.BodyType))),
                    MaxSpeed = reader.GetInt32(reader.GetOrdinal(nameof(Car.TechnicalCharacteristics.MaxSpeed))),
                    TransmissionType =
                        (TransmissionType)reader.GetInt32(
                            reader.GetOrdinal(nameof(TechnicalCharacteristics.TransmissionType))),
                    FuelConsumption =
                        reader.GetDecimal(reader.GetOrdinal(nameof(TechnicalCharacteristics.FuelConsumption))),
                    Power = reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.Power))),
                    DrivetrainType =
                        (DrivetrainType)reader.GetInt32(
                            reader.GetOrdinal(nameof(TechnicalCharacteristics.DrivetrainType))),
                    EngineType =
                        (EngineType)reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.EngineType))),
                    ModelId = reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.ModelId))),
                    Model = new Model
                    {
                        Id = reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.ModelId))),
                        Name = reader.GetString(reader.GetOrdinal(nameof(Model.Name))),
                        Brand = reader.GetString(reader.GetOrdinal(nameof(Model.Brand))),
                        Class = reader.GetString(reader.GetOrdinal(nameof(Model.Class))),
                    }
                },
                DealerId = reader.GetInt32(reader.GetOrdinal(nameof(Car.DealerId)))
            });
        }

        return cars;
    }

    // public async Task AddAsync(Car car)
    // {
    //     var sql =
    //         "INSERT INTO [Car] (Model, Price, ImageUrl, Color, Year) VALUES (@model, @price, @imageUrl, @segment, @color, @year)";
    //
    //     await using var command = new SqlCommand(sql, Connection);
    //     command.Parameters.AddWithValue("@price", car.Price);
    //     command.Parameters.AddWithValue("@imageUrl", car.ImageUrl);
    //     command.Parameters.AddWithValue("@color", car.Color);
    //     command.Parameters.AddWithValue("@year", car.Year);
    //
    //     await command.ExecuteNonQueryAsync();
    // }

    // public async Task UpdateAsync(Car car)
    // {
    //     var sql =
    //         "UPDATE [Car] SET Model = @model, Price = @price, ImageUrl = @imageUrl, Segment = @segment, Color = @color, Year = @year WHERE Id = @Id";
    //
    //     await using var command = new SqlCommand(sql, Connection);
    //     command.Parameters.AddWithValue("@Id", car.Id);
    //     command.Parameters.AddWithValue("@price", car.Price);
    //     command.Parameters.AddWithValue("@imageUrl", car.ImageUrl);
    //     command.Parameters.AddWithValue("@color", car.Color);
    //     command.Parameters.AddWithValue("@year", car.Year);
    //
    //     await command.ExecuteNonQueryAsync();
    // }

    // public async Task RemoveAsync(int id)
    // {
    //     var sql = "DELETE FROM [Car] WHERE Id = @Id";
    //     using var command = new SqlCommand(sql, Connection);
    //     command.Parameters.AddWithValue("@Id", id);
    //
    //     await command.ExecuteNonQueryAsync();
    // }
}