﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apibackend.Dates;

#nullable disable

namespace apibackend.Migrations
{
    [DbContext(typeof(UniversityDb))]
    [Migration("20221102194618_lsfnfn")]
    partial class lsfnfn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("apibackend.Models.DataModels.BaseEntity", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("baseEntities");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseEntity");
                });

            modelBuilder.Entity("CategoryCurso", b =>
                {
                    b.Property<int>("categoriesId")
                        .HasColumnType("int");

                    b.Property<int>("cursosId")
                        .HasColumnType("int");

                    b.HasKey("categoriesId", "cursosId");

                    b.HasIndex("cursosId");

                    b.ToTable("CategoryCurso");
                });

            modelBuilder.Entity("CursoStudent", b =>
                {
                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<int>("studentsId")
                        .HasColumnType("int");

                    b.HasKey("CursoId", "studentsId");

                    b.HasIndex("studentsId");

                    b.ToTable("CursoStudent");
                });

            modelBuilder.Entity("apibackend.Models.DataModels.Category", b =>
                {
                    b.HasBaseType("apibackend.Models.DataModels.BaseEntity");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Category");
                });

            modelBuilder.Entity("apibackend.Models.DataModels.Chapter", b =>
                {
                    b.HasBaseType("apibackend.Models.DataModels.BaseEntity");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.HasIndex("CursoId")
                        .IsUnique()
                        .HasFilter("[CursoId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Chapter");
                });

            modelBuilder.Entity("apibackend.Models.DataModels.Curso", b =>
                {
                    b.HasBaseType("apibackend.Models.DataModels.BaseEntity");

                    b.Property<string>("DescripcionLarga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionCorta")
                        .IsRequired()
                        .HasMaxLength(280)
                        .HasColumnType("nvarchar(280)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Curso_Name");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<string>("Objetivos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicoObjetivos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requisitos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Curso");
                });

            modelBuilder.Entity("apibackend.Models.DataModels.Student", b =>
                {
                    b.HasBaseType("apibackend.Models.DataModels.BaseEntity");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Student_Name");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("apibackend.Models.DataModels.User", b =>
                {
                    b.HasBaseType("apibackend.Models.DataModels.BaseEntity");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("User_LastName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("User_Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("CategoryCurso", b =>
                {
                    b.HasOne("apibackend.Models.DataModels.Category", null)
                        .WithMany()
                        .HasForeignKey("categoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apibackend.Models.DataModels.Curso", null)
                        .WithMany()
                        .HasForeignKey("cursosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CursoStudent", b =>
                {
                    b.HasOne("apibackend.Models.DataModels.Curso", null)
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apibackend.Models.DataModels.Student", null)
                        .WithMany()
                        .HasForeignKey("studentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("apibackend.Models.DataModels.Chapter", b =>
                {
                    b.HasOne("apibackend.Models.DataModels.Curso", "Curso")
                        .WithOne("Chapter")
                        .HasForeignKey("apibackend.Models.DataModels.Chapter", "CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("apibackend.Models.DataModels.Curso", b =>
                {
                    b.Navigation("Chapter")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}