using TaskManager.Domain.BaseEntities;

namespace TaskManager.Domain.Entities.Todo;

/// <summary>
/// پیوست تسک
/// </summary>
public class TodoAttachment:BaseEntity<int>
{
    /// <summary>
    /// آی دی تسک
    /// </summary>
    public int TodoId { get; set; }

    /// <summary>
    /// مسیر فایل
    /// </summary>
    public string? FilePath { get; set; }
}