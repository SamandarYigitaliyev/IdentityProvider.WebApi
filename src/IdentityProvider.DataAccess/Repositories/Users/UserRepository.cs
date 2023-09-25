using IdentityProvider.DataAccess.DbContexts;
using IdentityProvider.DataAccess.Interfaces.Users;
using IdentityProvider.Domain.Entities;

namespace IdentityProvider.DataAccess.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext appDb) : base(appDb)
        {
        }
    }
}
