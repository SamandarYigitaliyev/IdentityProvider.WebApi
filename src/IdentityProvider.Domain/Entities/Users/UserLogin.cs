using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.Domain.Entities.Users
{
    [Table("user_login")]
    public class UserLogin : Auditable
    {

        public Guid UserID { get; set; }
        public Users Users { get; set; }

        [Column("provider_name")]
        public string ProviderName { get; set; } = string.Empty;
        [Column("provider_key")]
        public string ProviderKey { get; set; } = string.Empty;
        [Column("login_provider")]
        public string LoginProvider { get; set; } = string.Empty;
    }
}
