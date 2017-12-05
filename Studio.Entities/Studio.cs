using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studio.Entities
{
    [Table("Studios")]
    public class Studio : BaseEntity.BaseEntity
    {
        
        [Key]
        public int StudioId { get; set; } // int, not null

        public string StudioCode { get; set; } // nvarchar(30), not null

        public string StudioName { get; set; } // nvarchar(max), not null

        public string SkypeName { get; set; } // nvarchar(max), null

        public string PhoneNumber { get; set; } // nvarchar(15), null

        public string Email { get; set; }

        public string Address { get; set; } // nvarchar(max), null

        public string Logo { get; set; }

        public ICollection<StudioUser> StudioUsers { get; set; }
    }
}