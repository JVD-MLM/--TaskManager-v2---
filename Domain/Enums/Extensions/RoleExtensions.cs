namespace TaskManager.Domain.Enums.Extensions;

/// <summary>
///     اکستنشن برای Role Enum
/// </summary>
public static class RoleExtensions
{
    public static string GetName(this UserRole role)
    {
        return Enum.GetName(typeof(UserRole), role);
    }
}