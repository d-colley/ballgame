﻿// <auto-generated />
using System;
using BallGameMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BallGameMVC.Migrations
{
    [DbContext(typeof(BallGameDBContext))]
    partial class BallGameDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BallGameMVC.Models.Environ", b =>
                {
                    b.Property<int>("EnvID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnvLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EnvRegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnvTurfType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnvID");

                    b.ToTable("Environ");
                });

            modelBuilder.Entity("BallGameMVC.Models.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerRassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PlayerID");

                    b.ToTable("Player");
                });
#pragma warning restore 612, 618
        }
    }
}
