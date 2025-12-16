using TaskManager.Domain.BaseEntities;

namespace TaskManager.Domain.Entities.Todo;

/// <summary>
///     وضعیت تسک
/// </summary>
public class TodoStatus : BaseEntity<int>
{
    /// <summary>
    ///     عنوان
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    ///     اولویت
    /// </summary>
    public int? OrderIndex { get; set; }
}