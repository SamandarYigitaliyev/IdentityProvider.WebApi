using IdentityProvider.DataAccess.DbContexts;
using IdentityProvider.DataAccess.Interfaces.Users;
using IdentityProvider.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.DataAccess.Repositories.Users
{
    public class UserRefreshTokenRepository : GenericRepository<UserRefreshToken>, IUserRefreshTokenRepository
    {
        public UserRefreshTokenRepository(AppDbContext appDb) : base(appDb)
        {
        }
    }
}
