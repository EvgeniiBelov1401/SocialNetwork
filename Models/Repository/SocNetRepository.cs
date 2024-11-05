using Microsoft.EntityFrameworkCore;
using SocialNetwork.Models.Db;
using System;
using System.Threading.Tasks;

namespace SocialNetwork.Models.Repository
{
    public class SocNetRepository : ISocNetRepository
    {
        private readonly SocNetContext _context;

        public SocNetRepository(SocNetContext context)
        {
            _context = context;
        }
        public async Task AddUser(User user)
        {
            user.JoinDate = DateTime.Now;
            user.Id = Guid.NewGuid();

            var entry = _context.Entry(user);
            if (entry.State == EntityState.Detached)
                await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();
        }

        public async Task<User[]> GetUsers()
        {
            return await _context.Users.ToArrayAsync();
        }
    }
}
