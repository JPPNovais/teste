using Microsoft.Extensions.DependencyInjection;
using Amoedar.Interno.Application;
using Amoedar.Interno.Application.Interfaces;
using Amoedar.Interno.Domain.Repositories;
using Amoedar.Interno.Infrastructure.Repositories;
using System.Diagnostics.CodeAnalysis;

namespace Amoedar.Interno.CrossCutting.IoC
{
    [ExcludeFromCodeCoverage]
    public static class DependencyResolver
    {
        public static void AddDependencyResolver(this IServiceCollection services)
        {
            RegisterApplications(services);
            RegisterRepositories(services);
        }

        private static void RegisterApplications(IServiceCollection services)
        {
            services.AddScoped<IClienteApplication, ClienteApplication>();
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
        }
    }
}