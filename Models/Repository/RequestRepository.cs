using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models.Db;
using System.Threading.Tasks;

namespace SocialNetwork.Models.Repository
{
    public class RequestRepository : IRequestRepository
    {
        private readonly ApplicationDbContext _context;


        public RequestRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddLog(Request request)
        {
            //await _context.Requests.AddAsync(request);
            await _context.SaveChangesAsync();
        }

        public async Task<Request[]> GetLog()
        {
            //return await _context.Requests.ToArrayAsync();
            throw new System.Exception();
        }
    }
}
