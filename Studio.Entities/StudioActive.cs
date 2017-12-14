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
    [Table("StudioActives")]
    public class StudioActive : ICreateAudit,IStatus,IModifiAudit
    {
        public StudioActive()
        {
           
        }
        [Key]
        public Guid StudioActiveId { get; set; }

        public DateTime? ActiveFrom { get; set; }

        public DateTime? ActiveTo { get; set; }


        public Guid StudioId { get; set; }

        public virtual Studio Studio { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public bool Status { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
