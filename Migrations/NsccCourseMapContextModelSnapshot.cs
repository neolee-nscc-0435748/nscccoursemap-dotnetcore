﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NsccCourseMap.Data;

namespace NsccCourseMap_Neo.Migrations
{
    [DbContext(typeof(NsccCourseMapContext))]
    partial class NsccCourseMapContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("NsccCourseMap.Models.AcademicYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Title")
                        .HasName("AlternateKey_AcademicYear_Title");

                    b.ToTable("AcademicYears");
                });

            modelBuilder.Entity("NsccCourseMap.Models.AdvisingAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DiplomaProgramYearSectionId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiplomaProgramYearSectionId");

                    b.HasIndex("InstructorId", "DiplomaProgramYearSectionId")
                        .IsUnique();

                    b.ToTable("AdvisingAssignments");
                });

            modelBuilder.Entity("NsccCourseMap.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasAlternateKey("CourseCode")
                        .HasName("AlternateKey_Course_CourseCode");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("NsccCourseMap.Models.CourseOffering", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("DiplomaProgramYearSectionId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDirectedElective")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiplomaProgramYearSectionId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("CourseId", "InstructorId", "DiplomaProgramYearSectionId", "SemesterId")
                        .IsUnique();

                    b.ToTable("CourseOfferings");
                });

            modelBuilder.Entity("NsccCourseMap.Models.CoursePrerequisite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("PrerequisiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrerequisiteId");

                    b.HasIndex("CourseId", "PrerequisiteId")
                        .IsUnique();

                    b.ToTable("CoursePrerequisites");
                });

            modelBuilder.Entity("NsccCourseMap.Models.DiplomaProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Title")
                        .HasName("AlternateKey_DiplomaProgram_Title");

                    b.ToTable("DiplomaPrograms");
                });

            modelBuilder.Entity("NsccCourseMap.Models.DiplomaProgramYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DiplomaProgramId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("DiplomaProgramId");

                    b.HasIndex("Title", "DiplomaProgramId")
                        .IsUnique();

                    b.ToTable("DiplomaProgramYears");
                });

            modelBuilder.Entity("NsccCourseMap.Models.DiplomaProgramYearSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AcademicYearId")
                        .HasColumnType("int");

                    b.Property<int>("DiplomaProgramYearId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AcademicYearId");

                    b.HasIndex("DiplomaProgramYearId");

                    b.HasIndex("Title", "DiplomaProgramYearId", "AcademicYearId")
                        .IsUnique();

                    b.ToTable("DiplomaProgramYearSections");
                });

            modelBuilder.Entity("NsccCourseMap.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("NsccCourseMap.Models.Semester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AcademicYearId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("Date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name")
                        .HasName("AlternateKey_Semester_Name");

                    b.HasIndex("AcademicYearId");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("NsccCourseMap.Models.AdvisingAssignment", b =>
                {
                    b.HasOne("NsccCourseMap.Models.DiplomaProgramYearSection", "DiplomaProgramYearSection")
                        .WithMany("AdvisingAssignments")
                        .HasForeignKey("DiplomaProgramYearSectionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NsccCourseMap.Models.Instructor", "Instructor")
                        .WithMany("AdvisingAssignments")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DiplomaProgramYearSection");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("NsccCourseMap.Models.CourseOffering", b =>
                {
                    b.HasOne("NsccCourseMap.Models.Course", "Course")
                        .WithMany("CourseOfferings")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NsccCourseMap.Models.DiplomaProgramYearSection", "DiplomaProgramYearSection")
                        .WithMany("CourseOfferings")
                        .HasForeignKey("DiplomaProgramYearSectionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NsccCourseMap.Models.Instructor", "Instructor")
                        .WithMany("CourseOfferings")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NsccCourseMap.Models.Semester", "Semester")
                        .WithMany("CourseOfferings")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("DiplomaProgramYearSection");

                    b.Navigation("Instructor");

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("NsccCourseMap.Models.CoursePrerequisite", b =>
                {
                    b.HasOne("NsccCourseMap.Models.Course", "Course")
                        .WithMany("Prerequisites")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NsccCourseMap.Models.Course", "Prerequisite")
                        .WithMany("IsPrerequisiteFor")
                        .HasForeignKey("PrerequisiteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Prerequisite");
                });

            modelBuilder.Entity("NsccCourseMap.Models.DiplomaProgramYear", b =>
                {
                    b.HasOne("NsccCourseMap.Models.DiplomaProgram", "DiplomaProgram")
                        .WithMany("DiplomaProgramYears")
                        .HasForeignKey("DiplomaProgramId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DiplomaProgram");
                });

            modelBuilder.Entity("NsccCourseMap.Models.DiplomaProgramYearSection", b =>
                {
                    b.HasOne("NsccCourseMap.Models.AcademicYear", "AcademicYear")
                        .WithMany("DiplomaProgramYearSections")
                        .HasForeignKey("AcademicYearId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NsccCourseMap.Models.DiplomaProgramYear", "DiplomaProgramYear")
                        .WithMany("DiplomaProgramYearSections")
                        .HasForeignKey("DiplomaProgramYearId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AcademicYear");

                    b.Navigation("DiplomaProgramYear");
                });

            modelBuilder.Entity("NsccCourseMap.Models.Semester", b =>
                {
                    b.HasOne("NsccCourseMap.Models.AcademicYear", "AcademicYear")
                        .WithMany("Semesters")
                        .HasForeignKey("AcademicYearId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AcademicYear");
                });

            modelBuilder.Entity("NsccCourseMap.Models.AcademicYear", b =>
                {
                    b.Navigation("DiplomaProgramYearSections");

                    b.Navigation("Semesters");
                });

            modelBuilder.Entity("NsccCourseMap.Models.Course", b =>
                {
                    b.Navigation("CourseOfferings");

                    b.Navigation("IsPrerequisiteFor");

                    b.Navigation("Prerequisites");
                });

            modelBuilder.Entity("NsccCourseMap.Models.DiplomaProgram", b =>
                {
                    b.Navigation("DiplomaProgramYears");
                });

            modelBuilder.Entity("NsccCourseMap.Models.DiplomaProgramYear", b =>
                {
                    b.Navigation("DiplomaProgramYearSections");
                });

            modelBuilder.Entity("NsccCourseMap.Models.DiplomaProgramYearSection", b =>
                {
                    b.Navigation("AdvisingAssignments");

                    b.Navigation("CourseOfferings");
                });

            modelBuilder.Entity("NsccCourseMap.Models.Instructor", b =>
                {
                    b.Navigation("AdvisingAssignments");

                    b.Navigation("CourseOfferings");
                });

            modelBuilder.Entity("NsccCourseMap.Models.Semester", b =>
                {
                    b.Navigation("CourseOfferings");
                });
#pragma warning restore 612, 618
        }
    }
}
