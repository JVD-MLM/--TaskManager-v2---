using TaskManager.Domain.BaseEntities;

namespace TaskManager.Domain.Entities.Todo;

/// <summary>
///     نوع تسک
/// </summary>
public class TodoType : BaseEntity<int>
{
    /// <summary>
    ///     عنوان
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    ///     توضیحات
    /// </summary>
    public string? Description { get; set; }




    #region Relations

    public ICollection<Todo> Todos { get; set; }

    #endregion
}