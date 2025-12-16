using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Post;

/// <summary>
///     کانفیگ انتیتی Post
/// </summary>
public class PostConfiguration : IEntityTypeConfiguration<Domain.Entities.Post.Post>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Post.Post> builder)
    {
        builder.Property(x => x.Title).HasMaxLength(100);
        builder.Property(x => x.Id).HasColumnType("TINYINT");
        builder.Property(x => x.SectionId).HasColumnType("TINYINT");
        builder.Property(x => x.ParentPostId).HasColumnType("TINYINT");
    }
}