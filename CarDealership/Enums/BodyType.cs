using System.ComponentModel.DataAnnotations;

namespace CarDealership.Enums;

public enum BodyType
{
    [Display(Name = "Седан")] Sedan = 0,
    [Display(Name = "Хетчбек")] Hatchback = 1,
    [Display(Name = "Купе")] Coupe = 2
}