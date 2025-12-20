using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Services.Interfaces;

namespace CarDealership.Services;

public class ContactDetailsService(IContactDetailsRepository contactDetailsRepository) : IContactDetailsService
{
    public Task<IEnumerable<ContactDetails>> GetAllAsync()
    {
        return contactDetailsRepository.GetAllAsync();
    }
}