using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Identity;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Identity;

/// <summary>
///     کانفیگ انتیتی ApplicationUser
/// </summary>
public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(32);
        builder.Property(x => x.LastName).HasMaxLength(64);
        builder.Property(x => x.NationalCode).HasMaxLength(10);
        builder.Property(x => x.PasswordHash).HasMaxLength(64);
        builder.Property(x => x.PhoneNumber).HasMaxLength(11);
        builder.Property(x => x.PostId).HasColumnType("TINYINT");
        builder.Property(x => x.SectionId).HasColumnType("TINYINT");
    }
}