using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Message;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Message;

/// <summary>
///     کانفیگ انتیتی MessageRecipient
/// </summary>
public class MessageRecipientConfiguration:IEntityTypeConfiguration<MessageRecipient>
{
    public void Configure(EntityTypeBuilder<MessageRecipient> builder)
    {
    }
}