using IdentityProvider.DataAccess.DbContexts;
using IdentityProvider.DataAccess.Interfaces.Users;
using IdentityProvider.Domain.Entities.Users;

namespace IdentityProvider.DataAccess.Repositories.Users
{
    public class UserLoginRepository : GenericRepository<UserLogin>, IUserLoginRepository
    {
        public UserLoginRepository(AppDbContext appDb) : base(appDb)
        {
        }
    }
}
