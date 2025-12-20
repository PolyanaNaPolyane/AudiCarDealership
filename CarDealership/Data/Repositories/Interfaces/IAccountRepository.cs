using CarDealership.Data.Entities;

namespace CarDealership.Data.Repositories.Interfaces;

public interface IAccountRepository
{
    Task<IEnumerable<Account>> GetAllAsync();
    Task DeleteAsync(Account account);
    Task<Account?> FindAsync(string email);
    Task<int> AddAsync(Account account);
    Task<bool> IsEmailExistAsync(string email);
}