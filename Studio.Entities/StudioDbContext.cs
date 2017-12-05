using System.Data.Entity;
using System.Threading;

namespace Studio.Entities
{
    public class StudioDbContext : DbContext
    {
        public StudioDbContext() : base("StudioConnectionString")
        {
           
        }

        public DbSet<Studio> Studios { get; set; }
        public DbSet<StudioUser> StudioUsers { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<GrantPermission> GrantPermissions { get; set; }
        public DbSet<StudioActive> StudioActives { get; set; }
        public DbSet<StudioInvoice> StudioInvoices { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new StudioConfig());
            //modelBuilder.Configurations.Add(new StudioUserConfig());
            //modelBuilder.Configurations.Add(new BusinessConfig());
            //modelBuilder.Configurations.Add(new GrantPermissionConfig());
            //modelBuilder.Configurations.Add(new PermissionConfig());
        }
    }
}