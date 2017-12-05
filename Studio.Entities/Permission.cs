using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Entities
{
    // TODO : Lưu trữ các action
    [Table("Permissions")]
    public class Permission : BaseEntity.BaseEntity
    {
        
        [Key]
        public int PermissionId { get; set; }

        public string PermissionName { get; set; }

        public string Description { get; set; }
       
        public int BusId { get; set; }

        public virtual Business Business { get; set; }

        public  virtual ICollection<GrantPermission> GrantPermissions { get; set; }
    }
}
