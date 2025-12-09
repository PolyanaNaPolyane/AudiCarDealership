namespace CarDealership.Data.Entities;

public class Dealer : Entity
{
    public override int Id { get; set; }
    public string Name { get; set; }
    public string Schedule { get; set; }
    public bool LeasingCapability { get; set; }
    public bool TestDriveCapability { get; set; }
    
    public int ContactDetailsId { get; set; }
    public ContactDetails? ContactDetails { get; set; }
}