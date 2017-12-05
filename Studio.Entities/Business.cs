using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studio.Entities
{
    // TODO : Lưu trữ các controller
    [Table("Businesses")]
    public  class Business :BaseEntity.BaseEntity
    {
        
        [Key]
        public int BusId { get; set; }

        public string BusName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }


    }
}