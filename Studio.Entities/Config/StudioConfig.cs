using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Studio.Entities.Config
{
    public class StudioConfig : EntityTypeConfiguration<Studio>
    {
        public StudioConfig()
        {
            ToTable("Studios");
            Property(x => x.StudioId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StudioCode).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(x => x.StudioName).IsRequired().HasMaxLength(500).HasColumnType("nvarchar");
            Property(x => x.SkypeName).IsRequired().HasColumnType("varchar");
            Property(x => x.PhoneNumber).IsRequired().HasColumnType("varchar").HasMaxLength(15);
            Property(x => x.Email).IsRequired().HasColumnType("varchar").HasMaxLength(150);
            Property(x => x.Address).IsRequired().HasMaxLength(500).HasColumnType("nvarchar");
            Property(x => x.Logo).HasMaxLength(500).HasColumnType("nvarchar");
        }
    }
}