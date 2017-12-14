using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Studio.Entities.BaseEntity;

namespace Studio.Entities
{
    // TODO : Lưu trữ các controller
    [Table("Businesses")]
    public  class Business :IStatus
    {
        public Business()
        {
           
        }
        [Key]
        public Guid BusId { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string BusName { get; set; }
        [DataType("nvarchar")]
        [MaxLength(500)]
        public string Description { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }

        public bool Status { get; set; }
    }
}