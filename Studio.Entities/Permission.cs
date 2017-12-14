using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studio.Entities.BaseEntity;

namespace Studio.Entities
{
    // TODO : Lưu trữ các action
    [Table("Permissions")]
    public class Permission 
    {
        public Permission()
        {
          
        }
        [Key]
        public Guid PermissionId { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string PermissionName { get; set; }
       
        [MaxLength(500)]
        public string Description { get; set; }

        public Guid BusId { get; set; }

        public virtual Business Business { get; set; }

        public  virtual ICollection<GrantPermission> GrantPermissions { get; set; }
    }
}
