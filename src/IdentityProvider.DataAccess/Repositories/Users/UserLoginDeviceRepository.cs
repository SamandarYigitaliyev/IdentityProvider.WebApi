using IdentityProvider.DataAccess.DbContexts;
using IdentityProvider.DataAccess.Interfaces.Users;
using IdentityProvider.Domain.Entities;
using IdentityProvider.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.DataAccess.Repositories.Users
{
    public class UserLoginDeviceRepository : GenericRepository<UserLoginDevice>, IUserLoginDevice
    {
        public UserLoginDeviceRepository(AppDbContext appDb) : base(appDb)
        {
        }
    }
}
