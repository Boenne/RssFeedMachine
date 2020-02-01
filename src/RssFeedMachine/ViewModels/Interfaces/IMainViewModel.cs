using System.Windows.Input;

namespace RssFeedMachine.ViewModels.Interfaces
{
    public interface IMainViewModel
    {
        public ICommand LoadedCommand { get; }
    }
}