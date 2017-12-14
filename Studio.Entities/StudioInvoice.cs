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
    [Table("StudioInvoices")]
    public class StudioInvoice : ICreateAudit, IStatus, IModifiAudit
    {
        public StudioInvoice()
        {
           
        }
        [Key]
        public Guid InvoiceId { get; set; }

        [Required]
        public string InvoiceNumber { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public decimal TotalAmount { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public decimal RepaymentAmount { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public decimal PrincipalAmount { get; set; }

        public DateTime? RepaymentDate { get; set; }


        public Guid StudioId { get; set; }

        public virtual Studio Studio { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public bool Status { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
