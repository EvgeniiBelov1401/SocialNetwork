using MvcStartApp.Models.Db;
using System.Threading.Tasks;

namespace SocialNetwork.Models.Repository
{
    public interface IRequestRepository
    {
        Task AddLog(Request request);
        Task<Request[]> GetLog();
    }
}
