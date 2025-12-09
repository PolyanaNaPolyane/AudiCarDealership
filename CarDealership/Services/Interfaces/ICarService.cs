using CarDealership.Data.Entities;

namespace CarDealership.Services.Interfaces;

public interface ICarService
{
    Task<IEnumerable<Car>> GetAllAvailableAsync();
    // Task AddAsync(Car car);
    // Task UpdateAsync(Car car);
    // Task RemoveAsync(int id);
}