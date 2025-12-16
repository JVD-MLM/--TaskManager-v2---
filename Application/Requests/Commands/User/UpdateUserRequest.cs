using MediatR;
using TaskManager.Application.Responses.BaseResponses;
using TaskManager.Application.Responses.User;
using TaskManager.Domain.Enums;

namespace TaskManager.Application.Requests.Commands.User;

/// <summary>
///     درخواست ويرايش کاربر
/// </summary>
public class UpdateUserRequest : IRequest<ApiResponse<UpdateUserRequestResponse>>
{
    /// <summary>
    ///     آي دي
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    ///     نام
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    ///     نام خانوادگی
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    ///     جنسیت
    /// </summary>
    public UserGender Gender { get; set; }
}