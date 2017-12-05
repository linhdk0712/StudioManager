using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Entities
{
    [Table("StudioActives")]
    public class StudioActive
    {
        
        [Key]
        public int StudioActiveId { get; set; }

        public DateTime? ActiveFrom { get; set; }

        public DateTime? ActiveTo { get; set; }

        
        public int StudioId { get; set; }

        public virtual Studio Studio { get; set; }
    }
}
