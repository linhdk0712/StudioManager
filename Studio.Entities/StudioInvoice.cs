using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Entities
{
    [Table("StudioInvoices")]
    public class StudioInvoice
    {
        
        [Key]
        public int InvoiceId { get; set; }

        [Required]
        public string InvoiceNumber { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public decimal RepaymentAmount { get; set; }

        [Required]
        public decimal PrincipalAmount { get; set; }

        public DateTime? RepaymentDate { get; set; }

       
        public int StudioId { get; set; }

        public virtual Studio Studio { get; set; }

    }
}
