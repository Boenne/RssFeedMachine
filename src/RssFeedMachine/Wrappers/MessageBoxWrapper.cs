using System.Windows;

namespace RssFeedMachine.Wrappers
{
    public class MessageBoxWrapper : IMessageBoxWrapper
    {
        public bool AreYouSure(string message, string caption)
        {
            var messageBoxResult = MessageBox.Show("Delete this feed?", "Delete feed", MessageBoxButton.YesNo);
            return messageBoxResult == MessageBoxResult.Yes;
        }
    }
}