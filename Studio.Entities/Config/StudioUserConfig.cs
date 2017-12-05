using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Studio.Entities.Config
{
    public class StudioUserConfig : EntityTypeConfiguration<StudioUser>
    {
        public StudioUserConfig()
        {
            ToTable("StudioUsers");
            Property(x => x.UserId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.UserName).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(x => x.PassWord).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(x => x.StudioId).IsRequired();
        }
    }
}