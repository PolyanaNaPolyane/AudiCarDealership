using System.ComponentModel.DataAnnotations;

namespace CarDealership.Enums;

public enum EngineType
{
    [Display(Name = "Дизельний")] Diesel = 0,
    [Display(Name = "Бензиновий")] Gasoline = 1,
    [Display(Name = "Електричний")] Electric = 3,
    [Display(Name = "Гібридний")] Hybrid = 4
}