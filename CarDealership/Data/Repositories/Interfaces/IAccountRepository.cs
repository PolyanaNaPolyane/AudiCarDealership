using CarDealership.Data.Entities;

namespace CarDealership.Data.Repositories.Interfaces;

public interface IAccountRepository
{
    Task<IEnumerable<Account>> GetAllAsync();
    Task<Account?> FindAsync(string email);
    Task<int> AddAsync(Account account);
    Task<bool> IsEmailExistAsync(string email);
}