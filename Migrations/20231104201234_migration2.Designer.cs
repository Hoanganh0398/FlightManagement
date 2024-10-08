﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLBH;

#nullable disable

namespace QLBH.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20231104201234_migration2")]
    partial class migration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QLBH.Models.Customer", b =>
                {
                    b.Property<long>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CustomerID"));

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("date");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1L,
                            BirthDay = new DateTime(2000, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "012345678901",
                            Email = "NguyenVanT@gmail.com",
                            Gender = false,
                            Name = "Nguyễn Văn Thơ",
                            Phone = "0757294361"
                        },
                        new
                        {
                            CustomerID = 2L,
                            BirthDay = new DateTime(1999, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "068903241849",
                            Email = "THNT56565@email.com",
                            Gender = true,
                            Name = "Trần Thị Hồng Ngọc",
                            Phone = "0989102574"
                        },
                        new
                        {
                            CustomerID = 3L,
                            BirthDay = new DateTime(1987, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "054321319302",
                            Email = "LeQuocSong@gmail.com",
                            Gender = true,
                            Name = "Lê Quốc Ca",
                            Phone = "0343671829"
                        },
                        new
                        {
                            CustomerID = 4L,
                            BirthDay = new DateTime(2001, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "097654810294",
                            Email = "PhamAnhCope@email.com",
                            Gender = true,
                            Name = "Phạm Anh Đồng",
                            Phone = "0460492715"
                        },
                        new
                        {
                            CustomerID = 5L,
                            BirthDay = new DateTime(1995, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "024683719492",
                            Email = "HoangTHiBird@gmail.com",
                            Gender = true,
                            Name = "Hoàng Thị Én",
                            Phone = "0431568942"
                        },
                        new
                        {
                            CustomerID = 6L,
                            BirthDay = new DateTime(1996, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "015793819201",
                            Email = "VuMinhFea@email.com",
                            Gender = false,
                            Name = "Vũ Minh Phương",
                            Phone = "0520873456"
                        },
                        new
                        {
                            CustomerID = 7L,
                            BirthDay = new DateTime(1998, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "086420728192",
                            Email = "GiangBui@email.com",
                            Name = "Bùi Văn Giang",
                            Phone = "0678941320"
                        },
                        new
                        {
                            CustomerID = 8L,
                            BirthDay = new DateTime(1999, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "075314839292",
                            Email = "NgoThank@gmail.com",
                            Gender = false,
                            Name = "Ngô Thanh Huyền",
                            Phone = "0412456789"
                        },
                        new
                        {
                            CustomerID = 9L,
                            BirthDay = new DateTime(1994, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "062082738592",
                            Email = "ThuThao123@email.com",
                            Gender = true,
                            Name = "Đặng Thu Thảo",
                            Phone = "0793502748"
                        },
                        new
                        {
                            CustomerID = 10L,
                            BirthDay = new DateTime(1993, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "031425928473",
                            Email = "TamTu@gmail.com",
                            Gender = true,
                            Name = "Trương Tâm Tú",
                            Phone = "0736251849"
                        },
                        new
                        {
                            CustomerID = 11L,
                            BirthDay = new DateTime(1992, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "076542819382",
                            Email = "HaiQuan@gmail.com",
                            Gender = true,
                            Name = "Lâm Quang Khải",
                            Phone = "0750781693"
                        },
                        new
                        {
                            CustomerID = 12L,
                            BirthDay = new DateTime(1997, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "020987371284",
                            Email = "LaiHo@email.com",
                            Gender = true,
                            Name = "Hồ Thị Lai",
                            Phone = "0568923147"
                        },
                        new
                        {
                            CustomerID = 13L,
                            BirthDay = new DateTime(1978, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "057898392012",
                            Email = "HoangMink@email.com",
                            Gender = false,
                            Name = "Đỗ Hoàng Minh",
                            Phone = "0424589310"
                        },
                        new
                        {
                            CustomerID = 14L,
                            BirthDay = new DateTime(2003, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "013404859402",
                            Email = "ChildNkee@gmail.com",
                            Gender = false,
                            Name = "Châu Minh Nhi",
                            Phone = "0371820394"
                        },
                        new
                        {
                            CustomerID = 15L,
                            BirthDay = new DateTime(2002, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "045672817492",
                            Email = "MaiTki@email.com",
                            Gender = true,
                            Name = "Mai Thị Oanh",
                            Phone = "0296047258"
                        },
                        new
                        {
                            CustomerID = 16L,
                            BirthDay = new DateTime(2000, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "09760385748",
                            Email = "PinkHappy@gmail.com",
                            Gender = false,
                            Name = "Nguyễn Hồng Phúc",
                            Phone = "0512345678"
                        },
                        new
                        {
                            CustomerID = 17L,
                            BirthDay = new DateTime(1984, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "05310758492",
                            Email = "LTTQuỳnh@email.com",
                            Gender = true,
                            Name = "Lê Thị thanh Quỳnh",
                            Phone = "0787463291"
                        },
                        new
                        {
                            CustomerID = 18L,
                            BirthDay = new DateTime(1980, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "068904657322",
                            Email = "ThanhPhanTea@gmail.com",
                            Gender = true,
                            Name = "Phan Thanh Trà",
                            Phone = "0953127964"
                        },
                        new
                        {
                            CustomerID = 19L,
                            BirthDay = new DateTime(1988, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "034567271392",
                            Email = "TranSVan@gmail.com",
                            Gender = true,
                            Name = "Trần Văn Sĩ",
                            Phone = "0974920518"
                        },
                        new
                        {
                            CustomerID = 20L,
                            BirthDay = new DateTime(1993, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "080121839201",
                            Email = "ILoveHN@gmail.com",
                            Gender = true,
                            Name = "Đinh Quốc Tuân",
                            Phone = "0938562914"
                        });
                });

            modelBuilder.Entity("QLBH.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EmployeeID"));

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("Date");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<DateTime>("DayWork")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)");

                    b.Property<long>("RoleID")
                        .HasColumnType("bigint");

                    b.HasKey("EmployeeID");

                    b.HasIndex("RoleID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1L,
                            BirthDay = new DateTime(1993, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024793",
                            DayWork = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nva@email.com",
                            Gender = true,
                            Name = "Đỗ Bình An",
                            Password = "111",
                            Phone = "0987654321",
                            RoleID = 1L
                        },
                        new
                        {
                            EmployeeID = 2L,
                            BirthDay = new DateTime(1988, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024794",
                            DayWork = new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ttb@email.com",
                            Gender = false,
                            Name = "Trần Thị Khánh Bâng",
                            Password = "111",
                            Phone = "0901234567",
                            RoleID = 2L
                        },
                        new
                        {
                            EmployeeID = 3L,
                            BirthDay = new DateTime(1980, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024795",
                            DayWork = new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lqc@email.com",
                            Gender = true,
                            Name = "Lê Quốc Cảnh",
                            Password = "111",
                            Phone = "0912345678",
                            RoleID = 2L
                        },
                        new
                        {
                            EmployeeID = 4L,
                            BirthDay = new DateTime(1984, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024796",
                            DayWork = new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "pad@email.com",
                            Gender = true,
                            Name = "Phạm Anh Dũng",
                            Password = "111",
                            Phone = "0923456789",
                            RoleID = 3L
                        },
                        new
                        {
                            EmployeeID = 5L,
                            BirthDay = new DateTime(2000, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024797",
                            DayWork = new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hte@email.com",
                            Gender = false,
                            Name = "Emily Hoàng Thị",
                            Password = "111",
                            Phone = "0934567890",
                            RoleID = 3L
                        },
                        new
                        {
                            EmployeeID = 6L,
                            BirthDay = new DateTime(2002, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024798",
                            DayWork = new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "vmf@email.com",
                            Gender = true,
                            Name = "Vũ Minh Toàn",
                            Password = "111",
                            Phone = "0945678901",
                            RoleID = 4L
                        },
                        new
                        {
                            EmployeeID = 7L,
                            BirthDay = new DateTime(2003, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024799",
                            DayWork = new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bvng@email.com",
                            Gender = true,
                            Name = "Bùi Văn Nghị",
                            Password = "111",
                            Phone = "0956789012",
                            RoleID = 4L
                        },
                        new
                        {
                            EmployeeID = 8L,
                            BirthDay = new DateTime(1978, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024800",
                            DayWork = new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nth@email.com",
                            Gender = true,
                            Name = "Hoàng Hưu Hảo",
                            Password = "111",
                            Phone = "0967890123",
                            RoleID = 5L
                        },
                        new
                        {
                            EmployeeID = 9L,
                            BirthDay = new DateTime(1997, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024801",
                            DayWork = new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "dti@email.com",
                            Gender = false,
                            Name = "Đặng Thu Lam",
                            Password = "111",
                            Phone = "0978901234",
                            RoleID = 5L
                        },
                        new
                        {
                            EmployeeID = 10L,
                            BirthDay = new DateTime(1993, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024802",
                            DayWork = new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ttjudge@email.com",
                            Gender = false,
                            Name = "Trương Tâm Trạng",
                            Password = "111",
                            Phone = "0989012345",
                            RoleID = 5L
                        },
                        new
                        {
                            EmployeeID = 11L,
                            BirthDay = new DateTime(1994, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024803",
                            DayWork = new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lqk@email.com",
                            Gender = true,
                            Name = "Lâm Quang Lưu",
                            Password = "111",
                            Phone = "0990123456",
                            RoleID = 5L
                        },
                        new
                        {
                            EmployeeID = 12L,
                            BirthDay = new DateTime(1999, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024804",
                            DayWork = new DateTime(2003, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "htl@email.com",
                            Gender = false,
                            Name = "Hồ Thị Liên",
                            Password = "111",
                            Phone = "0901234567",
                            RoleID = 5L
                        },
                        new
                        {
                            EmployeeID = 13L,
                            BirthDay = new DateTime(1998, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024805",
                            DayWork = new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "dhm@email.com",
                            Gender = true,
                            Name = "Đỗ Hoàng Hảo",
                            Password = "111",
                            Phone = "0912345678",
                            RoleID = 5L
                        },
                        new
                        {
                            EmployeeID = 14L,
                            BirthDay = new DateTime(1996, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024806",
                            DayWork = new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "cmn@email.com",
                            Gender = true,
                            Name = "Châu Minh Tiến",
                            Password = "111",
                            Phone = "0923456789",
                            RoleID = 5L
                        },
                        new
                        {
                            EmployeeID = 15L,
                            BirthDay = new DateTime(1995, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024807",
                            DayWork = new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mto@email.com",
                            Gender = false,
                            Name = "Mai Thị Thu Hoàng",
                            Password = "111",
                            Phone = "0934567890",
                            RoleID = 5L
                        },
                        new
                        {
                            EmployeeID = 16L,
                            BirthDay = new DateTime(2001, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CCCD = "079203024808",
                            DayWork = new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nhp@email.com",
                            Gender = false,
                            Name = "Nguyễn Hồng",
                            Password = "111",
                            Phone = "0945678901",
                            RoleID = 5L
                        });
                });

            modelBuilder.Entity("QLBH.Models.Role", b =>
                {
                    b.Property<long>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RoleID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = 1L,
                            Name = "Tổng quản lý"
                        },
                        new
                        {
                            RoleID = 2L,
                            Name = "Quản lý chuyến bay"
                        },
                        new
                        {
                            RoleID = 3L,
                            Name = "Quản lý phi công"
                        },
                        new
                        {
                            RoleID = 4L,
                            Name = "Quản lý hành khách"
                        },
                        new
                        {
                            RoleID = 5L,
                            Name = "Phi công"
                        });
                });

            modelBuilder.Entity("QLBH.Models.Employee", b =>
                {
                    b.HasOne("QLBH.Models.Role", "Roles")
                        .WithMany("Employees")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("QLBH.Models.Role", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
