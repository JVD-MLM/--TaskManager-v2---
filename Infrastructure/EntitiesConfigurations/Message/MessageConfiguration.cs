using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Message;

/// <summary>
///     کانفیگ انتیتی Message
/// </summary>
public class MessageConfiguration:IEntityTypeConfiguration<Domain.Entities.Message.Message>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Message.Message> builder)
    {
        builder.Property(x => x.Subject).HasMaxLength(150);
        builder.HasOne(x => x.User).WithMany(x => x.Messages).HasForeignKey(x => x.SenderId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.ReplyTo).WithMany(x => x.Childs).HasForeignKey(x => x.ReplyToMessage)
            .OnDelete(DeleteBehavior.NoAction);
    }
}