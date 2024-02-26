using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace RentACar.Application;
public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(c =>
        {
            c.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        return services;
    }

}
