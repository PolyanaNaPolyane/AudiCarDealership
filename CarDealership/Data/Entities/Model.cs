namespace CarDealership.Data.Entities;

public class Model : Entity
{
    public override int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Class { get; set; }
}