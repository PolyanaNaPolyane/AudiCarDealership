using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace CarDealership.Data.Repositories;

public class ContactDetailsRepository(string connectionString)
    : BaseAdoNetRepository(connectionString), IContactDetailsRepository
{
    public async Task<int> AddAsync(ContactDetails contactDetails)
    {
        var sql =
            "INSERT INTO [ContactDetails] (Country, City, Address, PhoneNumber) VALUES (@country, @city, @address, @phoneNumber); SELECT CAST(SCOPE_IDENTITY() AS int);";

        await using var command = new SqlCommand(sql, Connection);
        command.Parameters.AddWithValue("@country", contactDetails.Country);
        command.Parameters.AddWithValue("@city", contactDetails.City);
        command.Parameters.AddWithValue("@address", contactDetails.Address);
        command.Parameters.AddWithValue("@phoneNumber", contactDetails.PhoneNumber);

        return (int)(await command.ExecuteScalarAsync())!;
    }
}