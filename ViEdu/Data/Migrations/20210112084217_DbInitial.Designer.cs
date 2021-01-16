﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ViEdu.Data.EF;

namespace ViEdu.Data.Migrations
{
    [DbContext(typeof(ViEduDbContext))]
    [Migration("20210112084217_DbInitial")]
    partial class DbInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("ViEdu.Data.Entities.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DEPT_CD")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("DEPT_NAME")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("ID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DEPT_CD = "TEACHER",
                            DEPT_NAME = "Chuyên môn giảng dạy"
                        },
                        new
                        {
                            ID = 2,
                            DEPT_CD = "SALE",
                            DEPT_NAME = "Kinh doanh"
                        },
                        new
                        {
                            ID = 5,
                            DEPT_CD = "MK",
                            DEPT_NAME = "Marketing & Support"
                        },
                        new
                        {
                            ID = 3,
                            DEPT_CD = "OP",
                            DEPT_NAME = "Operation"
                        },
                        new
                        {
                            ID = 4,
                            DEPT_CD = "TRA",
                            DEPT_NAME = "Training"
                        });
                });

            modelBuilder.Entity("ViEdu.Data.Entities.Position", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BENEFIT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CREATED_BY")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("DEPT_CD")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JOB_REQUIRED")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JOB_TYPE_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MODIFIED_BY")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("MODIFIED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("NAME")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("NOTE")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("POSITION_CD")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("RANK")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            ID = 2172,
                            CREATED_BY = "0000001",
                            CREATED_DATE = new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DEPT_CD = "OP",
                            DESC = "Nhân viên văn phòng",
                            MODIFIED_DATE = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NAME = "ADMIN",
                            POSITION_CD = "0015",
                            RANK = 8
                        },
                        new
                        {
                            ID = 2173,
                            CREATED_BY = "0000001",
                            CREATED_DATE = new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DEPT_CD = "TEACHER",
                            DESC = "Giáo viên bán thời gian",
                            MODIFIED_DATE = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NAME = "TEACHER-PARTTIME",
                            POSITION_CD = "0003",
                            RANK = 8
                        },
                        new
                        {
                            ID = 2174,
                            CREATED_BY = "0000001",
                            CREATED_DATE = new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DEPT_CD = "TEACHER",
                            DESC = "Giáo viên Fulltime",
                            MODIFIED_DATE = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NAME = "TEACHER-FULLTIME",
                            POSITION_CD = "0004",
                            RANK = 8
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
