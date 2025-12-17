using TaskManager.Domain.BaseEntities;
using TaskManager.Domain.Entities.Identity;

namespace TaskManager.Domain.Entities.Notification;

/// <summary>
/// اعلان
/// </summary>
public class Notification:BaseEntity<int>
{
    /// <summary>
    /// کاربر
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// نوع
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// نوع انتیتی
    /// </summary>
    public string EntityType { get; set; }

    /// <summary>
    /// آی دی انتیتی
    /// </summary>
    public int EntityId { get; set; }

    /// <summary>
    /// عنوان
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// بدنه
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    /// خوتنده شده / نشده
    /// </summary>
    public bool IsRead { get; set; }

    /// <summary>
    /// تاریخ خواندن
    /// </summary>
    public DateTime ReadAt { get; set; }




    #region Relations

    public ApplicationUser? User { get; set; }

    #endregion
}