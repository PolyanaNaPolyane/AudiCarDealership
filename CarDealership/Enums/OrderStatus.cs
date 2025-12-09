using System.ComponentModel.DataAnnotations;

namespace CarDealership.Enums;

public enum OrderStatus
{
    [Display(Name = "Очікує підтвердження")]
    Pending = 0,
    [Display(Name = "Підтверджений")] Approved = 1,
    [Display(Name = "Відхилений")] Rejected = 2
}