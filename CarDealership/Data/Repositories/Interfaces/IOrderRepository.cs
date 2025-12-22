using CarDealership.Data.Entities;

namespace CarDealership.Data.Repositories.Interfaces;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllAsync();
    Task<IEnumerable<Order>> GetAllAsync(int accountId);
    Task AddAsync(Order order);
    Task<int> GetOrdersCountAsync(int accountId);
    Task<decimal> GetOverrallSpentMoneyAsync(int accountId);
    Task<decimal> GetOverallProfitAsync();
    Task DeleteByAccountAsync(int accountId);
    Task DeleteAsync(int id);
    Task UpdateAsync(Order order);
}