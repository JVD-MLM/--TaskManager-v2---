using MediatR;
using TaskManager.Application.Responses.Authentication;
using TaskManager.Application.Responses.BaseResponses;

namespace TaskManager.Application.Requests.Commands.Authentication;

/// <summary>
///     درخواست ثبت نام کاربر
/// </summary>
public class SignUpRequest : IRequest<ApiResponse<SignUpRequestResponse>>
{
    /// <summary>
    ///     نام کاربری
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    ///     ایمیل
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    ///     رمز عبور
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    ///     تکرار رمز عبور
    /// </summary>
    public string RePassword { get; set; }
}