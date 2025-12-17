using TaskManager.Domain.BaseEntities;
using TaskManager.Domain.Entities.Identity;

namespace TaskManager.Domain.Entities.Message;

/// <summary>
///     پیام
/// </summary>
public class Message : BaseEntity<int>
{
    /// <summary>
    /// فرستنده
    /// </summary>
    public Guid SenderId { get; set; }

    /// <summary>
    /// موضوع
    /// </summary>
    public string Subject { get; set; }

    /// <summary>
    /// بدنه پیام
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    /// پاسخ به پیام
    /// </summary>
    public int ReplyToMessage { get; set; }




    #region Relations

    public ICollection<MessageRecipient> MessageRecipients { get; set; }
    public ApplicationUser User { get; set; }
    public Message ReplyTo { get; set; }
    public ICollection<Message> Childs { get; set; }

    #endregion
}