using Microsoft.Data.SqlClient;
using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Enums;

namespace CarDealership.Data.Repositories;

public class AccountRepository(string connectionString) : BaseAdoNetRepository(connectionString), IAccountRepository
{
    public async Task<bool> IsEmailExistAsync(string email)
    {
        var sql = "SELECT Id FROM [Account] WHERE Email = @email";
        await using var command = new SqlCommand(sql, Connection);
        command.Parameters.AddWithValue("@email", email);

        var result = (int?)await command.ExecuteScalarAsync();

        return result > 0;
    }

    public async Task<int> AddAsync(Account account)
    {
        var sql =
            @"INSERT INTO [Account] (FirstName, LastName, Email, PasswordHash, Type, ContactDetailsId) VALUES(@firstName, @lastName, @email, @passwordHash, @type, @contactDetailsId); SELECT CAST(SCOPE_IDENTITY() AS int);";

        await using var command = new SqlCommand(sql, Connection);
        command.Parameters.AddWithValue("@firstName", account.FirstName);
        command.Parameters.AddWithValue("@lastName", account.LastName);
        command.Parameters.AddWithValue("@email", account.Email);
        command.Parameters.AddWithValue("@passwordHash", account.PasswordHash);
        command.Parameters.AddWithValue("@type", account.Type);
        command.Parameters.AddWithValue("@contactDetailsId", account.ContactDetailsId);

        return (int)(await command.ExecuteScalarAsync())!;
    }

    public async Task<IEnumerable<Account>> GetAllAsync()
    {
        var accounts = new List<Account>();

        var sql = "SELECT * FROM [Account]";

        await using var command = new SqlCommand(sql, Connection);
        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            accounts.Add(new Account
            {
                Id = reader.GetInt32(reader.GetOrdinal(nameof(Account.Id))),
                FirstName = reader.GetString(reader.GetOrdinal(nameof(Account.FirstName))),
                LastName = reader.GetString(reader.GetOrdinal(nameof(Account.LastName))),
                Email = reader.GetString(reader.GetOrdinal(nameof(Account.Email))),
                PasswordHash = reader.GetString(reader.GetOrdinal(nameof(Account.PasswordHash))),
                Type = (AccountType)reader.GetInt32(reader.GetOrdinal(nameof(Account.Type))),
                ContactDetailsId = reader.IsDBNull(reader.GetOrdinal(nameof(Account.ContactDetailsId)))
                    ? null
                    : reader.GetInt32(reader.GetOrdinal(nameof(Account.ContactDetailsId))),
            });
        }

        return accounts;
    }

    public async Task DeleteAsync(Account account)
    {
        var sql = "DELETE FROM [Account] WHERE Id = @id";

        await using var command = new SqlCommand(sql, Connection);
        command.Parameters.AddWithValue("@id", account.Id);

        await command.ExecuteNonQueryAsync();
    }

    public async Task<Account?> FindAsync(string email)
    {
        var sql = @"SELECT * FROM [Account] WHERE [Email] = @email";

        await using var command = new SqlCommand(sql, Connection);
        command.Parameters.AddWithValue("@email", email);

        await using var reader = await command.ExecuteReaderAsync();

        if (!await reader.ReadAsync())
        {
            return null;
        }

        return new Account
        {
            Id = reader.GetInt32(reader.GetOrdinal(nameof(Account.Id))),
            FirstName = reader.GetString(reader.GetOrdinal(nameof(Account.FirstName))),
            LastName = reader.GetString(reader.GetOrdinal(nameof(Account.LastName))),
            Email = reader.GetString(reader.GetOrdinal(nameof(Account.Email))),
            PasswordHash = reader.GetString(reader.GetOrdinal(nameof(Account.PasswordHash))),
            Type = (AccountType)reader.GetInt32(reader.GetOrdinal(nameof(Account.Type))),
            ContactDetailsId = reader.GetInt32(reader.GetOrdinal(nameof(Account.ContactDetailsId)))
        };
    }
}