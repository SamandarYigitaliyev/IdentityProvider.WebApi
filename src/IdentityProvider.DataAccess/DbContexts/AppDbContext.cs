using IdentityProvider.Domain.Entities;
using IdentityProvider.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace IdentityProvider.DataAccess.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
        DbSet<User> Users { get; set; }
        DbSet<UserAccessToken> UserAccessToken { get; set; }
        DbSet<UserLoginDevice> UserLoginDevice { get; set; }
        DbSet<UserRefreshToken> UserRefreshToken { get; set; }
        DbSet<UserLogin> UserLogin { get; set; }

    }
}
