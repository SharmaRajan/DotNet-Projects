
using EComm.Data;
using Microsoft.EntityFrameworkCore;

namespace EComm.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        // Add configuration for DB string connection
        services.AddDbContext<DataContext>(opt =>
        {
            opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
        });

        // To enable CORS
        services.AddCors();

        //services.AddScoped<ITokenService, TokenService>();
        // services.AddScoped<IUserRepository, UserRepository>();
        // services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            
        return services;
    }
}