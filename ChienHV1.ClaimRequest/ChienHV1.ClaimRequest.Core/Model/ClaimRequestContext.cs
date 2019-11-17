using System.Data.Entity;

namespace ChienHV1.ClaimRequest.Core.Model
{
    public class ClaimRequestContext : DbContext
    {
        public ClaimRequestContext() : base("AspNetIdentityConnection") { }

        static ClaimRequestContext()
        {
            System.Data.Entity.Database.SetInitializer<ClaimRequestContext>(new ClaimRequestInitializer());
        }
        public static ClaimRequestContext Create()
        {
            return new ClaimRequestContext();
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<StaffProject> StaffProjects { get; set; }

    }
}