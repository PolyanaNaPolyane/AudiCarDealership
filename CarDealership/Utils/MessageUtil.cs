namespace CarDealership.Utils;

public static class MessageUtil
{
    public static void ShowError(string message)
    {
        MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void ShowInformation(string message)
    {
        MessageBox.Show(message, "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}