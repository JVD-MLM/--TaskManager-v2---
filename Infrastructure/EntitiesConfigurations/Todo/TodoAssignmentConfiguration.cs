using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Todo;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Todo;

/// <summary>
///     کانفیگ انتیتی TodoAssignment
/// </summary>
public class TodoAssignmentConfiguration : IEntityTypeConfiguration<TodoAssignment>
{
    public void Configure(EntityTypeBuilder<TodoAssignment> builder)
    {
        builder.Property(x => x.StatusId).HasColumnType("TINYINT");
    }
}