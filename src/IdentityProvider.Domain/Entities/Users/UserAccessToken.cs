using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.Domain.Entities
{
    [Table("user_access_token")]
    public class UserAccessToken:BaseEntitiy
    {
        [Column("user_id")]
        public Guid UserId { get; set; }
        public User Users { get; set; }
        [Column("is_revoked")]
        public bool IsRevoked { get; set; }
        [Column("access_token")]
        public string AccessToken { get; set; } = string.Empty;
        [Column("expired_date")]
        public DateTime ExpiredDate { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
