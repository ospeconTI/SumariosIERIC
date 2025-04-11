﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSPeConTI.SumariosIERIC.Infrastructure;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(SumariosContext))]
    partial class SumariosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OSPeConTI.SumariosIERIC.Domain.Entities.Empresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<long?>("Cuit")
                        .HasColumnType("bigint");

                    b.Property<bool>("EsCooperativa")
                        .HasColumnType("bit");

                    b.Property<bool>("EstadoActivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LegacyId")
                        .HasColumnType("int");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioAlta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresa", "dbo");
                });

            modelBuilder.Entity("OSPeConTI.SumariosIERIC.Domain.Entities.Inspector", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoIERIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LegacyId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioAlta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Inspectores");
                });
#pragma warning restore 612, 618
        }
    }
}
