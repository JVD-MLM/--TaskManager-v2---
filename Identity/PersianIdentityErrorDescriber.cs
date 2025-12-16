using Microsoft.AspNetCore.Identity;

namespace TaskManager.Identity;

/// <summary>
///     ارور های فارسی identity
/// </summary>
public class PersianIdentityErrorDescriber : IdentityErrorDescriber
{
    public override IdentityError DefaultError()
    {
        return new IdentityError { Code = nameof(PasswordMismatch), Description = "رمز عبور نادرست است" };
    }


    public override IdentityError InvalidToken()
    {
        return new IdentityError { Code = nameof(InvalidToken), Description = "توکن نامعتبر است" };
    }


    public override IdentityError LoginAlreadyAssociated()
    {
        return new IdentityError
        {
            Code = nameof(LoginAlreadyAssociated),
            Description = "این حساب کاربری قبلاً به کاربر دیگری متصل شده است"
        };
    }


    public override IdentityError InvalidUserName(string userName)
    {
        return new IdentityError
            { Code = nameof(InvalidUserName), Description = $"نام کاربری '{userName}' نامعتبر است" };
    }


    public override IdentityError InvalidEmail(string email)
    {
        return new IdentityError { Code = nameof(InvalidEmail), Description = $"ایمیل '{email}' نامعتبر است" };
    }


    public override IdentityError DuplicateUserName(string userName)
    {
        return new IdentityError
            { Code = nameof(DuplicateUserName), Description = $"نام کاربری '{userName}' قبلاً ثبت شده است" };
    }


    public override IdentityError DuplicateEmail(string email)
    {
        return new IdentityError { Code = nameof(DuplicateEmail), Description = $"ایمیل '{email}' قبلاً ثبت شده است" };
    }


    public override IdentityError InvalidRoleName(string role)
    {
        return new IdentityError { Code = nameof(InvalidRoleName), Description = $"نام نقش '{role}' نامعتبر است" };
    }


    public override IdentityError DuplicateRoleName(string role)
    {
        return new IdentityError
            { Code = nameof(DuplicateRoleName), Description = $"نقش '{role}' قبلاً ایجاد شده است" };
    }


    public override IdentityError UserAlreadyHasPassword()
    {
        return new IdentityError
            { Code = nameof(UserAlreadyHasPassword), Description = "این کاربر قبلاً رمز عبور دارد" };
    }


    public override IdentityError UserLockoutNotEnabled()
    {
        return new IdentityError
            { Code = nameof(UserLockoutNotEnabled), Description = "قفل شدن برای این کاربر فعال نیست" };
    }


    public override IdentityError UserAlreadyInRole(string role)
    {
        return new IdentityError
            { Code = nameof(UserAlreadyInRole), Description = $"کاربر قبلاً عضو نقش '{role}' است" };
    }


    public override IdentityError UserNotInRole(string role)
    {
        return new IdentityError { Code = nameof(UserNotInRole), Description = $"کاربر عضو نقش '{role}' نیست" };
    }


    public override IdentityError PasswordTooShort(int length)
    {
        return new IdentityError
            { Code = nameof(PasswordTooShort), Description = $"رمز عبور باید حداقل {length} کاراکتر باشد" };
    }


    public override IdentityError PasswordRequiresNonAlphanumeric()
    {
        return new IdentityError
        {
            Code = nameof(PasswordRequiresNonAlphanumeric),
            Description = "رمز عبور باید حداقل یک کاراکتر غیرحرفی یا عددی داشته باشد"
        };
    }


    public override IdentityError PasswordRequiresDigit()
    {
        return new IdentityError
            { Code = nameof(PasswordRequiresDigit), Description = "رمز عبور باید حداقل یک رقم (0-9) داشته باشد" };
    }


    public override IdentityError PasswordRequiresLower()
    {
        return new IdentityError
        {
            Code = nameof(PasswordRequiresLower),
            Description = "رمز عبور باید حداقل یک حرف کوچک انگلیسی داشته باشد"
        };
    }


    public override IdentityError PasswordRequiresUpper()
    {
        return new IdentityError
        {
            Code = nameof(PasswordRequiresUpper),
            Description = "رمز عبور باید حداقل یک حرف بزرگ انگلیسی داشته باشد"
        };
    }


    public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
    {
        return new IdentityError
        {
            Code = nameof(PasswordRequiresUniqueChars),
            Description = $"رمز عبور باید حداقل {uniqueChars} کاراکتر یکتا داشته باشد"
        };
    }


    public override IdentityError RecoveryCodeRedemptionFailed()
    {
        return new IdentityError
            { Code = nameof(RecoveryCodeRedemptionFailed), Description = "کد بازیابی نامعتبر است" };
    }
}