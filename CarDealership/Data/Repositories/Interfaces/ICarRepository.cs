using CarDealership.Data.Entities;
using CarDealership.Enums;

namespace CarDealership.Data.Repositories.Interfaces;

public interface ICarRepository
{
    Task<IEnumerable<Car>> GetAllAsync();
    Task<IEnumerable<Car>> GetAvaliableAllAsync();
    Task ChangeStatusAsync(int id, CarStatus status);
    Task<int> GetAvailableCountAsync();
    Task<IEnumerable<string>> GetMostPopularModelsAsync();
    Task AddAsync(Car car);
    Task UpdateAsync(Car car);
    Task RemoveAsync(int id);
}