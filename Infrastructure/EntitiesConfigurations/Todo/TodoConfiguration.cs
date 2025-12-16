using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Todo;

/// <summary>
///     کانفیگ انتیتی Todos
/// </summary>
public class TodoConfiguration : IEntityTypeConfiguration<Domain.Entities.Todo.Todo>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Todo.Todo> builder)
    {
        builder.Property(x => x.Title).HasMaxLength(150);
        builder.Property(x => x.TodoTypeId).HasColumnType("TINYINT");
        builder.Property(x => x.StatusId).HasColumnType("TINYINT");
    }
}