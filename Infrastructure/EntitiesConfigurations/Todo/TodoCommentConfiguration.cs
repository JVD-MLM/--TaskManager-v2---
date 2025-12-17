using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Todo;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Todo;

/// <summary>
///     کانفیگ انتیتی TodoComment
/// </summary>
public class TodoCommentConfiguration:IEntityTypeConfiguration<TodoComment>
{
    public void Configure(EntityTypeBuilder<TodoComment> builder)
    {
    }
}