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
    }
}