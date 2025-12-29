using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Repositories;
using eAppointmentServer.Infrastructure.Context;
using GenericRepository;

namespace eAppointmentServer.Infrastructure.Repositories;

internal sealed class DoctorRepositoy : Repository<Doctor, ApplicationDbContext>, IDoctorRepository
{
    public DoctorRepositoy(ApplicationDbContext context) : base(context)
    {
    }
}
