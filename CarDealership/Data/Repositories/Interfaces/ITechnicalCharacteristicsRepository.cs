using CarDealership.Data.Entities;

namespace CarDealership.Data.Repositories.Interfaces;

public interface ITechnicalCharacteristicsRepository
{
    Task<IEnumerable<TechnicalCharacteristics>> GetAllAsync();
}