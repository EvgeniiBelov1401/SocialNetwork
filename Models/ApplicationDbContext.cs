using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models.Db;
using SocialNetwork.Models.Db;

namespace SocialNetwork.Models
{
    public sealed class ApplicationDbContext : IdentityDbContext<User>
    {
        //public DbSet<User> Users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
