using System.Net.Mail;
using System.Text;

namespace CarDealership.Utils;

public static class ValidationUtil
{
    public static void AppendValidationErrorIfInvalid(
        this StringBuilder errors,
        ref int index,
        bool isValid,
        string message)
    {
        if (isValid)
        {
            return;
        }

        errors.AppendLine($"{++index}) {message}");
    }
    
    public static bool IsFirstNameValid(this TextBox textBox, out string? message)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            message = "Ім'я повинне бути заповнине";
            return false;
        }

        message = null;
        return true;
    }
    
    public static bool IsLastNameValid(this TextBox textBox, out string? message)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            message = "Прізвище повинне бути заповнине";
            return false;
        }

        message = null;
        return true;
    }

    public static bool IsEmailValid(this TextBox textBox, out string? message)
    {
        try
        {
            _ = new MailAddress(textBox.Text);
            message = null;
            return true;
        }
        catch (ArgumentException)
        {
            message = "Пошта повинна бути заповнена";
            return false;
        }
        catch (FormatException)
        {
            message = "Пошта має неправильний формат";
            return false;
        }
    }

    public static bool IsPasswordValid(this TextBox textBox, out string? message)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            message = "Пароль повинен бути заповнений";
            return false;
        }

        message = null;
        return true;
    }
    
    public static bool IsCountryValid(this TextBox textBox, out string? message)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            message = "Країна повинна бути заповнена";
            return false;
        }

        message = null;
        return true;
    }
    
    public static bool IsCityValid(this TextBox textBox, out string? message)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            message = "Місто повинно бути заповнине";
            return false;
        }

        message = null;
        return true;
    }
    
    public static bool IsAddressValid(this TextBox textBox, out string? message)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            message = "Адреса повинна бути заповнена";
            return false;
        }

        message = null;
        return true;
    }
    
    public static bool IsPhoneNumberValid(this TextBox textBox, out string? message)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            message = "Телефон повинен бути заповнений";
            return false;
        }

        message = null;
        return true;
    }
    
    public static bool IsValidPriceFrom(this TextBox textBox, out string message)
    {
        if (string.IsNullOrEmpty(textBox.Text))
        {
            message = null;
            return true;
        }
    
        if (!decimal.TryParse(textBox.Text, out var priceFrom) || priceFrom <= 0)
        {
            message = "Ціна від повинна бути більшою 0";
            return false;
        }

        message = null;
        return true;
    }

    public static bool IsValidPriceTo(this TextBox textBox, decimal priceFrom, out string message)
    {
        if (string.IsNullOrEmpty(textBox.Text))
        {
            message = null;
            return true;
        }
    
        if (!decimal.TryParse(textBox.Text, out var priceTo) || priceTo <= 0)
        {
            message = "Ціна до повинна бути більшою 0";
            return false;
        }

        if (priceTo <= priceFrom)
        {
            message = "Ціна до повинна бути більшою ціни від";
            return false;
        }

        message = null;
        return true;
    }
    
    public static bool IsValidAccount(this ComboBox comboBox, out string message)
    {
        if (comboBox.SelectedIndex < 0)
        {
            message = "Оберіть акаунт з випадаючого списка";
            return false;
        }

        message = null;
        return true;
    }
    
    public static bool IsValidCar(this ComboBox comboBox, out string message)
    {
        if (comboBox.SelectedIndex < 0)
        {
            message = "Оберіть машину з випадаючого списка";
            return false;
        }

        message = null;
        return true;
    }
    
    public static bool IsValidOverallPrice(this TextBox textBox, out string message)
    {
        if (!decimal.TryParse(textBox.Text, out var overallPrice) || overallPrice <= 0)
        {
            message = "Загальна ціна повинна бути більшою 0";
            return false;
        }

        message = null;
        return true;
    }
}