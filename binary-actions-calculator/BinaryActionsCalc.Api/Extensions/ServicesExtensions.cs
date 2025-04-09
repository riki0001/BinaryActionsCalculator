using AutoMapper;
using BinaryActionsCalc.Data.Context;
using BinaryActionsCalc.Data.Repositories;
using BinaryActionsCalc.Logic.Interfaces;
using BinaryActionsCalc.Logic.Mapping;
using BinaryActionsCalc.Logic.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BinaryActionsCalc.Api.Extensions
{
    public static class ServicesExtensions
    {

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });
        }

        public static void ConfigureDBContext(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<BinaryActionsContext>(opts =>
                opts.UseSqlServer(builder.Configuration.GetConnectionString("BinaryOperationsDb")) 
            );
        }

        public static void ConfigureDI(this IServiceCollection services)
        {
            services.AddScoped<IOperationsRepository, OperationsRepository>();

            services.AddScoped<ICalculationService, CalculationService>();
            services.AddScoped<IOperationService, OperationService>();

            services.AddScoped<ICalculationStrategy, DateCalculationStrategy>();
            services.AddScoped<ICalculationStrategy, NumberCalculationStrategy>();
            services.AddScoped<ICalculationStrategy, StringCalculationStrategy>();
        }

        public static void ConfigureMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new EntityToModel());
                mc.AddProfile(new ModelToEntity());
            });
            IMapper mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);
        }

        public static void ConfigureLogger(this IServiceCollection services, ConfigurationManager config)
        {
            services.AddLogging(loggingBuilder =>
            {
                var loggingSection = config.GetSection("Logging");
            });
        }

    }
}
