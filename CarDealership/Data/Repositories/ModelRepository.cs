using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace CarDealership.Data.Repositories;

public class ModelRepository(string connectionString) : BaseAdoNetRepository(connectionString), IModelRepository
{
    public async Task<IEnumerable<Model>> GetAllAsync()
    {
        var models = new List<Model>();

        var sql = "SELECT * FROM [Model]";

        await using var command = new SqlCommand(sql, Connection);
        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            models.Add(new Model
            {
                Id = reader.GetInt32(reader.GetOrdinal(nameof(Model.Id))),
                Name = reader.GetString(reader.GetOrdinal(nameof(Model.Name))),
                Brand = reader.GetString(reader.GetOrdinal(nameof(Model.Brand))),
                Class = reader.GetString(reader.GetOrdinal(nameof(Model.Class)))
            });
        }

        return models;
    }
}