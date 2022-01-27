﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagement.EntityFrameworkCore;

namespace SchoolManagement.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolManagement.Core.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Course", "SchoolManagement");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "数学"
                        });
                });

            modelBuilder.Entity("SchoolManagement.Core.Models.Scroe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("ScroeNumber")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Scroe", "SchoolManagement");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            ScroeNumber = 99,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            ScroeNumber = 90,
                            StudentId = 3
                        });
                });

            modelBuilder.Entity("SchoolManagement.Core.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Major")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Student", "SchoolManagement");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Email = "zhangsan@qq.com",
                            Major = 3,
                            Name = "张三"
                        },
                        new
                        {
                            Id = 3,
                            Email = "lisi@360.com",
                            Major = 0,
                            Name = "李四"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}