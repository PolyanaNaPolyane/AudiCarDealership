using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Services.Interfaces;

namespace CarDealership.Services;

public class TechnicalCharacteristicsService(ITechnicalCharacteristicsRepository technicalCharacteristicsRepository)
    : ITechnicalCharacteristicsService
{
    public Task<IEnumerable<TechnicalCharacteristics>> GetAllAsync()
    {
        return technicalCharacteristicsRepository.GetAllAsync();
    }
}