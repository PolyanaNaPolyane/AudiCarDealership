using CarDealership.Data.Entities;

namespace CarDealership.Data.Repositories.Interfaces;

public interface IDealerRepository
{
    Task<IEnumerable<Dealer>> GetAllAsync();
}