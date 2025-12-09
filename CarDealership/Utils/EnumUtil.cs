using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CarDealership.Utils;

public static class EnumUtil
{
    public static string GetDisplayName(this Enum enumValue)
    {
        var memberInfo = enumValue.GetType().GetMember(enumValue.ToString());
        var displayAttr = memberInfo[0].GetCustomAttribute<DisplayAttribute>();
        return displayAttr?.Name ?? enumValue.ToString();
    }
}