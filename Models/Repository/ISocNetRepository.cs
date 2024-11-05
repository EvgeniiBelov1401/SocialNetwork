using SocialNetwork.Models.Db;
using System.Threading.Tasks;

namespace SocialNetwork.Models.Repository
{
    public interface ISocNetRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }
}
