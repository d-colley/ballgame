﻿// <auto-generated />
using BallGame.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BallGame.Migrations
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

            modelBuilder.Entity("BallGame.Model.Environ", b =>
                {
                    b.Property<string>("EnvID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EnvLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvTurfType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnvID");

                    b.ToTable("Environs");
                });

            modelBuilder.Entity("BallGame.Model.Player", b =>
                {
                    b.Property<string>("PlayerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerRassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerID");

                    b.ToTable("Players");
                });
#pragma warning restore 612, 618
        }
    }
}