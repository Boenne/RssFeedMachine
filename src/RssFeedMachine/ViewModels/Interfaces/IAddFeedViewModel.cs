using System.Windows.Input;

namespace RssFeedMachine.ViewModels.Interfaces
{
    public interface IAddFeedViewModel
    {
        public ICommand AddFeedCommand { get; }
        public string FeedUrl { get; set; }
    }
}