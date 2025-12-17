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
        builder.HasOne(x => x.Todo).WithMany(x => x.TodoAssignments).HasForeignKey(x => x.TodoId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.TodoStatus).WithMany(x => x.TodoAssignments).HasForeignKey(x => x.StatusId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.ApplicationUserBy).WithMany(x => x.TodoAssignmentsBy).HasForeignKey(x => x.AssignedBy).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.ApplicationUserTo).WithMany(x => x.TodoAssignmentsTo).HasForeignKey(x => x.AssignedTo).OnDelete(DeleteBehavior.NoAction);
    }
}