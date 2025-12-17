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
        builder.HasOne(x => x.TodoType).WithMany(x => x.Todos).HasForeignKey(x => x.TodoTypeId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.TodoStatus).WithMany(x => x.Todos).HasForeignKey(x => x.StatusId).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.ParentTodo).WithMany(x => x.Childs).HasForeignKey(x => x.ParentTodoId).OnDelete(DeleteBehavior.NoAction);
    }
}