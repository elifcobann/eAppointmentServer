using eAppointmentServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;

namespace eAppointmentServer.Infrastructure.Configurations;

internal class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.Property(p => p.FirstName).HasColumnType("nvarchar(50)");
        builder.Property(p => p.LastName).HasColumnType("nvarchar(50)");
       // builder.HasIndex(x => x.FirstName).IsUnique(false); // aynı isimden eklenmesini engeller
    }
}
