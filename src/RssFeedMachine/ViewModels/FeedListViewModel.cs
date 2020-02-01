using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using RssFeedMachine.ViewModels.Interfaces;
using RssFeedMachine.Windows;
using RssFeedMachine.Wrappers;

namespace RssFeedMachine.ViewModels
{
    public class FeedListViewModel : ViewModelBase, IFeedListViewModel
    {
        private readonly IMessageBoxWrapper _messageBoxWrapper;

        public FeedListViewModel(IMessageBoxWrapper messageBoxWrapper)
        {
            _messageBoxWrapper = messageBoxWrapper;
        }

        public ICommand AddFeedCommand => new RelayCommand(OpenAddFeedWindow);
        public ICommand RemoveFeedCommand => new RelayCommand(RemoveFeed);

        public void OpenAddFeedWindow()
        {
            new AddFeedWindow().ShowDialog();
        }

        public void RemoveFeed()
        {
            //TODO replace with actual name of selected feed
            if (_messageBoxWrapper.AreYouSure("Delete this feed?", "Delete feed"))
            {
                //Delete feed
            }
        }
    }
}