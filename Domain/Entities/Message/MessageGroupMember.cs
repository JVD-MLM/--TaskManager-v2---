using TaskManager.Domain.BaseEntities;

namespace TaskManager.Domain.Entities.Message;

/// <summary>
/// اعضای گروه پیام ها
/// </summary>
public class MessageGroupMember:BaseEntity<int>
{
    /// <summary>
    /// گروه پیام ها
    /// </summary>
    public int MessageGroupId { get; set; }

    /// <summary>
    /// آی دی کاربر
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// تاریخ پیوستن
    /// </summary>
    public DateTime? JoinedAt { get; set; }
}