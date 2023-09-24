using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.Domain.Entities
{
    [Table("user_login_device")]
    public class UserLoginDevice:BaseEntitiy
    {
        [Column("user_id")]
        public Guid UserId { get; set; }
        public User Users { get; set; }
        [Column("ip")]
        public string IP { get; set; } = string.Empty;
        [Column("device_name")]
        public string Device { get; set; } = string.Empty;
        [Column("device_key_name")]
        public string DeviceKeyName { get; set; } = string.Empty;
        [Column("device_version")]
        public double DeviceVersion { get; set; } 
        [Column("os")]
        public string OS { get; set; } = string.Empty;
        [Column("browser")]
        public string Browser { get; set; } = string.Empty;
        [Column("browser_version")]
        public string BrowserVersion { get; set; } = string.Empty;

        [Column("os_version")]
        public string OSVersion { get; set; } = string.Empty;
        [Column("country")]
        public string Country { get; set; } = string.Empty;
        [Column("region")]
        public string Region { get; set; } = string.Empty;
        [Column("lattitude")]
        public string Lattitude { get; set; } = string.Empty;
        [Column("longitude")] 
        public string Longitude { get; set; } = string.Empty;
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

    }
}
