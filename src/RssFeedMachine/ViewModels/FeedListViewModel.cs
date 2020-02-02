using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using RssFeedMachine.Data.Repositories.Interfaces;
using RssFeedMachine.ViewModels.Interfaces;
using RssFeedMachine.Windows;
using RssFeedMachine.Wrappers;
using RssFeedMachine.Wrappers.Interfaces;
using RssFeedMachine.Wrappers.Messenger.Messages;

namespace RssFeedMachine.ViewModels
{
    public class FeedListViewModel : ViewModelBase, IFeedListViewModel
    {
        private readonly IDispatcherWrapper _dispatcherWrapper;
        private readonly IFeedRepository _feedRepository;
        private readonly IMessageBoxWrapper _messageBoxWrapper;
        private readonly IMessenger _messenger;
        private List<FeedViewModel> _feeds;
        private FeedViewModel _selectedFeedViewModel;

        public FeedListViewModel(IMessageBoxWrapper messageBoxWrapper, IFeedRepository feedRepository,
            IMessenger messenger, IDispatcherWrapper dispatcherWrapper)
        {
            _messageBoxWrapper = messageBoxWrapper;
            _feedRepository = feedRepository;
            _messenger = messenger;
            _dispatcherWrapper = dispatcherWrapper;
            _messenger.Register<FeedAddedMessage>(this, message => UpdateFeeds());
        }

        public ICommand LoadedCommand => new RelayCommand(async () => await Loaded());
        public ICommand AddFeedCommand => new RelayCommand(OpenAddFeedWindow);
        public ICommand RemoveFeedCommand => new RelayCommand(RemoveFeed);

        public List<FeedViewModel> Feeds
        {
            get => _feeds;
            set => Set(() => Feeds, ref _feeds, value);
        }

        public FeedViewModel SelectedFeedViewModel
        {
            get => _selectedFeedViewModel;
            set => Set(() => SelectedFeedViewModel, ref _selectedFeedViewModel, value);
        }

        public async Task Loaded()
        {
            await UpdateFeeds();
        }

        public void OpenAddFeedWindow()
        {
            new AddFeedWindow().ShowDialog();
        }

        public void RemoveFeed()
        {
            //TODO replace with actual name of selected feed
            if (_messageBoxWrapper.AreYouSure("Delete this feed?", "Delete feed"))
            {
            }
        }

        public async Task UpdateFeeds()
        {
            var feeds = await _feedRepository.Get();
            await _dispatcherWrapper.BeginInvoke(() =>
                Feeds = feeds.Select(x => new FeedViewModel {Title = x.Title, Url = x.Url}).ToList());
        }
    }
}