using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Entities.BaseEntity
{
    public class BaseEntity
    {
        protected BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }

        protected DateTime CreatedDate { get; set; } // datetime, not null

        protected string CreatedBy { get; set; } // nvarchar(max), null

        protected DateTime? UpdatedDate { get; set; } // datetime, null

        protected string UpdatedBy { get; set; } // nvarchar(max), null

        protected bool Status { get; set; } // bit, not null
    }
}
