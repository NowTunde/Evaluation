using System;
using System.Threading.Tasks;

namespace TwitterStatisticsApi.Repository.Interfaces
{
    public interface IRepository
    {
        Task GetTweetAsync();
        Task GetTweetsAsync();
    }
}
