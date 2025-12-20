using CarDealership.Data.Entities;

namespace CarDealership.Services.Interfaces;

public interface IContactDetailsService
{
    Task<IEnumerable<ContactDetails>> GetAllAsync();
}