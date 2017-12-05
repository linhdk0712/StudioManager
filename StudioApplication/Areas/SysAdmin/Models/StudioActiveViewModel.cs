using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudioApplication.Areas.SysAdmin.Models
{
    public class StudioActiveViewModel
    {
        public StudioActiveViewModel()
        {
            
        }
        public int    StudioId { get; set; }
        public string StudioCode { get; set; } // nvarchar(30), not null

        public string StudioName { get; set; } // nvarchar(max), not null

        public string SkypeName { get; set; } // nvarchar(max), null

        public string PhoneNumber { get; set; } // nvarchar(15), null

        public string Email { get; set; }

        public string Address { get; set; } // nvarchar(max), null

        public string Logo { get; set; }

        public DateTime? ActiveFrom { get; set; }

        public DateTime? ActiveTo { get; set; }
    }
}