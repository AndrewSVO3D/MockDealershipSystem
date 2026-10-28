using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MockDealership.Application.Interfaces;
using MockDealership.Infrastructure.Data;
using MockDealership.Infrastructure.Repositories;

namespace MockDealership.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
        services.AddScoped<IVehicleRepository, VehicleRepository>();
        return services;
    }
}
