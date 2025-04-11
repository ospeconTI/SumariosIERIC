using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;

namespace OSPeConTI.SumariosIERIC.Infrastructure.EntityConfigurations
{
    class InspectorEntityTypeConfiguration : IEntityTypeConfiguration<Inspector>
    {
        public void Configure(EntityTypeBuilder<Inspector> InspectorConfiguration)
        {
            InspectorConfiguration.ToTable("Inspector", SumariosContext.DEFAULT_SCHEMA);

            InspectorConfiguration.HasKey(o => o.Id);

            InspectorConfiguration.Ignore(b => b.DomainEvents);

        }
    }
}