﻿// <auto-generated />
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment1.Migrations.Technician
{
    [DbContext(typeof(TechnicianContext))]
    [Migration("20210212023518_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment1.Models.Technician", b =>
                {
                    b.Property<string>("techName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("techEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("techPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("techName");

                    b.ToTable("Technicians");

                    b.HasData(
                        new
                        {
                            techName = "Roman",
                            techEmail = "Computer@gmail.com",
                            techPhone = "416-258-6757"
                        },
                        new
                        {
                            techName = "Miranda",
                            techEmail = "Computer@gmail.com",
                            techPhone = "416-258-6757"
                        },
                        new
                        {
                            techName = "Mike",
                            techEmail = "Computer@gmail.com",
                            techPhone = "416-258-6757"
                        },
                        new
                        {
                            techName = "Jake",
                            techEmail = "Computer@gmail.com",
                            techPhone = "416-258-6757"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
