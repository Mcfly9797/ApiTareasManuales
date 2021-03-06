﻿// <auto-generated />
using System;
using ApiTareasManuales.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiTareasManuales.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20201130233655_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ApiTareasManuales.Models.Disenio", b =>
                {
                    b.Property<int>("IdDisenio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreDisenio")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdDisenio");

                    b.ToTable("Disenio");
                });

            modelBuilder.Entity("ApiTareasManuales.Models.Elemento", b =>
                {
                    b.Property<int>("IdElemento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreElemento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdElemento");

                    b.ToTable("Elemento");
                });

            modelBuilder.Entity("ApiTareasManuales.Models.Medida", b =>
                {
                    b.Property<int>("IdMedida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreMedida")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdMedida");

                    b.ToTable("Medida");
                });

            modelBuilder.Entity("ApiTareasManuales.Models.Tarea", b =>
                {
                    b.Property<int>("IdTarea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Detalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisenioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Duracion")
                        .HasColumnType("datetime2");

                    b.Property<int>("ElementoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedidaId")
                        .HasColumnType("int");

                    b.Property<int>("NroSerie")
                        .HasColumnType("int");

                    b.Property<int>("Tipo_TrabajoId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("IdTarea");

                    b.HasIndex("DisenioId");

                    b.HasIndex("ElementoId");

                    b.HasIndex("MedidaId");

                    b.HasIndex("Tipo_TrabajoId");

                    b.HasIndex("UserId");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("ApiTareasManuales.Models.Tipo_Trabajo", b =>
                {
                    b.Property<int>("IdTipoTrabajo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreTipoTrabajo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdTipoTrabajo");

                    b.ToTable("Tipo_Trabajo");
                });

            modelBuilder.Entity("ApiTareasManuales.Models.Tipo_User", b =>
                {
                    b.Property<int>("IdTipoUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreTipoUser")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TipoUser")
                        .HasColumnType("int");

                    b.HasKey("IdTipoUser");

                    b.ToTable("Tipo_User");
                });

            modelBuilder.Entity("ApiTareasManuales.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NombreUser")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Tipo_UserId")
                        .HasColumnType("int");

                    b.HasKey("IdUser");

                    b.HasIndex("Tipo_UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ApiTareasManuales.Models.Tarea", b =>
                {
                    b.HasOne("ApiTareasManuales.Models.Disenio", "Disenio")
                        .WithMany()
                        .HasForeignKey("DisenioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiTareasManuales.Models.Elemento", "Elemento")
                        .WithMany()
                        .HasForeignKey("ElementoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiTareasManuales.Models.Medida", "Medida")
                        .WithMany()
                        .HasForeignKey("MedidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiTareasManuales.Models.Tipo_Trabajo", "Tipo_Trabajo")
                        .WithMany()
                        .HasForeignKey("Tipo_TrabajoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiTareasManuales.Models.User", "Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disenio");

                    b.Navigation("Elemento");

                    b.Navigation("Medida");

                    b.Navigation("Tipo_Trabajo");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ApiTareasManuales.Models.User", b =>
                {
                    b.HasOne("ApiTareasManuales.Models.Tipo_User", "Tipo_User")
                        .WithMany()
                        .HasForeignKey("Tipo_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo_User");
                });
#pragma warning restore 612, 618
        }
    }
}
