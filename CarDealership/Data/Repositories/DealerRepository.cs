using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace CarDealership.Data.Repositories;

public class DealerRepository(string connectionString) : BaseAdoNetRepository(connectionString), IDealerRepository
{
    public async Task<IEnumerable<Dealer>> GetAllAsync()
    {
        var dealers = new List<Dealer>();
        
        var sql = "SELECT * FROM [Dealer]";

        await using var command = new SqlCommand(sql, Connection);
        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            dealers.Add(new Dealer
            {
                Id = reader.GetInt32(reader.GetOrdinal(nameof(Dealer.Id))),
                Name = reader.GetString(reader.GetOrdinal(nameof(Model.Name))),
                Schedule = reader.GetString(reader.GetOrdinal(nameof(Dealer.Schedule))),
                LeasingCapability = reader.GetBoolean(reader.GetOrdinal(nameof(Dealer.LeasingCapability))),
                TestDriveCapability = reader.GetBoolean(reader.GetOrdinal(nameof(Dealer.TestDriveCapability))),
                ContactDetailsId = reader.GetInt32(reader.GetOrdinal(nameof(Dealer.ContactDetailsId)))
            });
        }

        return dealers;
    }
}