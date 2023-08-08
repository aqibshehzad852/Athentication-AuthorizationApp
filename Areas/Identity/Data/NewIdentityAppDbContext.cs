using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewIdentityApp.Areas.Identity.Data;

namespace NewIdentityApp.Areas.Identity.Data;

public class NewIdentityAppDbContext : IdentityDbContext<NewIdentityAppUser>
{
    public NewIdentityAppDbContext(DbContextOptions<NewIdentityAppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new NewIdentityAppEntity());
    }
    public class NewIdentityAppEntity : IEntityTypeConfiguration<NewIdentityAppUser>
    {
        void IEntityTypeConfiguration<NewIdentityAppUser>.Configure(EntityTypeBuilder<NewIdentityAppUser> builder)
        {
            builder.Property(u=> u.FirstName).IsRequired().HasMaxLength(128);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(128);
        }
    }
}
