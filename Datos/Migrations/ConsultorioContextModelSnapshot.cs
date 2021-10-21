﻿// <auto-generated />
using System;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(ConsultorioContext))]
    partial class ConsultorioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entidad.Cita", b =>
                {
                    b.Property<int>("idCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("fechaDeseada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaVencimientoAutorizacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("idPaciente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroAutorizacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pacienteidentificacion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("telefonoContacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tiposSolicitud")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCita");

                    b.HasIndex("pacienteidentificacion");

                    b.ToTable("citas");
                });

            modelBuilder.Entity("Entidad.Paciente", b =>
                {
                    b.Property<string>("identificacion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Eps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("identificacion");

                    b.ToTable("pacientes");
                });

            modelBuilder.Entity("Entidad.Cita", b =>
                {
                    b.HasOne("Entidad.Paciente", "paciente")
                        .WithMany("citas")
                        .HasForeignKey("pacienteidentificacion");
                });
#pragma warning restore 612, 618
        }
    }
}
