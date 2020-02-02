using System;
using RssFeedMachine.Wrappers.Interfaces;

namespace RssFeedMachine.Wrappers.Messenger
{
    public class Messenger : IMessenger
    {
        public void Register<T>(object recipient, Action<T> action)
        {
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Register(recipient, action);
        }

        public void Send<T>(T message)
        {
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Send(message);
        }
    }
}