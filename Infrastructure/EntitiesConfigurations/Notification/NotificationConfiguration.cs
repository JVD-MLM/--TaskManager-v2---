using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Notification;

/// <summary>
///     کانفیگ انتیتی NotificationCon
/// </summary>
public class NotificationConfiguration : IEntityTypeConfiguration<Domain.Entities.Notification.Notification>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Notification.Notification> builder)
    {
        builder.Property(x => x.Type).HasMaxLength(50);
        builder.Property(x => x.EntityType).HasMaxLength(50);
        builder.Property(x => x.Title).HasMaxLength(150);
        builder.HasOne(x => x.User).WithMany(x => x.Notifications).HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}