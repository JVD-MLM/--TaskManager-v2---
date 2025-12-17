using TaskManager.Domain.BaseEntities;

namespace TaskManager.Domain.Entities.Notification;

/// <summary>
/// تنظیمات اعلان کاربر
/// </summary>
public class UserNotificationSetting:BaseEntity<int>
{
    public Guid UserId { get; set; }
    public bool NotifyOnTaskAssignment { get; set; }
    public bool NotifyOnTaskComment { get; set; }
    public bool NotifyOnMessageReceived { get; set; }
    public string? PreferredChannel { get; set; }
}