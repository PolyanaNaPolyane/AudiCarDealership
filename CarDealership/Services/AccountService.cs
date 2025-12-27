using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Services.Interfaces;

namespace CarDealership.Services;

public class AccountService(
    IAccountRepository accountRepository,
    IContactDetailsRepository contactDetailsRepository,
    IOrderRepository orderRepository,
    IPasswordHasher passwordHasher,
    AccountContext accountContext)
    : IAccountService
{
    public Task<IEnumerable<Account>> GetAllAsync()
    {
        return accountRepository.GetAllAsync();
    }
    
    public Task<int> GetOrdersCountAsync(int accountId)
    {
        return orderRepository.GetOrdersCountAsync(accountId);
    }

    public Task<decimal> GetOverrallSpentMoneyAsync(int accountId)
    {
        return orderRepository.GetOverrallSpentMoneyAsync(accountId);
    }

    public async Task<Account?> RegisterAsync(Account account)
    {
        var emailAlreadyExists = await accountRepository.IsEmailExistAsync(account.Email);

        if (emailAlreadyExists)
        {
            return null;
        }

        var contactDetailsId = await contactDetailsRepository.AddAsync(account.ContactDetails);
        account.ContactDetailsId = contactDetailsId;
        account.ContactDetails.Id = contactDetailsId;
        account.PasswordHash = passwordHasher.GetHash(account.PasswordHash);
        account.Id = await accountRepository.AddAsync(account);
        
        return account;
    }

    public async Task DeleteAsync()
    {
        await accountRepository.DeleteAsync(accountContext.CurrentAccount);
        await contactDetailsRepository.DeleteAsync(accountContext.CurrentAccount.ContactDetails.Id);
        await orderRepository.DeleteByAccountAsync(accountContext.CurrentAccount.Id);
    }

    public async Task<Account?> LoginAsync(string email, string password)
    {
        var account = await accountRepository.FindAsync(email);

        if (!passwordHasher.VerifyHash(password, account?.PasswordHash))
        {
            return null;
        }

        return account;
    }
}