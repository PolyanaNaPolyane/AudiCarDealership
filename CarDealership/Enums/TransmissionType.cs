using System.ComponentModel.DataAnnotations;

namespace CarDealership.Enums;

public enum TransmissionType
{
    [Display(Name = "Ручна")]Manual = 0,
    [Display(Name = "Автоматична")]Automatic = 1
}