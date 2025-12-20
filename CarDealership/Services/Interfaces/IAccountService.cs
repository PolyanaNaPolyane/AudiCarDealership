using CarDealership.Data.Entities;

namespace CarDealership.Services.Interfaces;

public interface IAccountService
{
    Task<IEnumerable<Account>> GetAllAsync();
    Task<int> GetOrdersCountAsync(int accountId);
    Task<decimal> GetOverrallSpentMoneyAsync(int accountId);
    Task<Account?> LoginAsync(string email, string password);
    Task<Account?> RegisterAsync(Account account);
    Task DeleteAsync();
}