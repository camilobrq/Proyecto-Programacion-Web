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

                    b.Property<string>("idPaciente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pacienteidentificacion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("tiposSolicitud")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCita");

                    b.HasIndex("pacienteidentificacion");

                    b.ToTable("citas");
                });

            modelBuilder.Entity("Entidad.Evaluacion", b =>
                {
                    b.Property<int>("IdEvaluacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Psicologoidentificacion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("identificacionPaciente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("identificacionPsicologo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pacienteidentificacion")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdEvaluacion");

                    b.HasIndex("Psicologoidentificacion");

                    b.HasIndex("pacienteidentificacion");

                    b.ToTable("evaluaciones");
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

            modelBuilder.Entity("Entidad.Psicologo", b =>
                {
                    b.Property<string>("identificacion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Universidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("areaEspecializada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<string>("fechaFinalizacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mesesExperiencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("identificacion");

                    b.ToTable("psicologos");
                });

            modelBuilder.Entity("Entidad.Tratamiento", b =>
                {
                    b.Property<int>("IdTratamiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Psicologoidentificacion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("identificacionPaciente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("identificacionPsicologo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pacienteidentificacion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("tratamientoPaso")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTratamiento");

                    b.HasIndex("Psicologoidentificacion");

                    b.HasIndex("pacienteidentificacion");

                    b.ToTable("tratamientos");
                });

            modelBuilder.Entity("Entidad.Cita", b =>
                {
                    b.HasOne("Entidad.Paciente", "paciente")
                        .WithMany("citas")
                        .HasForeignKey("pacienteidentificacion");
                });

            modelBuilder.Entity("Entidad.Evaluacion", b =>
                {
                    b.HasOne("Entidad.Psicologo", "Psicologo")
                        .WithMany("evaluaciones")
                        .HasForeignKey("Psicologoidentificacion");

                    b.HasOne("Entidad.Paciente", "paciente")
                        .WithMany()
                        .HasForeignKey("pacienteidentificacion");
                });

            modelBuilder.Entity("Entidad.Tratamiento", b =>
                {
                    b.HasOne("Entidad.Psicologo", "Psicologo")
                        .WithMany()
                        .HasForeignKey("Psicologoidentificacion");

                    b.HasOne("Entidad.Paciente", "paciente")
                        .WithMany()
                        .HasForeignKey("pacienteidentificacion");
                });
#pragma warning restore 612, 618
        }
    }
}
