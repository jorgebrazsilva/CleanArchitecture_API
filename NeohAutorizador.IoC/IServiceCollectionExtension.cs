using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NeohAutorizador.ApplicationCore.Interfaces.Repository;
using NeohAutorizador.ApplicationCore.Interfaces.Services;
using NeohAutorizador.ApplicationCore.Services;
using NeohAutorizador.Infrastructure.Context;
using NeohAutorizador.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeohAutorizador.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IExemploService, ExemploService>();
            return services;
        }

        public static IServiceCollection RegisterRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IExemploRepository, ExemploRepository>();
            return services;
        }
        public static IServiceCollection RegisterContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<NeohAutorizadorContext>(options =>options.UseSqlServer(connectionString));              
            return services;
        }
    }
}
