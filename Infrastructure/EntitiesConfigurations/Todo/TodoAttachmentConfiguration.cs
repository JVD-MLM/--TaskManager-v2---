using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Todo;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Todo;

/// <summary>
///     کانفیگ انتیتی TodoAttachment
/// </summary>
public class TodoAttachmentConfiguration:IEntityTypeConfiguration<TodoAttachment>
{
    public void Configure(EntityTypeBuilder<TodoAttachment> builder)
    {
        builder.Property(x => x.FilePath).HasMaxLength(256);
    }
}