using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using RssFeedMachine.Wrappers.Interfaces;

namespace RssFeedMachine.Wrappers
{
    public class DispatcherWrapper : IDispatcherWrapper
    {
        public async Task BeginInvoke(Action action)
        {
            await Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, action);
        }
    }
}