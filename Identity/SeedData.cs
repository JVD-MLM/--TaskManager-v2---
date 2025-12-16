using Microsoft.AspNetCore.Identity;
using TaskManager.Domain.Entities.Identity;
using TaskManager.Domain.Enums;
using TaskManager.Domain.Enums.Extensions;

namespace TaskManager.Identity;

/// <summary>
///     اضافه کردن نقش ها و ادمین در دیتابیس
/// </summary>
public static class SeedData
{
    public static async Task Initialize(RoleManager<ApplicationRole> roleManager,
        UserManager<ApplicationUser> userManager)
    {
        var roles = Enum.GetValues(typeof(UserRole)).Cast<UserRole>().ToList(); // گرفتن لیست نقش های enum

        foreach (var role in roles) // ایجاد نقش ها در دیتابیس
        {
            var roleName = role.GetName();

            var roleExist = await roleManager.RoleExistsAsync(roleName);

            if (!roleExist)
                await roleManager.CreateAsync(new ApplicationRole
                {
                    Name = roleName
                });
        }

        var adminUser = new ApplicationUser
        {
            UserName = "admin@example.com",
            Email = "admin@example.com",
            EmailConfirmed = true,
            IsAdmin = true
        };

        var adminPassword = "Admin123!";

        var user = await userManager.FindByEmailAsync(adminUser.Email);

        if (user == null)
        {
            var createAdmin = await userManager.CreateAsync(adminUser, adminPassword);
            if (createAdmin.Succeeded) await userManager.AddToRoleAsync(adminUser, "Admin");
        }
    }
}