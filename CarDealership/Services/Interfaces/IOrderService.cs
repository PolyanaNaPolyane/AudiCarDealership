using CarDealership.Data.Entities;

namespace CarDealership.Services.Interfaces;

public interface IOrderService
{
    Task<IEnumerable<Order>> GetAllAsync();
    Task<IEnumerable<Order>> GetAllByAccountAsync();
    Task<decimal> GetOverallProfitAsync();
    Task AddAsync(Car car);
    Task AddAsync(Order order);
    Task UpdateAsync(Order order);
    Task DeleteAsync(int id);
}