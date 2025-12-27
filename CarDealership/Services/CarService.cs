using System.Data;
using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Enums;
using CarDealership.Services.Interfaces;

namespace CarDealership.Services;

public class CarService(ICarRepository carRepository) : ICarService
{
    public Task<IEnumerable<Car>> GetAllAsync()
    {
        return carRepository.GetAllAsync();
    }
    
    public Task<IEnumerable<Car>> GetAllAvailableAsync()
    {
        return carRepository.GetAvaliableAllAsync();
    }

    public Task<int> GetAvailableByAllDealersAsync()
    {
        return carRepository.GetAvailableCountAsync();
    }

    public Task<IEnumerable<string>> GetMostPopularModelsAsync()
    {
        return carRepository.GetMostPopularModelsAsync();
    }

    public Task ChangeStatusAsync(int id, CarStatus status)
    {
        return carRepository.ChangeStatusAsync(id, status);
    }

    public Task AddAsync(Car car)
    {
        return carRepository.AddAsync(car);
    }
    
    public Task UpdateAsync(Car car)
    {
        return carRepository.UpdateAsync(car);
    }
    
    public Task RemoveAsync(int id)
    {
        return carRepository.RemoveAsync(id);
    }
}