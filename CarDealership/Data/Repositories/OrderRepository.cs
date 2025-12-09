using Microsoft.Data.SqlClient;
using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Enums;

namespace CarDealership.Data.Repositories;

public class OrderRepository(string connectionString) : BaseAdoNetRepository(connectionString), IOrderRepository
{
    public async Task<IEnumerable<Order>> GetAllAsync()
    {
        var orders = new List<Order>();

        var sql = @"SELECT * FROM [Order]";

        await using var command = new SqlCommand(sql, Connection);
        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            orders.Add(new Order
            {
                Id = reader.GetInt32(reader.GetOrdinal(nameof(Order.Id))),
                AccountId = reader.GetInt32(reader.GetOrdinal(nameof(Order.AccountId))),
                CarId = reader.GetInt32(reader.GetOrdinal(nameof(Order.CarId))),
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
        var sql = @"SELECT ISNULL(SUM([OverallPrice]), 0) FROM [Order] WHERE [AccountId] = @accountId";

        await using var command = new SqlCommand(sql, Connection);
        command.Parameters.AddWithValue("@accountId", accountId);

        var result = await command.ExecuteScalarAsync();

        return result != null ? Convert.ToDecimal(result) : 0;
    }
}