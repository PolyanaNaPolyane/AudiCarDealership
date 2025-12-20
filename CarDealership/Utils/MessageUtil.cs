namespace CarDealership.Utils;

public static class MessageUtil
{
    public static void ShowError(string message)
    {
        MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static DialogResult ShowInformation(string message)
    {
        return MessageBox.Show(message, "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}