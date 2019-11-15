using System.Collections.Generic;

namespace ChienHV1.ClaimRequest.Core.Model
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public string JobRank { get; set; }
        public decimal Salary { get; set; }
        public virtual ICollection<Claim> Claim { get; set; }
        public virtual ICollection<Project> Project { get; set; }
        public virtual ICollection<StaffProject> StaffProject { get; set; }
    }
}