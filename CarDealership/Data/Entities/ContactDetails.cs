namespace CarDealership.Data.Entities;

public class ContactDetails : Entity
{
    public override int Id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}