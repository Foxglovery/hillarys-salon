﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HillarysSalon.Migrations
{
    [DbContext(typeof(HillarysSalonDbContext))]
    partial class HillarysSalonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HillarysSalon.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ScheduledFor")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("StylistId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StylistId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 3,
                            ScheduledFor = new DateTime(2024, 1, 15, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 2
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 6,
                            ScheduledFor = new DateTime(2024, 1, 16, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 1
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 4,
                            ScheduledFor = new DateTime(2024, 1, 15, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 3
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 7,
                            ScheduledFor = new DateTime(2024, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 2
                        },
                        new
                        {
                            Id = 5,
                            CustomerId = 8,
                            ScheduledFor = new DateTime(2024, 1, 17, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StylistId = 5
                        });
                });

            modelBuilder.Entity("HillarysSalon.Models.AppointmentService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("ServiceId");

                    b.ToTable("AppointmentServices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppointmentId = 1,
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 2,
                            AppointmentId = 1,
                            ServiceId = 5
                        },
                        new
                        {
                            Id = 3,
                            AppointmentId = 1,
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 4,
                            AppointmentId = 2,
                            ServiceId = 6
                        },
                        new
                        {
                            Id = 5,
                            AppointmentId = 2,
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 6,
                            AppointmentId = 3,
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 7,
                            AppointmentId = 4,
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 8,
                            AppointmentId = 4,
                            ServiceId = 7
                        },
                        new
                        {
                            Id = 9,
                            AppointmentId = 4,
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 10,
                            AppointmentId = 5,
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 11,
                            AppointmentId = 5,
                            ServiceId = 8
                        });
                });

            modelBuilder.Entity("HillarysSalon.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Elmira",
                            LastName = "Bick"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Florence",
                            LastName = "Tarly"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Agrippa",
                            LastName = "Shorely"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Pithany",
                            LastName = "Goosename"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Loril",
                            LastName = "Descot"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Jenjamin",
                            LastName = "Oranis"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Flisha",
                            LastName = "Purl"
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Karrigan",
                            LastName = "Nothal"
                        });
                });

            modelBuilder.Entity("HillarysSalon.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tik-Tok Blowout",
                            Price = 60m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Quantum Waxing",
                            Price = 80m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mecha-Bikini Optimization",
                            Price = 360m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hot Noodle Massage",
                            Price = 30m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Bang-Maker 3000",
                            Price = 60m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Chinstrap Removal",
                            Price = 5m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Krimp-It-Till-It-Dies",
                            Price = 100m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Wig Snatch N Release",
                            Price = 90m
                        });
                });

            modelBuilder.Entity("HillarysSalon.Models.Stylist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Stylists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Groogery",
                            LastName = "Adlerburb",
                            isActive = true
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Schlebethany",
                            LastName = "Jerp",
                            isActive = true
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Jeef",
                            LastName = "Dagsroll",
                            isActive = true
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Arlington",
                            LastName = "Corlingping",
                            isActive = false
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Fash",
                            LastName = "Brippy",
                            isActive = true
                        });
                });

            modelBuilder.Entity("HillarysSalon.Models.Appointment", b =>
                {
                    b.HasOne("HillarysSalon.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HillarysSalon.Models.Stylist", "Stylist")
                        .WithMany()
                        .HasForeignKey("StylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Stylist");
                });

            modelBuilder.Entity("HillarysSalon.Models.AppointmentService", b =>
                {
                    b.HasOne("HillarysSalon.Models.Appointment", "Appointment")
                        .WithMany("AppointmentServices")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HillarysSalon.Models.Service", "Service")
                        .WithMany("AppointmentServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("HillarysSalon.Models.Appointment", b =>
                {
                    b.Navigation("AppointmentServices");
                });

            modelBuilder.Entity("HillarysSalon.Models.Service", b =>
                {
                    b.Navigation("AppointmentServices");
                });
#pragma warning restore 612, 618
        }
    }
}
