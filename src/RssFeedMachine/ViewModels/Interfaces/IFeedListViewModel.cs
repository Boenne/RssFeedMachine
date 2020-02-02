using System.Collections.Generic;
using System.Windows.Input;

namespace RssFeedMachine.ViewModels.Interfaces
{
    public interface IFeedListViewModel
    {
        public ICommand LoadedCommand { get; }
        public ICommand AddFeedCommand { get; }
        public ICommand RemoveFeedCommand { get; }
        public List<FeedViewModel> Feeds { get; set; }
        public FeedViewModel SelectedFeedViewModel { get; set; }
    }
}