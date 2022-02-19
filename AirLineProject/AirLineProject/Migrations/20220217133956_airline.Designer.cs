﻿// <auto-generated />
using System;
using AirLineProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirLineProject.Migrations
{
    [DbContext(typeof(AirLineContext))]
    [Migration("20220217133956_airline")]
    partial class airline
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("AirLineProject.Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("AirLineProject.AirCraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AircraftName")
                        .HasColumnType("text");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("text");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AirCrafts");
                });

            modelBuilder.Entity("AirLineProject.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime");

                    b.Property<string>("BookingReference")
                        .HasColumnType("text");

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.HasIndex("PassengerId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("AirLineProject.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AirCraftId")
                        .HasColumnType("int");

                    b.Property<int>("AvailableSit")
                        .HasColumnType("int");

                    b.Property<int>("FlightTypes")
                        .HasColumnType("int");

                    b.Property<int>("LandingPoint")
                        .HasColumnType("int");

                    b.Property<DateTime>("LandingTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("TakeOfPoint")
                        .HasColumnType("int");

                    b.Property<DateTime>("TakeOffTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("AirCraftId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("AirLineProject.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("PassengerFirstName")
                        .HasColumnType("text");

                    b.Property<string>("PassengerLastName")
                        .HasColumnType("text");

                    b.Property<string>("PassengerPersonalId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("AirLineProject.Booking", b =>
                {
                    b.HasOne("AirLineProject.Flight", "Flight")
                        .WithMany("Bookings")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirLineProject.Passenger", "Passenger")
                        .WithMany()
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("AirLineProject.Flight", b =>
                {
                    b.HasOne("AirLineProject.AirCraft", "AirCraft")
                        .WithMany("flight")
                        .HasForeignKey("AirCraftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirCraft");
                });

            modelBuilder.Entity("AirLineProject.AirCraft", b =>
                {
                    b.Navigation("flight");
                });

            modelBuilder.Entity("AirLineProject.Flight", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
