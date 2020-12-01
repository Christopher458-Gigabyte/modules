﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using modules.Data;

namespace modules.Migrations
{
    [DbContext(typeof(modulesContext))]
    partial class modulesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("modules.Pages.Models.Module", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Curriculare_Zuordnung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inhaltliche_Beschreibung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Leistungspunkte")
                        .HasColumnType("int");

                    b.Property<string>("Lernziele")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Literaturangaben")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modulname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Modulnummer")
                        .HasColumnType("int");

                    b.Property<string>("Prüfungsart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prüfungsform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Schlüsselqualifikationen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<int>("Semesterwochenstunden")
                        .HasColumnType("int");

                    b.Property<string>("Turnus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unterrichtsform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Verbindlichkeit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Workload")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Module");
                });
#pragma warning restore 612, 618
        }
    }
}
