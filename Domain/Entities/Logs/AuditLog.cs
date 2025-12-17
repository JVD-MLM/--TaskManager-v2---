using TaskManager.Domain.BaseEntities;

namespace TaskManager.Domain.Entities.Log;

/// <summary>
///     لاگ مسئولین
/// </summary>
public class AuditLog : BaseEntity<int>
{
    /// <summary>
    ///     نام انتیتی
    /// </summary>
    public string? EntityName { get; set; }

    /// <summary>
    ///     آی دی انتیتی
    /// </summary>
    public int? EntityId { get; set; }

    /// <summary>
    ///     نوع عملیات
    /// </summary>
    public string? ActionType { get; set; }

    /// <summary>
    ///     انجام شده توسط
    /// </summary>
    public Guid? PerformedBy { get; set; }

    /// <summary>
    ///     تاریخ انجام
    /// </summary>
    public DateTime? PerformedAt { get; set; }

    /// <summary>
    ///     مقدار قبلی
    /// </summary>
    public string? OldValue { get; set; }

    /// <summary>
    ///     مقدار جدید
    /// </summary>
    public string? NewValue { get; set; }

    /// <summary>
    ///     توضیحات
    /// </summary>
    public string? Description { get; set; }
}