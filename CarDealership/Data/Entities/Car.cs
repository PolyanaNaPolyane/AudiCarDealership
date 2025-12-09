using CarDealership.Enums;

namespace CarDealership.Data.Entities;

public class Car : Entity
{
    public override int Id { get; set; }
    public Guid VIN { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }
    public CarStatus Status { get; set; }
    
    public int TechnicalCharacteristicsId { get; set; }
    public TechnicalCharacteristics? TechnicalCharacteristics { get; set; }
    
    public int DealerId { get; set; }
    public Dealer? Dealer { get; set; }
}