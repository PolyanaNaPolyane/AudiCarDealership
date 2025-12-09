using System.Data;
using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Services.Interfaces;

namespace CarDealership.Services;

public class CarService(ICarRepository carRepository) : ICarService
{
    public Task<IEnumerable<Car>> GetAllAvailableAsync()
    {
        return carRepository.GetAvaliableAllAsync();
    }

    // public Task AddAsync(Car car)
    // {
    //     return carRepository.AddAsync(car);
    // }
    //
    // public Task UpdateAsync(Car car)
    // {
    //     return carRepository.UpdateAsync(car);
    // }
    //
    // public Task RemoveAsync(int id)
    // {
    //     return carRepository.RemoveAsync(id);
    // }
}