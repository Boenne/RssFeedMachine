namespace RssFeedMachine.Data.Models
{
    public class Feed
    {
        public Feed(string url, string title)
        {
            Url = url;
            Title = title;
        }

        public string Url { get; set; }
        public string Title { get; set; }
    }
}