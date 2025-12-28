using System.ComponentModel.DataAnnotations;

namespace CarDealership.Enums;

public enum EngineType
{
    [Display(Name = "Дизельний")] Diesel = 0,
    [Display(Name = "Бензиновий")] Gasoline = 1,
    [Display(Name = "Електричний")] Electric = 2,
    [Display(Name = "Гібридний")] Hybrid = 3
}