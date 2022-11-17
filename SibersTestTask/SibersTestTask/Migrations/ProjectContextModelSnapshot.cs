﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SibersTestTask.Data;

#nullable disable

namespace SibersTestTask.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SibersTestTask.Models.Employee", b =>
                {
                    b.Property<int>("IdEmployee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmployee"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEmployee");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("SibersTestTask.Models.Leader", b =>
                {
                    b.Property<int>("IdLeadProject")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLeadProject"));

                    b.Property<int?>("EmployeeIdEmployee")
                        .HasColumnType("int");

                    b.Property<int>("IdEmployee")
                        .HasColumnType("int");

                    b.HasKey("IdLeadProject");

                    b.HasIndex("EmployeeIdEmployee");

                    b.ToTable("Leader", (string)null);
                });

            modelBuilder.Entity("SibersTestTask.Models.Project", b =>
                {
                    b.Property<int>("IdProject")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProject"));

                    b.Property<int>("IdLeadProject")
                        .HasColumnType("int");

                    b.Property<int?>("LeaderIdLeadProject")
                        .HasColumnType("int");

                    b.Property<string>("NameClientCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameContractorCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameProject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdProject");

                    b.HasIndex("LeaderIdLeadProject");

                    b.ToTable("Project", (string)null);
                });

            modelBuilder.Entity("SibersTestTask.Models.Leader", b =>
                {
                    b.HasOne("SibersTestTask.Models.Employee", "Employee")
                        .WithMany("Leaders")
                        .HasForeignKey("EmployeeIdEmployee");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("SibersTestTask.Models.Project", b =>
                {
                    b.HasOne("SibersTestTask.Models.Leader", "Leader")
                        .WithMany("Projects")
                        .HasForeignKey("LeaderIdLeadProject");

                    b.Navigation("Leader");
                });

            modelBuilder.Entity("SibersTestTask.Models.Employee", b =>
                {
                    b.Navigation("Leaders");
                });

            modelBuilder.Entity("SibersTestTask.Models.Leader", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
