using ContactBookAPI_Infrastructure.Repositories.Abstractions;
using ContactBookAPI_Infrastructure.Repositories.Implementations;
using ContactBookAPI_Infrastructure.Uow;

namespace ContactBookAPI.Extensions
{
    public static class ServiceExtension
    {
        public static void ResolvedDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
        }
    }
}
