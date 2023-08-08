using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NewIdentityApp.Areas.Identity.Data
{
    internal class NewIdentityAppEntity : IEntityTypeConfiguration<object>
    {
        void IEntityTypeConfiguration<object>.Configure(EntityTypeBuilder<object> builder)
        {
            throw new NotImplementedException();
        }
    }
}