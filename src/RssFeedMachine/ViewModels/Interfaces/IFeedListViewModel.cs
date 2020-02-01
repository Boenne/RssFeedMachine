using System.Windows.Input;

namespace RssFeedMachine.ViewModels.Interfaces
{
    public interface IFeedListViewModel
    {
        public ICommand AddFeedCommand { get; }
        public ICommand RemoveFeedCommand { get; }
    }
}