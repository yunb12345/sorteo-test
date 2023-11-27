﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sorteo.Data.Context;

namespace Sorteo.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231124190014_DetalleSorteo")]
    partial class DetalleSorteo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sorteo.Data.DetalleSorteo", b =>
                {
                    b.Property<int>("DetalleSorteoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParticipanteId")
                        .HasColumnType("int");

                    b.HasKey("DetalleSorteoId");

                    b.HasIndex("ParticipanteId");

                    b.ToTable("DetaalleSorteos");
                });

            modelBuilder.Entity("Sorteo.Data.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoPostal")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("Sorteo.Data.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("Sorteo.Data.Participante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DireccionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DireccionId");

                    b.ToTable("Participantes");
                });

            modelBuilder.Entity("Sorteo.Data.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("Sorteo.Data.Sorteo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sorteos");
                });

            modelBuilder.Entity("Sorteo.Data.SorteoParticipante", b =>
                {
                    b.Property<int>("SorteoParticipanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DetalleSorteoId")
                        .HasColumnType("int");

                    b.Property<int>("SorteoId")
                        .HasColumnType("int");

                    b.HasKey("SorteoParticipanteId");

                    b.HasIndex("DetalleSorteoId");

                    b.HasIndex("SorteoId");

                    b.ToTable("SorteoParticipantes");
                });

            modelBuilder.Entity("Sorteo.Data.DetalleSorteo", b =>
                {
                    b.HasOne("Sorteo.Data.Participante", "Participante")
                        .WithMany()
                        .HasForeignKey("ParticipanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participante");
                });

            modelBuilder.Entity("Sorteo.Data.Direccion", b =>
                {
                    b.HasOne("Sorteo.Data.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sorteo.Data.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("Sorteo.Data.Participante", b =>
                {
                    b.HasOne("Sorteo.Data.Direccion", "Direccion")
                        .WithMany()
                        .HasForeignKey("DireccionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direccion");
                });

            modelBuilder.Entity("Sorteo.Data.SorteoParticipante", b =>
                {
                    b.HasOne("Sorteo.Data.DetalleSorteo", "DetalleSorteo")
                        .WithMany()
                        .HasForeignKey("DetalleSorteoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sorteo.Data.Sorteo", "Sorteo")
                        .WithMany()
                        .HasForeignKey("SorteoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetalleSorteo");

                    b.Navigation("Sorteo");
                });
#pragma warning restore 612, 618
        }
    }
}
