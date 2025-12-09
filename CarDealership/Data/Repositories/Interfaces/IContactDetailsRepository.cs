using CarDealership.Data.Entities;

namespace CarDealership.Data.Repositories.Interfaces;

public interface IContactDetailsRepository
{
    Task<int> AddAsync(ContactDetails contactDetails);
}