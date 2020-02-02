using System.Collections.Generic;
using System.Threading.Tasks;
using RssFeedMachine.Data.Models;

namespace RssFeedMachine.Data.Repositories.Interfaces
{
    public interface IFeedRepository
    {
        Task<bool> Add(Feed feed);
        Task<bool> Remove(string url);
        Task<List<Feed>> Get();
    }
}