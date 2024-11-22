﻿// <auto-generated />
using System;
using Autos.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Autos.Repository.Migrations
{
    [DbContext(typeof(AutosMarcasDbContext))]
    partial class AutosMarcasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "uuid-ossp");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Autos.Repository.Models.MarcasAuto", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int>("Anno")
                        .HasColumnType("integer");

                    b.Property<string>("Color")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Marca")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Modelo")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Serial")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MarcasAutos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("395f18a0-fa4f-4731-8eb6-75954189499a"),
                            Anno = 2021,
                            Color = "Rojo",
                            IsActive = true,
                            Marca = "Toyota",
                            Modelo = "Corolla",
                            Serial = "1234567890"
                        },
                        new
                        {
                            Id = new Guid("5a1e6b51-09cc-4d59-8f57-7a5fee10de08"),
                            Anno = 2024,
                            Color = "Azul",
                            IsActive = true,
                            Marca = "Toyota",
                            Modelo = "Camry",
                            Serial = "1234567891"
                        },
                        new
                        {
                            Id = new Guid("ccaa5951-e864-40e1-b801-a41e1470dff5"),
                            Anno = 2024,
                            Color = "Blanco",
                            IsActive = true,
                            Marca = "Toyota",
                            Modelo = "Rav4",
                            Serial = "1234567892"
                        },
                        new
                        {
                            Id = new Guid("d8b86b65-7e9c-4046-a21e-b57eb47e2fba"),
                            Anno = 2025,
                            Color = "Blanco",
                            IsActive = true,
                            Marca = "Ford",
                            Modelo = "Raptor",
                            Serial = "1234567892"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
