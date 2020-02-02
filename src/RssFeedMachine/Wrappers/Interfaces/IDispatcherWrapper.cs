using System;
using System.Threading.Tasks;

namespace RssFeedMachine.Wrappers.Interfaces
{
    public interface IDispatcherWrapper
    {
        Task BeginInvoke(Action action);
    }
}