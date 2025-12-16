using Microsoft.AspNetCore.Identity;
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
}