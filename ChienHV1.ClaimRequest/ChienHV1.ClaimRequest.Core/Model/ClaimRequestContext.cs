using System.Data.Entity;

namespace ChienHV1.ClaimRequest.Core.Model
{
    public class ClaimRequestContext : DbContext
    {
        public ClaimRequestContext() : base("ClaimRequestConnection") { }

        static ClaimRequestContext()
        {
            System.Data.Entity.Database.SetInitializer<ClaimRequestContext>(new ClaimRequestInitializer());
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<StaffProject> StaffProjects { get; set; }

    }

    public class ClaimRequestInitializer : DropCreateDatabaseIfModelChanges<ClaimRequestContext>
    {
        protected override void Seed(ClaimRequestContext context)
        {
            base.Seed(context);
        }
    }
}