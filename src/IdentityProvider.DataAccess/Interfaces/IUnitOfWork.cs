using IdentityProvider.DataAccess.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        //User
        public IUserLoginDevice UserLoginDevice { get; }
        public IUserRefreshTokenRepository UserRefreshToken { get; }
        public IUserLoginRepository UserLogin { get; }
        public IUserAccessTokenRepository UserAccessToken { get; }
        public IUserRepository User { get; }

        public Task<int> SaveChangesAsycn();
    }
}
