using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using OSPeConTI.SumariosIERIC.Domain.Enums;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;

namespace OSPeConTI.SumariosIERIC.Infrastructure.EntityConfigurations
{
    class ActaEntityTypeConfiguration : IEntityTypeConfiguration<Acta>
    {
        public void Configure(EntityTypeBuilder<Acta> actaConfiguration)
        {
            actaConfiguration.ToTable("Actas", SumariosContext.DEFAULT_SCHEMA);

            actaConfiguration.HasKey(o => o.Id);

            actaConfiguration.Ignore(b => b.DomainEvents);

            actaConfiguration.OwnsOne(p => p.Domicilio).Property(p => p.Numero).HasColumnType("nvarchar(max)").HasColumnName("DomicilioNumero");
            actaConfiguration.OwnsOne(p => p.Domicilio).Property(p => p.Calle).HasColumnType("nvarchar(max)").HasColumnName("DomicilioCalle");
            actaConfiguration.OwnsOne(p => p.Domicilio).Property(p => p.Barrio).HasColumnType("nvarchar(max)").HasColumnName("DomicilioBarrio");
            actaConfiguration.OwnsOne(p => p.Domicilio).Property(p => p.Localidad).HasColumnType("nvarchar(max)").HasColumnName("DomicilioLocalidad");
            actaConfiguration.OwnsOne(p => p.Domicilio).Property(p => p.Provincia).HasColumnType("nvarchar(max)").HasColumnName("DomicilioProvincia");
            actaConfiguration.OwnsOne(p => p.Domicilio).Property(p => p.CodigoPostal).HasColumnType("nvarchar(max)").HasColumnName("DomicilioCodigoPostal");
            actaConfiguration.OwnsOne(p => p.Domicilio).Property(p => p.Pais).HasColumnType("nvarchar(max)").HasColumnName("DomicilioPais");



        }
    }
}