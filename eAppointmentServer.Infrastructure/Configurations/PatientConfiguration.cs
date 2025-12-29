using eAppointmentServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Infrastructure.Configurations;

internal class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.Property(p => p.FirstName).HasColumnType("nvarchar(50)");
        builder.Property(p => p.LastName).HasColumnType("nvarchar(50)");
        builder.Property(p => p.City).HasColumnType("nvarchar(50)");
        builder.Property(p => p.Town).HasColumnType("nvarchar(50)");
        builder.Property(p => p.FullAddress).HasColumnType("nvarchar(400)");
        builder.Property(p => p.IdentityNumber).HasColumnType("nvarchar(11)");
        builder.HasIndex(x => x.IdentityNumber).IsUnique(true); // aynı tc kimlik numarasından eklenmesini engeller
    }
}


