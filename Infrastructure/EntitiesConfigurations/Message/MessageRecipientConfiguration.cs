using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Message;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Message;

/// <summary>
///     کانفیگ انتیتی MessageRecipient
/// </summary>
public class MessageRecipientConfiguration : IEntityTypeConfiguration<MessageRecipient>
{
    public void Configure(EntityTypeBuilder<MessageRecipient> builder)
    {
        builder.HasOne(x => x.Message).WithMany(x => x.MessageRecipients).HasForeignKey(x => x.MessageId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.User).WithMany(x => x.MessageRecipients).HasForeignKey(x => x.ReceiverId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}