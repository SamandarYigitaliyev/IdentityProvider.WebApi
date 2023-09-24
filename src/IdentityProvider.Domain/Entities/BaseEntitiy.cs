using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.Domain.Entities
{
    public class BaseEntitiy
    {
        [Key,Required]
        [Column("id")]
        public long Id { get; set; }
    }
}
