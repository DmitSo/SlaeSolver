using System;
using System.Windows.Forms;

namespace SlaeSolver
{
    public static class NotificationManager
    {
        public static DialogResult ShowError(string message)
        {
            return MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowExclamation(string message, MessageBoxButtons btns = MessageBoxButtons.OK)
        {
            return MessageBox.Show(message, "Exclamation", btns, MessageBoxIcon.Exclamation);
        }

        public static DialogResult ShowInfo(string message)
        {
            return MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowError(Exception exception)
        {
            return ShowError($"Exception: {exception.Message}" +
                $"{Environment.NewLine}Stack trace: {exception.StackTrace}");
        }
    }
}
