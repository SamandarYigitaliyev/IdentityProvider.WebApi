using IdentityProvider.DataAccess.DbContexts;
using IdentityProvider.DataAccess.Interfaces;
using IdentityProvider.DataAccess.Interfaces.Users;
using IdentityProvider.DataAccess.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        private AppDbContext appDbContext;

        //User
        public IUserLoginDevice UserLoginDevice { get; }
        public IUserRefreshTokenRepository UserRefreshToken { get; }
        public IUserLoginRepository UserLogin { get; }
        public IUserAccessTokenRepository UserAccessToken { get; }
        public IUserRepository User { get; }

        public UnitOfWork(AppDbContext  appDbContext)
        {
            this.appDbContext = appDbContext;
            this.UserLoginDevice = new UserLoginDeviceRepository(appDbContext);
            this.UserLogin= new UserLoginRepository(appDbContext);
            this.UserRefreshToken= new UserRefreshTokenRepository(appDbContext);
            this.UserAccessToken= new UserAccessTokenRepository(appDbContext);
            this.User = new UserRepository(appDbContext);
        }

        public async Task<int> SaveChangesAsycn()
            => await this.appDbContext.SaveChangesAsync();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
