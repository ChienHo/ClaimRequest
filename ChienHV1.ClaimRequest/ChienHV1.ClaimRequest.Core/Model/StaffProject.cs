using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChienHV1.ClaimRequest.Core.Model
{
    public class StaffProject
    {
        [Key]
        [Column(Order = 0)]
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
        [Key]
        [Column(Order = 1)]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}