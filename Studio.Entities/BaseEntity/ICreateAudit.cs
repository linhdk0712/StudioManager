using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Entities.BaseEntity
{
    public interface ICreateAudit
    {
        DateTime CreateDate { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        string CreateBy { get; set; }
    }
}
