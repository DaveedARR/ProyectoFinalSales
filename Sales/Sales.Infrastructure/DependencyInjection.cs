using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sales.Application.Contracts.Repositories;
using Sales.Application.Contracts.Services;
using Sales.Application.Services;
using Sales.Infrastructure.Context;
using Sales.Infrastructure.Gateway.Identity;
using Sales.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("conexion"));
            });

            services.AddScoped<IVentaRepository, VentaRepository>();
            services.AddScoped<IVentaService, VentaService>();
            services.AddScoped<IFacturaRepository, FacturaRepository>();
            services.AddScoped<IFacturaService, FacturaService>();
            services.AddScoped<IReporteRepository, ReporteRepository>();
            services.AddScoped<IReporteService, ReporteService>();
            services.AddScoped<ICajaRepository, CajaRepository>();
            services.AddScoped<ICajaService, CajaService>();
            services.AddScoped<IdentityService>();
            return services;
        }
    }
}
