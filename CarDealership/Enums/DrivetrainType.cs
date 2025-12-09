using System.ComponentModel.DataAnnotations;

namespace CarDealership.Enums;

public enum DrivetrainType
{
    [Display(Name = "Передньопривідний")] FWD = 0,
    [Display(Name = "Задньопривідний")] RWD = 1,
    [Display(Name = "Повнопривідний")] AWD = 2
}