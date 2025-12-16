using FluentValidation;
using TaskManager.Application.IRepositories;
using TaskManager.Application.Requests.Commands.User;

namespace TaskManager.Application.Validators.User;

/// <summary>
///     ولیدیتور ویرایش کاربر
/// </summary>
public class UpdateUserRequestValidator : AbstractValidator<UpdateUserRequest>
{
    public UpdateUserRequestValidator(IUserRepository userRepository)
    {
        RuleFor(x => x.Id)
            .MustAsync(async (id, cancellationToken) => await userRepository.IsExist(id, cancellationToken))
            .WithMessage("رکورد مورد نظر یافت نشد");
    }
}