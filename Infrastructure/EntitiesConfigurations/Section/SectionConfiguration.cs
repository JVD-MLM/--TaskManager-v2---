using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Section;

/// <summary>
///     کانفیگ انتیتی Section
/// </summary>
public class SectionConfiguration : IEntityTypeConfiguration<Domain.Entities.Section.Section>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Section.Section> builder)
    {
        builder.Property(x => x.Title).HasMaxLength(100);
        builder.Property(x => x.Id).HasColumnType("TINYINT");
        builder.Property(x => x.ParentSectionId).HasColumnType("TINYINT");
    }
}