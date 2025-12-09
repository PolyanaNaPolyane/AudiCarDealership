using CarDealership.Enums;

namespace CarDealership.Data.Entities;

public class TechnicalCharacteristics : Entity
{
    public override int Id { get; set; }
    public BodyType BodyType { get; set; }
    public int MaxSpeed { get; set; }
    public TransmissionType TransmissionType { get; set; }
    public decimal FuelConsumption { get; set; }
    public int Power { get; set; }
    public DrivetrainType DrivetrainType { get; set; }
    public EngineType EngineType { get; set; }
    
    public int ModelId { get; set; }
    public Model? Model { get; set; }
}