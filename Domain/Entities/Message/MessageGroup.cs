using TaskManager.Domain.BaseEntities;

namespace TaskManager.Domain.Entities.Message;

/// <summary>
///     گروه پیام ها
/// </summary>
public class MessageGroup : BaseEntity<int>
{
    /// <summary>
    ///     عنوان
    /// </summary>
    public string Title { get; set; }




    #region Relations

    public ICollection<MessageGroupMember> MessageGroupMembers { get; set; }

    #endregion
}