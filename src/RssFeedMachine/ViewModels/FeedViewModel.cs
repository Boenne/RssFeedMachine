namespace RssFeedMachine.ViewModels
{
    public class FeedViewModel : ViewModelBase
    {
        private string _title;
        private string _url;

        public string Title
        {
            get => _title;
            set => Set(() => Title, ref _title, value);
        }

        public string Url
        {
            get => _url;
            set => Set(() => Url, ref _url, value);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}