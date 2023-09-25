using IdentityProvider.DataAccess.DbContexts;
using IdentityProvider.DataAccess.Interfaces.Users;
using IdentityProvider.Domain.Entities;

namespace IdentityProvider.DataAccess.Repositories.Users
{
    public class UserAccessTokenRepository : GenericRepository<UserAccessToken>, IUserAccessTokenRepository
    {
        public UserAccessTokenRepository(AppDbContext appDb) : base(appDb)
        {
        }
    }
}
