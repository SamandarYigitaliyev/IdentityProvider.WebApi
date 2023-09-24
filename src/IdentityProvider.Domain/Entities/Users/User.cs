using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.Domain.Entities.Users
{
    [Table("users")]
    public class Users:Auditable
    {
        [Required]
        [Column("first_name")]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [Column("last_name")]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [Column("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        [Column("Salt")]
        public string Salt { get; set; } = string.Empty;
        [Required]
        [Column("password_hash")]
        public string PasswordHash { get; set; } = string.Empty;
        [Column("provider")]
        public string Provider { get; set; } = string.Empty;
        [Column("provider_confirme")]
        public string ProviderConfirme { get; set; } = string.Empty;
    }
}
