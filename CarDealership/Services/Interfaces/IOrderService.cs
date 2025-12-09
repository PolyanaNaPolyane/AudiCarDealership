using CarDealership.Data.Entities;

namespace CarDealership.Services.Interfaces;

public interface IOrderService
{
    Task<IEnumerable<Order>> GetAllAsync();
    Task AddAsync(Car car);
}