using CarDealership.Data.Entities;

namespace CarDealership.Services.Interfaces;

public interface ITechnicalCharacteristicsService
{
    Task<IEnumerable<TechnicalCharacteristics>> GetAllAsync();
}