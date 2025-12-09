using CarDealership.Enums;

namespace CarDealership.Data.Entities;

public class Order : Entity
{
    public override int Id { get; set; }
    
    public int AccountId { get; set; }
    public Account? Account { get; set; }
    
    public int CarId { get; set; }
    public Car? Car { get; set; }
    
    public DateTime CreatedDate { get; set; }
    public decimal OverallPrice { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime? StatusChangedDate { get; set; }
}