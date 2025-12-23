using System.ComponentModel.DataAnnotations;

namespace CarDealership.Enums;

public enum CarStatus
{
    [Display(Name = "Доступний")] Available = 0,
    [Display(Name = "Зарезервований")] Reserved = 1,
    [Display(Name = "Проданий")] Sold = 2
}