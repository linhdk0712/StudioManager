using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Entities
{
    [Table("GrantPermissions")]
    public class GrantPermission : BaseEntity.BaseEntity
    {
        
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Permission")]
        public int PermissionId { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("StudioUser")]
        public int UserId { get; set; }

        public string Description { get; set; }

        public virtual StudioUser StudioUser { get; set; }

        public virtual Permission Permission { get; set; }
    }
}
