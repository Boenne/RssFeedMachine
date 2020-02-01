namespace RssFeedMachine.Wrappers
{
    public interface IMessageBoxWrapper
    {
        bool AreYouSure(string message, string caption);
    }
}