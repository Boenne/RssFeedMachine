using System;
using System.Threading.Tasks;
using CodeHollow.FeedReader;
using RssFeedMachine.Services.Exceptions;
using RssFeedMachine.Services.Interfaces;
using Feed = RssFeedMachine.Data.Models.Feed;

namespace RssFeedMachine.Services
{
    public class FeedReaderService : IFeedReaderService
    {
        public async Task<Feed> Read(string url)
        {
            try
            {
                var feed = await FeedReader.ReadAsync(url);
                return new Feed(url, feed.Title);
            }
            catch (Exception e)
            {
                //maybe log exception?
                throw new UnableToReadFeedException();
            }
        }
    }
}