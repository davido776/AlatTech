using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBTest.Data;
using WBTest.Services.Abstractions;
using WBTest.Services.Implementations;
using WBTest.Services.Mappings;

namespace WBTest.Extensions
{
    public static class ApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ICustomerService, CustomerService>();

            services.AddScoped<IBankService, BankService>();

            services.AddAutoMapper(typeof(CustomerProfile));

            services.AddControllers();

            services.AddDbContextPool<DBContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
                //options.ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.RowLimitingOperationWithoutOrderByWarning));

            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WBTest", Version = "v1" });
            });

            return services;
        }
    }
}
