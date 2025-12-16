using System.ComponentModel;

namespace TaskManager.Domain.Enums;

/// <summary>
///     جنسیت کاربر
/// </summary>
public enum UserGender
{
    /// <summary>
    ///     مرد
    /// </summary>
    [Description("مرد")] Male = 1,

    /// <summary>
    ///     زن
    /// </summary>
    [Description("زن")] Female = 2,


    /// <summary>
    ///     نامشخص
    /// </summary>
    [Description("نامشخص")] Both = 3
}