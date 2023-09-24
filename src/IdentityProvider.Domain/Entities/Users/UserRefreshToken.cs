using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.Domain.Entities
{
    [Table("user_refresh_token")]
    public class UserRefreshToken:BaseEntitiy
    {
        [Column("user_id")]
        public Guid UserId { get; set; }
        public User Users { get; set; }
        [Column("refresh_token")]
        public string RefreshToken { get; set; } = string.Empty;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
