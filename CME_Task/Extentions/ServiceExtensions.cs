using CME_Task.ActionFilters;
using CME_Task.Middlewares;
using CME_Task.Models;
using CME_Task.Repositories;

namespace CME_Task.Extentions
{
    public static class ServiceExtensions
    {
        public static void CustomCorsAddition(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());

            });
        }

        public static void ConfigureScoped(this IServiceCollection services)
        {
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<ValidationRouteId>();
            services.AddScoped<ValidateEntityWithId<Room>>();
            services.AddScoped<ValidateEntityWithId<Customer>>();
            services.AddScoped<ValidateEntityWithId<Reservation>>();
            services.AddScoped<ValidateCustomerCreation<Customer>>();
            services.AddScoped<ValidateReserveCreation<Reservation>>();
            services.AddScoped<ValidateRoomId<Reservation>>();
            services.AddScoped<ValidateCustomerId<Reservation>>();
            services.AddScoped<ValidateCustomerReservation>();
        }
        public static void ConfigureMiddlewareException(this WebApplication app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }

        public static void ConfigureCors(this WebApplication app)
        {
            app.UseCors(builder => builder
              .AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
        }


    }
}
