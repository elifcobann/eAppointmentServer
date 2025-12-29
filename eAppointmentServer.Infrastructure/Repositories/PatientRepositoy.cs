using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Repositories;
using eAppointmentServer.Infrastructure.Context;
using GenericRepository;

namespace eAppointmentServer.Infrastructure.Repositories;

internal sealed class PatientRepositoy : Repository<Patient, ApplicationDbContext>, IPatientRepository
{
    public PatientRepositoy(ApplicationDbContext context) : base(context)
    {
    }
}