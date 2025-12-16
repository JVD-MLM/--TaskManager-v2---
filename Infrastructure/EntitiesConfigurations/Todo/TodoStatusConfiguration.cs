using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Todo;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Todo;

/// <summary>
///     کانفیگ انتیتی TodoStatus
/// </summary>
public class TodoStatusConfiguration : IEntityTypeConfiguration<TodoStatus>
{
    public void Configure(EntityTypeBuilder<TodoStatus> builder)
    {
        builder.Property(x => x.Title).HasMaxLength(100);
        builder.Property(x => x.Id).HasColumnType("TINYINT");
        builder.Property(x => x.OrderIndex).HasColumnType("TINYINT");
    }
}