using TaskManager.Domain.BaseEntities;
using TaskManager.Domain.Enums;

namespace TaskManager.Domain.Entities.Todo;

public class Todo : BaseEntity<int>
{
    /// <summary>
    ///     عنوان
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    ///     توضیحات
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    ///     نوع تسک
    /// </summary>
    public int TodoTypeId { get; set; }

    /// <summary>
    ///     وضعیت
    /// </summary>
    public int StatusId { get; set; }

    /// <summary>
    ///     کاربر مربوطه
    /// </summary>
    public Guid AssignedUserId { get; set; }

    /// <summary>
    ///     تاریخ شروع
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    ///     تاریخ انجام
    /// </summary>
    public DateTime DoneDate { get; set; }

    /// <summary>
    ///     تاریخ پایان
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    ///     تسک والد
    /// </summary>
    public int ParentTodoId { get; set; }

    /// <summary>
    /// اولویت
    /// </summary>
    public Priority Priority { get; set; }
}