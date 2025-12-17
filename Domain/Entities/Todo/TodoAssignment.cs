using TaskManager.Domain.BaseEntities;
using TaskManager.Domain.Entities.Identity;

namespace TaskManager.Domain.Entities.Todo;

/// <summary>
///     تسک های محول شده
/// </summary>
public class TodoAssignment : BaseEntity<int>
{
    /// <summary>
    ///     تسک
    /// </summary>
    public int TodoId { get; set; }

    /// <summary>
    ///     محول شده توسط
    /// </summary>
    public Guid AssignedBy { get; set; }

    /// <summary>
    ///     محول شده به
    /// </summary>
    public Guid AssignedTo { get; set; }

    /// <summary>
    ///     محول شده در تاریخ
    /// </summary>
    public DateTime AssignmentAt { get; set; }

    /// <summary>
    ///     تاریخ انجام
    /// </summary>
    public DateTime DoneAt { get; set; }

    /// <summary>
    ///     وضعیت
    /// </summary>
    public int StatusId { get; set; }

    /// <summary>
    ///     کامنت
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    ///     فعال / غیر فعال
    /// </summary>
    public bool IsActive { get; set; }




    #region Relations

    public Todo Todo { get; set; }
    public TodoStatus TodoStatus { get; set; }
    public ApplicationUser ApplicationUserBy { get; set; }
    public ApplicationUser ApplicationUserTo { get; set; }

    #endregion
}