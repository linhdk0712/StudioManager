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
    [Table("StudioUsers")]
    public class StudioUser :  ICreateAudit, IStatus, IModifiAudit
    {
        public StudioUser()
        {
          
        }
        
        [Key]
        public Guid UserId { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(30)]
        public string PassWord { get; set; }
       
        [MaxLength(255)]
        public string FullName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(500)]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string Email { get; set; }
       
        [MaxLength(500)]
        public string Avatar { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsSystemAdmin { get; set; }

        public Guid StudioId { get; set; }

        public virtual  Studio Studio { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreateBy { get; set; }

        public bool Status { get; set; }

        public DateTime? ModifyDate { get; set; }

        public string ModifyBy { get; set; }
    }
}
