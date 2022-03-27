﻿// <auto-generated />
using System;
using Coduniverse.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Coduniverse.Infrastructure.EF.Migrations
{
    [DbContext(typeof(EfDbContext))]
    [Migration("20220327193354_MakeFieldNullable")]
    partial class MakeFieldNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Coduniverse.Domain.SpaceObject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Diameter")
                        .HasColumnType("integer");

                    b.Property<int>("Mass")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("StarSystemId")
                        .HasColumnType("uuid");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("StarSystemId");

                    b.ToTable("spaceObjects", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                            Age = 878003394,
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)),
                            Diameter = 2133188207,
                            Mass = 1459312810,
                            Name = "Solar",
                            StarSystemId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Type = 0,
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                            Age = 1822579592,
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)),
                            Diameter = 597384204,
                            Mass = 1630710593,
                            Name = "Mercury",
                            StarSystemId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Type = 2,
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                            Age = 1413864703,
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)),
                            Diameter = 1132467835,
                            Mass = 1132243811,
                            Name = "Venus",
                            StarSystemId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Type = 2,
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                            Age = 2137212187,
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)),
                            Diameter = 249094810,
                            Mass = 333584233,
                            Name = "Earth",
                            StarSystemId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Type = 2,
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"),
                            Age = 1069863656,
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)),
                            Diameter = 1168253704,
                            Mass = 882427276,
                            Name = "Mars",
                            StarSystemId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Type = 2,
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                            Age = 1249692303,
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)),
                            Diameter = 924356266,
                            Mass = 1089360360,
                            Name = "Jupiter",
                            StarSystemId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Type = 2,
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("Coduniverse.Domain.StarSystem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<Guid?>("CenterMassId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CenterMassId");

                    b.ToTable("starSystems", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Age = 928212946,
                            CenterMassId = new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Solar system",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("Coduniverse.Domain.SpaceObject", b =>
                {
                    b.HasOne("Coduniverse.Domain.StarSystem", "StarSystem")
                        .WithMany("SpaceObjects")
                        .HasForeignKey("StarSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StarSystem");
                });

            modelBuilder.Entity("Coduniverse.Domain.StarSystem", b =>
                {
                    b.HasOne("Coduniverse.Domain.SpaceObject", "CenterMass")
                        .WithMany()
                        .HasForeignKey("CenterMassId");

                    b.Navigation("CenterMass");
                });

            modelBuilder.Entity("Coduniverse.Domain.StarSystem", b =>
                {
                    b.Navigation("SpaceObjects");
                });
#pragma warning restore 612, 618
        }
    }
}
