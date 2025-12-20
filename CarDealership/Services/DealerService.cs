using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Services.Interfaces;

namespace CarDealership.Services;

public class DealerService(IDealerRepository dealerRepository) : IDealerService
{
    public Task<IEnumerable<Dealer>> GetAllAsync()
    {
        return dealerRepository.GetAllAsync();
    }
}