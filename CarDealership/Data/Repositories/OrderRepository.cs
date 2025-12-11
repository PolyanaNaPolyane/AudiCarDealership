using Microsoft.Data.SqlClient;
using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Enums;

namespace CarDealership.Data.Repositories;

public class OrderRepository(string connectionString) : BaseAdoNetRepository(connectionString), IOrderRepository
{
    public async Task<IEnumerable<Order>> GetAllAsync(int accountId)
    {
        var orders = new List<Order>();

        var sql =
            @"SELECT
                o.Id, 
                o.AccountId, 
                o.CarId, 
                o.CreatedDate, 
                o.OverallPrice, 
                o.Status, 
                o.StatusChangedDate, 
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
            FROM [Order] o
            JOIN [Car] car ON car.Id = o.CarId
            JOIN [TechnicalCharacteristics] technicalCharacteristics ON technicalCharacteristics.Id = car.TechnicalCharacteristicsId
            JOIN [Model] model ON model.Id = technicalCharacteristics.ModelId
            WHERE o.AccountId = @accountId";

        await using var command = new SqlCommand(sql, Connection);
        command.Parameters.AddWithValue("@accountId", accountId);
        
        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            orders.Add(new Order
            {
                Id = reader.GetInt32(reader.GetOrdinal(nameof(Order.Id))),
                AccountId = reader.GetInt32(reader.GetOrdinal(nameof(Order.AccountId))),
                CarId = reader.GetInt32(reader.GetOrdinal(nameof(Order.CarId))),
                Car = new Car
                {
                    Id = reader.GetInt32(reader.GetOrdinal(nameof(Order.CarId))),
                    DealerId = reader.GetInt32(reader.GetOrdinal(nameof(Car.DealerId))),
                    TechnicalCharacteristicsId = reader.GetInt32(reader.GetOrdinal(nameof(Car.TechnicalCharacteristicsId))),
                    TechnicalCharacteristics = new TechnicalCharacteristics
                    {
                        Id = reader.GetInt32(reader.GetOrdinal(nameof(Car.TechnicalCharacteristicsId))),
                        BodyType = (BodyType)reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.BodyType))),
                        MaxSpeed = reader.GetInt32(reader.GetOrdinal(nameof(Car.TechnicalCharacteristics.MaxSpeed))),
                        TransmissionType =
                            (TransmissionType)reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.TransmissionType))),
                        FuelConsumption =
                            reader.GetDecimal(reader.GetOrdinal(nameof(TechnicalCharacteristics.FuelConsumption))),
                        Power = reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.Power))),
                        DrivetrainType =
                            (DrivetrainType)reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.DrivetrainType))),
                        ModelId = reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.ModelId))),
                        Model = new Model
                        {
                            Id = reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.ModelId))),
                            Name = reader.GetString(reader.GetOrdinal(nameof(Model.Name))),
                            Brand = reader.GetString(reader.GetOrdinal(nameof(Model.Brand))),
                            Class = reader.GetString(reader.GetOrdinal(nameof(Model.Class)))
                        }
                    }
                },
                CreatedDate = reader.GetDateTime(reader.GetOrdinal(nameof(Order.CreatedDate))),
                OverallPrice = reader.GetDecimal(reader.GetOrdinal(nameof(Order.OverallPrice))),
                Status = (OrderStatus)reader.GetInt32(reader.GetOrdinal(nameof(Order.Status))),
                StatusChangedDate = reader.IsDBNull(reader.GetOrdinal(nameof(Order.StatusChangedDate)))
                    ? null
                    : reader.GetDateTime(reader.GetOrdinal(nameof(Order.StatusChangedDate))),
                
            });
        }

        return orders;
    }

    public async Task AddAsync(Order order)
    {
        var sql =
            "INSERT INTO [Order] (AccountId, CarId, OverallPrice, Status) VALUES (@accountId, @carId, @overallPrice, @status)";

        await using var command = new SqlCommand(sql, Connection);
        command.Parameters.AddWithValue("@accountId", order.AccountId);
        command.Parameters.AddWithValue("@carId", order.CarId);
        command.Parameters.AddWithValue("@overallPrice", order.OverallPrice);
        command.Parameters.AddWithValue("@status", order.Status);

        await command.ExecuteNonQueryAsync();
    }

    public async Task<int> GetOrdersCountAsync(int accountId)
    {
        var sql = @"SELECT COUNT(*) FROM [Order] WHERE [AccountId] = @accountId";

        await using var command = new SqlCommand(sql, Connection);
        command.Parameters.AddWithValue("@accountId", accountId);

        var result = await command.ExecuteScalarAsync();

        return result != null ? Convert.ToInt32(result) : 0;
    }

    public async Task<decimal> GetOverrallSpentMoneyAsync(int accountId)
    {
        var sql = @"SELECT ISNULL(SUM([OverallPrice]), 0) FROM [Order] WHERE [AccountId] = @accountId AND Status = 1";

        await using var command = new SqlCommand(sql, Connection);
        command.Parameters.AddWithValue("@accountId", accountId);

        var result = await command.ExecuteScalarAsync();

        return Convert.ToDecimal(result);
    }

    public async Task<decimal> GetOverallProfitAsync()
    {
        var sql = @"SELECT ISNULL(SUM([OverallPrice]), 0) FROM [Order] WHERE Status = 1";
        
        await using var command = new SqlCommand(sql, Connection);
        var result = await command.ExecuteScalarAsync();

        return Convert.ToDecimal(result);
    }
}