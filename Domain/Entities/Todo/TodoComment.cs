using TaskManager.Domain.BaseEntities;

namespace TaskManager.Domain.Entities.Todo;

/// <summary>
/// کامنت تسک ها
/// </summary>
public class TodoComment:BaseEntity<int>
{
    /// <summary>
    /// آی دی تسک
    /// </summary>
    public int TodoId { get; set; }

    /// <summary>
    /// آی دی کاربر
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// بدنه کامنت
    /// </summary>
    public string Body { get; set; }
}