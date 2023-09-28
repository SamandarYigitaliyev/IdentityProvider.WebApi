using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.Persistence.Dtos.Users
{
    public class UserUpdateParolDto
    {
        public string Password { get; set; } = string.Empty;
    }
}
