using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Enums;
using Microsoft.Data.SqlClient;

namespace CarDealership.Data.Repositories;

public class TechnicalCharacteristicsRepository(string connectionString)
    : BaseAdoNetRepository(connectionString), ITechnicalCharacteristicsRepository
{
    public async Task<IEnumerable<TechnicalCharacteristics>> GetAllAsync()
    {
        var technicalCharacteristics = new List<TechnicalCharacteristics>();

        var sql = "SELECT * FROM [TechnicalCharacteristics]";

        await using var command = new SqlCommand(sql, Connection);
        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            technicalCharacteristics.Add(new TechnicalCharacteristics
            {
                Id = reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.Id))),
                BodyType = (BodyType)reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.BodyType))),
                MaxSpeed = reader.GetInt32(reader.GetOrdinal(nameof(Car.TechnicalCharacteristics.MaxSpeed))),
                TransmissionType =
                    (TransmissionType)reader.GetInt32(
                        reader.GetOrdinal(nameof(TechnicalCharacteristics.TransmissionType))),
                FuelConsumption =
                    reader.GetDecimal(reader.GetOrdinal(nameof(TechnicalCharacteristics.FuelConsumption))),
                Power = reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.Power))),
                DrivetrainType =
                    (DrivetrainType)reader.GetInt32(
                        reader.GetOrdinal(nameof(TechnicalCharacteristics.DrivetrainType))),
                EngineType =
                    (EngineType)reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.EngineType))),
                ModelId = reader.GetInt32(reader.GetOrdinal(nameof(TechnicalCharacteristics.ModelId))),
            });
        }

        return technicalCharacteristics;
    }
}