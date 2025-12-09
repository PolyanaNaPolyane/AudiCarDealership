using System.ComponentModel.DataAnnotations;

namespace CarDealership.Enums;

public enum AccountType
{
    [Display(Name = "Користувач")] Customer = 0,
    [Display(Name = "Менеджер")] Manager = 1
}