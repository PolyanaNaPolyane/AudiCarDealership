using CarDealership.Data.Entities;
using CarDealership.Enums;

namespace CarDealership.Data.Repositories.Interfaces;

public interface ICarRepository
{
    Task<IEnumerable<Car>> GetAvaliableAllAsync();

    Task ChangeStatus(int id, CarStatus status);

    Task<int> GetAvailableCountAsync();
    // Task AddAsync(Car car);
    // Task UpdateAsync(Car car);
    // Task RemoveAsync(int id);
}