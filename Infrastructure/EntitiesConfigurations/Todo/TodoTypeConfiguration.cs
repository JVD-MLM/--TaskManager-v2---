using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Todo;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Todo;

/// <summary>
///     کانفیگ انتیتی TodoType
/// </summary>
public class TodoTypeConfiguration:IEntityTypeConfiguration<TodoType>
{
    public void Configure(EntityTypeBuilder<TodoType> builder)
    {
        builder.Property(x => x.Id).HasColumnType("TINYINT");
        builder.Property(x => x.Title).HasMaxLength(100);
        builder.Property(x => x.Description).HasMaxLength(256);
    }
}