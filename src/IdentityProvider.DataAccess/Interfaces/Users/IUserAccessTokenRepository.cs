using IdentityProvider.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.DataAccess.Interfaces.Users
{
    public interface IUserAccessTokenRepository: IGenericRepository<UserAccessToken>
    {
    }
}
