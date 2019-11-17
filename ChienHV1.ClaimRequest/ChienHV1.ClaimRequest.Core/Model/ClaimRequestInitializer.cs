using System.Data.Entity;

namespace ChienHV1.ClaimRequest.Core.Model
{
    public class ClaimRequestInitializer : DropCreateDatabaseIfModelChanges<ClaimRequestContext>
    {
        protected override void Seed(ClaimRequestContext context)
        {
            base.Seed(context);
        }
    }
}