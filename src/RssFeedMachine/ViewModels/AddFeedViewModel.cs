using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using RssFeedMachine.ViewModels.Interfaces;
using RssFeedMachine.Wrappers.Interfaces;

namespace RssFeedMachine.ViewModels
{
    public class AddFeedViewModel : ViewModelBase, IAddFeedViewModel
    {
        private string _feedUrl;

        public string FeedUrl
        {
            get => _feedUrl;
            set => Set(() => FeedUrl, ref _feedUrl, value);
        }

        public ICommand AddFeedCommand => new RelayCommand<IClosable>(async window => await AddFeed(window));

        public async Task AddFeed(IClosable window)
        {
            window.Close();
            //TODO add feed to repo
        }
    }
}