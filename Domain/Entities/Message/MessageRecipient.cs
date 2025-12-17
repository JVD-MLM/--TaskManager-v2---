using TaskManager.Domain.BaseEntities;
using TaskManager.Domain.Entities.Identity;

namespace TaskManager.Domain.Entities.Message;

public class MessageRecipient:BaseEntity<int>
{
    /// <summary>
    /// آی دی پیام
    /// </summary>
    public int MessageId { get; set; }

    /// <summary>
    /// کاربر دریافت کننده
    /// </summary>
    public Guid ReceiverId { get; set; }

    /// <summary>
    /// خوانده شده / نشده
    /// </summary>
    public bool IsRead { get; set; }

    /// <summary>
    /// تاریخ خواندن
    /// </summary>
    public DateTime ReadAt { get; set; }





    #region Relations

    public Message Message { get; set; }
    public ApplicationUser User { get; set; }

    #endregion
}