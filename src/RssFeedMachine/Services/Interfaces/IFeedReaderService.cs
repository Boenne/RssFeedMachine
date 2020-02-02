using System.Threading.Tasks;
using RssFeedMachine.Data.Models;

namespace RssFeedMachine.Services.Interfaces
{
    public interface IFeedReaderService
    {
        Task<Feed> Read(string url);
    }
}