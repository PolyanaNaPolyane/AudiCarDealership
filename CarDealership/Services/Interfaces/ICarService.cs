using CarDealership.Data.Entities;
using CarDealership.Enums;

namespace CarDealership.Services.Interfaces;

public interface ICarService
{
    Task<IEnumerable<Car>> GetAllAsync();
    Task<IEnumerable<Car>> GetAllAvailableAsync();

    Task<int> GetAvailableByAllDealersAsync();
    Task<IEnumerable<string>> GetMostPopularModelsAsync();
    Task ChangeStatusAsync(int id, CarStatus status);
    // Task AddAsync(Car car);
    // Task UpdateAsync(Car car);
    // Task RemoveAsync(int id);
}