using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models.Db;
using SocialNetwork.Models.Db;

namespace SocialNetwork.Models
{
    public sealed class SocNetContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<UserPost> UserPosts { get; set; }

        public DbSet<Request> Requests { get; set; }

        public SocNetContext(DbContextOptions<SocNetContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
