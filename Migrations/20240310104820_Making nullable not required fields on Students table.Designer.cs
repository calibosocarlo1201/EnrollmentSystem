﻿// <auto-generated />
using System;
using EnrollmentSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnrollmentSystem.Migrations
{
    [DbContext(typeof(EnrollmentContext))]
    [Migration("20240310104820_Making nullable not required fields on Students table")]
    partial class MakingnullablenotrequiredfieldsonStudentstable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EnrollmentSystem.Models.Entities.StudentSubjects", b =>
                {
                    b.Property<Guid>("StudentSubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentSubjectID");

                    b.HasIndex("StudentID");

                    b.HasIndex("SubjectID");

                    b.ToTable("StudentSubjects");
                });

            modelBuilder.Entity("EnrollmentSystem.Models.Entities.Students", b =>
                {
                    b.Property<Guid>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentLevel")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EnrollmentSystem.Models.Entities.Subjects", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("SubjectCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("EnrollmentSystem.Models.Entities.StudentSubjects", b =>
                {
                    b.HasOne("EnrollmentSystem.Models.Entities.Students", "Students")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnrollmentSystem.Models.Entities.Subjects", "Subjects")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Students");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("EnrollmentSystem.Models.Entities.Students", b =>
                {
                    b.Navigation("StudentSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
