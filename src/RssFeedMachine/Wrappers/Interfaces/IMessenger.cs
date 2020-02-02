using System;

namespace RssFeedMachine.Wrappers.Interfaces
{
    public interface IMessenger
    {
        void Register<T>(object recipient, Action<T> action);
        void Send<T>(T message);
    }
}