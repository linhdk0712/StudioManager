using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Entities.Config
{
    public class BusinessConfig : EntityTypeConfiguration<Business>
    {
        public BusinessConfig()
        {
            ToTable("Business");
            Property(x => x.BusName).IsRequired();
            Property(x => x.Description).HasColumnType("nvarchar").HasMaxLength(250);
        }
    }
}
