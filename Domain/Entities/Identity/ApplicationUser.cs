using System.ComponentModel;
using Microsoft.AspNetCore.Identity;
using TaskManager.Domain.Enums;

namespace TaskManager.Domain.Entities.Identity;

/// <summary>
///     کاربر
/// </summary>
public class ApplicationUser : IdentityUser<Guid>
{
    /// <summary>
    ///     ادمین
    /// </summary>
    public bool IsAdmin { get; set; }

    /// <summary>
    ///     نام
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    ///     نام خانوادگی
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    ///     حذف شده / نشده
    /// </summary>
    public bool IsDeleted { get; protected set; }

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
    ///     بلاک شده / نشده
    /// </summary>
    public bool IsBlocked { get; set; }

    /// <summary>
    ///     کد فعال سازی موبایل
    /// </summary>
    public string? MobileActiveCode { get; set; }

    /// <summary>
    ///     فعال / غیر فعال
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    ///     جنسیت
    /// </summary>
    public UserGender Gender { get; set; }

    #region Methods

    /// <summary>
    ///     متد آپدیت
    /// </summary>
    public void Update(bool isAdmin, string? firstName, string? lastName, bool isBlocked,
        bool isActive, UserGender gender)
    {
        FirstName = firstName;
        LastName = lastName;
        IsAdmin = isAdmin;
        LastName = lastName;
        IsActive = isActive;
        Gender = gender;
    }

    /// <summary>
    ///     متد حذف
    /// </summary>
    public void BlockUser()
    {
        IsBlocked = true;
    }

    #endregion
}