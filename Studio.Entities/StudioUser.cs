using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Entities
{
    [Table("StudioUsers")]
    public class StudioUser : BaseEntity.BaseEntity
    {
        
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Avatar { get; set; }

        public bool IsAdmin { get; set; }
       
        public int StudioId { get; set; }

        public virtual  Studio Studio { get; set; }
    }
}
