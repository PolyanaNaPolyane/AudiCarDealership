using CarDealership.Data.Entities;

namespace CarDealership.Services.Interfaces;

public interface IOrderService
{
    Task<IEnumerable<Order>> GetAllByAccountAsync();
    Task AddAsync(Car car);
}