using CarDealership.Data.Entities;

namespace CarDealership.Data.Repositories.Interfaces;

public interface IContactDetailsRepository
{
    Task<IEnumerable<ContactDetails>> GetAllAsync();
    Task<int> AddAsync(ContactDetails contactDetails);
}