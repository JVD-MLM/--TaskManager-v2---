using TaskManager.Domain.BaseEntities;

namespace TaskManager.Domain.Entities.Log;

/// <summary>
///     لاگ سیستم
/// </summary>
public class SystemLog : BaseEntity<int>
{
    /// <summary>
    ///     سطح لاگ
    /// </summary>
    public string? LogLevel { get; set; }

    /// <summary>
    ///     پیام
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    ///     سورس
    /// </summary>
    public string? Source { get; set; }
}