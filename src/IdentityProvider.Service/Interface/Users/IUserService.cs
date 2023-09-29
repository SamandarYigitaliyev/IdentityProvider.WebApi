using IdentityProvider.Persistence.Dtos.Auth;
using IdentityProvider.Persistence.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.Service.Interface.Users
{
    public interface IUserService
    {
        public Task<int> CreateAsync(UserRegisterDto dto);
        public Task<int> UpdateAsync(UserUpdateDto dto);
        public Task<int> DeleteAsync(long id);
      //  public Task<User>
    }
}
