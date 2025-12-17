using Microsoft.AspNetCore.Identity;
using TaskManager.Domain.Entities.Log;
using TaskManager.Domain.Entities.Message;
using TaskManager.Domain.Entities.Notification;
using TaskManager.Domain.Entities.Todo;
using TaskManager.Domain.Enums;

namespace TaskManager.Domain.Entities.Identity;

/// <summary>
///     کاربر
/// </summary>
public class ApplicationUser : IdentityUser<Guid>
{
    /// <summary>
    ///     نام
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    ///     نام خانوادگی
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    ///     تاریخ ایجاد
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    ///     تاریخ ایجاد
    /// </summary>
    public Guid? CreatedBy { get; set; }

    /// <summary>
    ///     تاریخ ویرایش
    /// </summary>
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    ///     تاریخ ویرایش
    /// </summary>
    public Guid? ModifiedBy { get; set; }

    /// <summary>
    ///     فعال / غیر فعال
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    ///     جنسیت
    /// </summary>
    public UserGender Gender { get; set; }

    /// <summary>
    ///     کد ملی
    /// </summary>
    public string NationalCode { get; set; }

    /// <summary>
    /// واحد
    /// </summary>
    public int SectionId { get; set; }

    /// <summary>
    /// پست
    /// </summary>
    public int PostId { get; set; }




    #region Methods

    /// <summary>
    ///     متد آپدیت
    /// </summary>
    public void Update(string? firstName, string? lastName, UserGender gender)
    {
        FirstName = firstName;
        LastName = lastName;
        LastName = lastName;
        Gender = gender;
    }

    #endregion




    #region Relations

    public ICollection<TodoAssignment> TodoAssignmentsTo { get; set; }
    public ICollection<TodoAssignment> TodoAssignmentsBy { get; set; }
    public Section.Section Section { get; set; }
    public Post.Post Post { get; set; }
    public ICollection<AuditLog>? AuditLogs { get; set; }
    public ICollection<MessageGroupMember>? MessageGroupMembers { get; set; }
    public ICollection<MessageRecipient> MessageRecipients { get; set; }
    public ICollection<UserNotificationSetting>? UserNotificationSettings { get; set; }
    public ICollection<Message.Message>? Messages { get; set; }
    public ICollection<Notification.Notification>? Notifications { get; set; }
    public ICollection<TodoComment>? TodoComments { get; set; }

    #endregion
}