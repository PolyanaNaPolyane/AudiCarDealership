using CarDealership.Data.Entities;

namespace CarDealership.Services.Interfaces;

public interface IDealerService
{
    Task<IEnumerable<Dealer>> GetAllAsync();
}