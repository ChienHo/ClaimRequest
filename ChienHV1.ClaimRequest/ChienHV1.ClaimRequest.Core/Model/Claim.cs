using System;

namespace ChienHV1.ClaimRequest.Core.Model
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public DateTimeOffset Date { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public string Remarks { get; set; }
        public string AuditTrail { get; set; }
        public string Status { get; set; }
    }
}