using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Entities.BaseEntity
{
    public interface IModifiAudit
    {
        DateTime? ModifyDate { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        string ModifyBy { get; set; }
    }
}
