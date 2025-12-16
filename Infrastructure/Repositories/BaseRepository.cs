using TaskManager.Application.IServices;

namespace TaskManager.Infrastructure.Repositories;

/// <summary>
///     ریپازیتوری پایه
/// </summary>
public class BaseRepository
{
    protected readonly TaskManagerDbContext _context;
    protected readonly IAuthService _authService;

    public BaseRepository(TaskManagerDbContext context, IAuthService authService)
    {
        _context = context;
        _authService = authService;
    }
}