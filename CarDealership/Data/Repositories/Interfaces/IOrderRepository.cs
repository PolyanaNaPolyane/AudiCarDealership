using CarDealership.Data.Entities;

namespace CarDealership.Data.Repositories.Interfaces;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllAsync();
    Task AddAsync(Order order);
    Task<int> GetOrdersCountAsync(int accountId);
    Task<decimal> GetOverrallSpentMoneyAsync(int accountId);
}