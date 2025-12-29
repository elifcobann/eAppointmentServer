using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Repositories;
using eAppointmentServer.Infrastructure.Context;
using GenericRepository;

namespace eAppointmentServer.Infrastructure.Repositories;

internal sealed class AppointmentRepositoy : Repository<Appointment, ApplicationDbContext>, IAppointmentRepository
{
    public AppointmentRepositoy(ApplicationDbContext context) : base(context)
    {
    }
}
