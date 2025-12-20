using CarDealership.Data.Entities;

namespace CarDealership.Data.Repositories.Interfaces;

public interface IModelRepository
{
    Task<IEnumerable<Model>> GetAllAsync();
}