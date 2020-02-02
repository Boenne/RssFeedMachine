using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using RssFeedMachine.Data.Repositories.Interfaces;
using RssFeedMachine.Services.Exceptions;
using RssFeedMachine.Services.Interfaces;
using RssFeedMachine.ViewModels.Interfaces;
using RssFeedMachine.Wrappers.Interfaces;
using RssFeedMachine.Wrappers.Messenger.Messages;

namespace RssFeedMachine.ViewModels
{
    public class AddFeedViewModel : ViewModelBase, IAddFeedViewModel
    {
        private readonly IFeedReaderService _feedReaderService;
        private readonly IFeedRepository _feedRepository;
        private readonly IMessenger _messenger;
        private string _feedUrl;

        public AddFeedViewModel(IFeedReaderService feedReaderService, IFeedRepository feedRepository, IMessenger messenger)
        {
            _feedReaderService = feedReaderService;
            _feedRepository = feedRepository;
            _messenger = messenger;
        }

        public string FeedUrl
        {
            get => _feedUrl;
            set => Set(() => FeedUrl, ref _feedUrl, value);
        }

        public ICommand AddFeedCommand => new RelayCommand<IClosable>(async window => await AddFeed(window));

        public async Task AddFeed(IClosable window)
        {
            try
            {
                var feed = await _feedReaderService.Read(FeedUrl);
                await _feedRepository.Add(feed);
                _messenger.Send(new FeedAddedMessage());
            }
            catch (UnableToReadFeedException exception)
            {
                //Handle
            }
            
            window.Close();
        }
    }
}