using TaskManager.Domain.BaseEntities;
using TaskManager.Domain.Entities.Identity;

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




    #region Relations

    public Todo Todo { get; set; }
    public ApplicationUser User { get; set; }

    #endregion
}