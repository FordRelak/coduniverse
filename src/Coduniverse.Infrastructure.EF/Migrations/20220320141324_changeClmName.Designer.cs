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
    [Migration("20220320141324_changeClmName")]
    partial class changeClmName
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

                    b.Property<Guid?>("CenterMassId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("StarSystemId")
                        .HasColumnType("uuid");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CenterMassId")
                        .IsUnique();

                    b.HasIndex("StarSystemId");

                    b.ToTable("spaceObjects", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                            Age = 1354260757,
                            CenterMassId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Solar",
                            StarSystemId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Type = 0,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                            Age = 335610706,
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Mercury",
                            StarSystemId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Type = 2,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                            Age = 97520950,
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Venus",
                            StarSystemId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Type = 2,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                            Age = 1446297225,
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Earth",
                            StarSystemId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Type = 2,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"),
                            Age = 1734789560,
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Mars",
                            StarSystemId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Type = 2,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                            Age = 1932341752,
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Jupiter",
                            StarSystemId = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Type = 2,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("Coduniverse.Domain.StarSystem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<Guid>("CenterMassId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("starSystems", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                            Age = 341353665,
                            CenterMassId = new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Solar system",
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("Coduniverse.Domain.SpaceObject", b =>
                {
                    b.HasOne("Coduniverse.Domain.StarSystem", null)
                        .WithOne("CenterMass")
                        .HasForeignKey("Coduniverse.Domain.SpaceObject", "CenterMassId");

                    b.HasOne("Coduniverse.Domain.StarSystem", "StarSystem")
                        .WithMany("SpaceObjects")
                        .HasForeignKey("StarSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StarSystem");
                });

            modelBuilder.Entity("Coduniverse.Domain.StarSystem", b =>
                {
                    b.Navigation("CenterMass");

                    b.Navigation("SpaceObjects");
                });
#pragma warning restore 612, 618
        }
    }
}