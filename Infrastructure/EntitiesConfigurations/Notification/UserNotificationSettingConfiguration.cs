using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain.Entities.Notification;

namespace TaskManager.Infrastructure.EntitiesConfigurations.Notification;

/// <summary>
///     کانفیگ انتیتی UserNotificationSetting
/// </summary>
public class UserNotificationSettingConfiguration:IEntityTypeConfiguration<UserNotificationSetting>
{
    public void Configure(EntityTypeBuilder<UserNotificationSetting> builder)
    {
        builder.Property(x => x.PreferredChannel).HasMaxLength(20);
    }
}