using CarDealership.Enums;

namespace CarDealership.Data.Entities;

public class Account : Entity
{
    public override int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public AccountType Type { get; set; }
    
    public int ContactDetailsId { get; set; }
    public ContactDetails? ContactDetails { get; set; }
}