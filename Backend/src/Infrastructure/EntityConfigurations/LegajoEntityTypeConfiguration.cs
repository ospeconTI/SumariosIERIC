using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using OSPeConTI.SumariosIERIC.Domain.Enums;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;

namespace OSPeConTI.SumariosIERIC.Infrastructure.EntityConfigurations
{
    class LegajoEntityTypeConfiguration : IEntityTypeConfiguration<Legajo>
    {
        public void Configure(EntityTypeBuilder<Legajo> LegajoConfiguration)
        {
            LegajoConfiguration.ToTable("Legajos", SumariosContext.DEFAULT_SCHEMA);

            LegajoConfiguration.HasKey(o => o.Id);

            LegajoConfiguration.Ignore(b => b.DomainEvents);

            var converter = new ValueConverter<Cuit, Int64>(from => from, to => (Cuit)to);
            LegajoConfiguration.Property(p => p.CUIT).HasConversion(converter).HasColumnType("bigint");

            var converter2 = new ValueConverter<Estado, string>(from => from.Nombre, to => Estado.FromName(to));
            LegajoConfiguration.Property(p => p.Estado).HasConversion(converter2).HasColumnType("varchar").HasPrecision(100);

        }
    }
}