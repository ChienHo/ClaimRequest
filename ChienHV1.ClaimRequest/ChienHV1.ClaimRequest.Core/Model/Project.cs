using System;
using System.Collections.Generic;

namespace ChienHV1.ClaimRequest.Core.Model
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public DateTimeOffset Form { get; set; }
        public DateTimeOffset To { get; set; }
        public int PMId { get; set; }
        public virtual Staff StaffPM { get; set; }
        public int QAId { get; set; }
        public virtual Staff StaffQA { get; set; }
        public virtual ICollection<Claim> Claim { get; set; }
        public virtual ICollection<StaffProject> StaffProject { get; set; }
    }
}