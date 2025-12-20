using CarDealership.Data.Entities;
using CarDealership.Data.Repositories.Interfaces;
using CarDealership.Services.Interfaces;

namespace CarDealership.Services;

public class ModelService(IModelRepository modelRepository) : IModelService
{
    public Task<IEnumerable<Model>> GetAllAsync()
    {
        return modelRepository.GetAllAsync();
    }
}