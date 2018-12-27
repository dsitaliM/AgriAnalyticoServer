﻿// <auto-generated />
using System;
using AgriAnalyticoServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgriAnalyticoServer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181227062759_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgriAnalyticoServer.Models.Crop", b =>
                {
                    b.Property<Guid>("CropId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("AlkalinityHigh");

                    b.Property<float>("AlkalinityLow");

                    b.Property<float>("MADEstablishment");

                    b.Property<float>("MADFlowering");

                    b.Property<float>("MADMature");

                    b.Property<float>("MADVegetative");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<float>("RootDepthHigh");

                    b.Property<float>("RootDepthLow");

                    b.HasKey("CropId");

                    b.ToTable("Crops");
                });

            modelBuilder.Entity("AgriAnalyticoServer.Models.Soil", b =>
                {
                    b.Property<Guid>("SoilId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("FieldCapacity");

                    b.Property<float>("PermanentWiltingPoint");

                    b.Property<float>("TotalAvailableWater");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("SoilId");

                    b.ToTable("Soils");
                });
#pragma warning restore 612, 618
        }
    }
}