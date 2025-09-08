using Microsoft.EntityFrameworkCore;

namespace TodoApp.Services;

public static class DatabaseService
{
    public static void RegisterDatabaseService(this IServiceCollection services)
    {
        services.AddDbContext<TodoDb>(opt 
            => opt.UseInMemoryDatabase("TodoList"));
        services.AddDatabaseDeveloperPageExceptionFilter();
    }
}