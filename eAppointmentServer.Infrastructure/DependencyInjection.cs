using eAppointmentServer.Application.Services;
using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Repositories;
using eAppointmentServer.Infrastructure.Context;
using eAppointmentServer.Infrastructure.Repositories;
using eAppointmentServer.Infrastructure.Services;
using GenericRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eAppointmentServer.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
        });

        services.AddIdentity<AppUser, AppRole>( action =>
        {           
            action.Password.RequireDigit = false;
            action.Password.RequireLowercase = false;
            action.Password.RequireUppercase = false;
            action.Password.RequireNonAlphanumeric = false;
            action.Password.RequiredLength = 1;
        }).AddEntityFrameworkStores<ApplicationDbContext>();

        services.AddScoped<IAppointmentRepository, AppointmentRepositoy>();
        services.AddScoped<IDoctorRepository, DoctorRepositoy>();
        services.AddScoped<IPatientRepository, PatientRepositoy>();
        services.AddScoped<IUnitOfWork>(srv => srv.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<IJwtProvider, JwtProvider>();

        return services;
    }
}
