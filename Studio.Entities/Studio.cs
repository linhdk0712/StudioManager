﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Studio.Entities.BaseEntity;

namespace Studio.Entities
{
    [Table("Studios")]
    public class Studio : ICreateAudit,IStatus,IModifiAudit
    {

        public Studio()
        {
           

        }
        [Key]
        public Guid StudioId { get; set; } // int, not null
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string StudioCode { get; set; } // nvarchar(30), not null
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(500)]
        public string StudioName { get; set; } // nvarchar(max), not null

        [DataType("nvarchar")]
        [MaxLength(100)]
        public string SkypeName { get; set; } // nvarchar(max), null
        [Required]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(20)]
        public string PhoneNumber { get; set; } // nvarchar(15), null
        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(500)]
        public string Address { get; set; } // nvarchar(max), null
       
        [MaxLength(500)]
        public string Logo { get; set; }

        public virtual ICollection<StudioUser> StudioUsers { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreateBy { get; set; }

        public bool Status { get; set; }

        public DateTime? ModifyDate { get; set; }

        public string ModifyBy { get; set; }
    }
}