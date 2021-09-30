﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaludIntegral.App.Persistencia;

namespace SaludIntegral.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SaludIntegral.App.Dominio.Cities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name_City")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("SaludIntegral.App.Dominio.Locations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name_Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Sedes");
                });

            modelBuilder.Entity("SaludIntegral.App.Dominio.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Names")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("SaludIntegral.App.Dominio.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("MedicId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("MedicId");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("SaludIntegral.App.Dominio.Medic", b =>
                {
                    b.HasBaseType("SaludIntegral.App.Dominio.Person");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Medic");
                });

            modelBuilder.Entity("SaludIntegral.App.Dominio.Patient", b =>
                {
                    b.HasBaseType("SaludIntegral.App.Dominio.Person");

                    b.Property<string>("EPS")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Patient");
                });

            modelBuilder.Entity("SaludIntegral.App.Dominio.Locations", b =>
                {
                    b.HasOne("SaludIntegral.App.Dominio.Cities", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("SaludIntegral.App.Dominio.Person", b =>
                {
                    b.HasOne("SaludIntegral.App.Dominio.Locations", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("SaludIntegral.App.Dominio.Schedule", b =>
                {
                    b.HasOne("SaludIntegral.App.Dominio.Locations", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("SaludIntegral.App.Dominio.Medic", "Medic")
                        .WithMany()
                        .HasForeignKey("MedicId");

                    b.Navigation("Location");

                    b.Navigation("Medic");
                });
#pragma warning restore 612, 618
        }
    }
}