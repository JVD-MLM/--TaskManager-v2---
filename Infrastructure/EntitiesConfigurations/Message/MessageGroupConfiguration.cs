using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Message;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Message;

/// <summary>
///     کانفیگ انتیتی MessageGroup
/// </summary>
public class MessageGroupConfiguration : IEntityTypeConfiguration<MessageGroup>
{
    public void Configure(EntityTypeBuilder<MessageGroup> builder)
    {
        builder.Property(x => x.Title).HasMaxLength(100);
    }
}