using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RssFeedMachine.Data.Models;
using RssFeedMachine.Data.Repositories.Interfaces;

namespace RssFeedMachine.Data.Repositories
{
    public class FeedRepository : IFeedRepository
    {
        private static List<Feed> _feeds;

        public async Task<bool> Add(Feed feed)
        {
            if (_feeds.Any(x => x.Url == feed.Url)) return false;

            _feeds.Add(feed);
            await Save();

            return true;
        }

        public async Task<bool> Remove(string url)
        {
            if (_feeds.Any(x => x.Url == url)) return false;

            _feeds.RemoveAll(x => x.Url == url);
            await Save();

            return true;
        }

        public async Task<List<Feed>> Get()
        {
            if (_feeds != null) return _feeds;
            using (var sr = new StreamReader(Settings.DataFilePath))
            {
                var data = await sr.ReadToEndAsync();
                _feeds = JsonConvert.DeserializeObject<List<Feed>>(data);
            }

            return _feeds;
        }

        private async Task Save()
        {
            await using (var sw = new StreamWriter(Settings.DataFilePath))
            {
                var json = JsonConvert.SerializeObject(_feeds, Formatting.None);
                await sw.WriteLineAsync(json);
            }
        }
    }
}