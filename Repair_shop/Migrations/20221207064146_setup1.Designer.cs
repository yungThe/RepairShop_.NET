﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repair_shop.Data;

#nullable disable

namespace Repair_shop.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20221207064146_setup1")]
    partial class setup1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Repair_shop.Models.HoaDonGiao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("HDTid")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("HDTid");

                    b.ToTable("HoaDonGiao");
                });

            modelBuilder.Entity("Repair_shop.Models.HoaDonTam", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("khachhangid")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("xeid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("khachhangid");

                    b.HasIndex("xeid");

                    b.ToTable("HoaDonTam");
                });

            modelBuilder.Entity("Repair_shop.Models.HoaDonTamLinhKienXe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("hoaDonTamid")
                        .HasColumnType("int");

                    b.Property<int>("linhKienXeid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("hoaDonTamid");

                    b.HasIndex("linhKienXeid");

                    b.ToTable("hoaDonTamLinhKienxes");
                });

            modelBuilder.Entity("Repair_shop.Models.KhachHang", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("Repair_shop.Models.KhachHangXe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Xeid")
                        .HasColumnType("int");

                    b.Property<int>("khachHangid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Xeid");

                    b.HasIndex("khachHangid");

                    b.ToTable("KhachHangXes");
                });

            modelBuilder.Entity("Repair_shop.Models.LinhKien", b =>
                {
                    b.Property<string>("partID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("partDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("partInStock")
                        .HasColumnType("int");

                    b.Property<string>("partName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("partID");

                    b.ToTable("LinhKien");
                });

            modelBuilder.Entity("Repair_shop.Models.LinhKienXe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("linhKienspartID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("xeid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("linhKienspartID");

                    b.HasIndex("xeid");

                    b.ToTable("linhKienXes");
                });

            modelBuilder.Entity("Repair_shop.Models.NVKho", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("thanhVienid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("thanhVienid");

                    b.ToTable("NVKho");
                });

            modelBuilder.Entity("Repair_shop.Models.NVKT", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("thanhvienid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("thanhvienid");

                    b.ToTable("NVKT");
                });

            modelBuilder.Entity("Repair_shop.Models.ThanhVien", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ThanhVien");
                });

            modelBuilder.Entity("Repair_shop.Models.Xe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("hangXe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenXe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Xe");
                });

            modelBuilder.Entity("Repair_shop.Models.HoaDonGiao", b =>
                {
                    b.HasOne("Repair_shop.Models.HoaDonTam", "HDT")
                        .WithMany()
                        .HasForeignKey("HDTid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HDT");
                });

            modelBuilder.Entity("Repair_shop.Models.HoaDonTam", b =>
                {
                    b.HasOne("Repair_shop.Models.KhachHang", "khachhang")
                        .WithMany("hoaDonTams")
                        .HasForeignKey("khachhangid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repair_shop.Models.Xe", "xe")
                        .WithMany("hoaDonTams")
                        .HasForeignKey("xeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("khachhang");

                    b.Navigation("xe");
                });

            modelBuilder.Entity("Repair_shop.Models.HoaDonTamLinhKienXe", b =>
                {
                    b.HasOne("Repair_shop.Models.HoaDonTam", "hoaDonTam")
                        .WithMany("hoaDonTamLinhKienXes")
                        .HasForeignKey("hoaDonTamid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repair_shop.Models.LinhKienXe", "linhKienXe")
                        .WithMany()
                        .HasForeignKey("linhKienXeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoaDonTam");

                    b.Navigation("linhKienXe");
                });

            modelBuilder.Entity("Repair_shop.Models.KhachHangXe", b =>
                {
                    b.HasOne("Repair_shop.Models.Xe", "Xe")
                        .WithMany("khachHangXes")
                        .HasForeignKey("Xeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repair_shop.Models.KhachHang", "khachHang")
                        .WithMany("khachHangXes")
                        .HasForeignKey("khachHangid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Xe");

                    b.Navigation("khachHang");
                });

            modelBuilder.Entity("Repair_shop.Models.LinhKienXe", b =>
                {
                    b.HasOne("Repair_shop.Models.LinhKien", "linhKiens")
                        .WithMany("linhKienXes")
                        .HasForeignKey("linhKienspartID");

                    b.HasOne("Repair_shop.Models.Xe", "xe")
                        .WithMany("linhKienXes")
                        .HasForeignKey("xeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("linhKiens");

                    b.Navigation("xe");
                });

            modelBuilder.Entity("Repair_shop.Models.NVKho", b =>
                {
                    b.HasOne("Repair_shop.Models.ThanhVien", "thanhVien")
                        .WithMany()
                        .HasForeignKey("thanhVienid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("thanhVien");
                });

            modelBuilder.Entity("Repair_shop.Models.NVKT", b =>
                {
                    b.HasOne("Repair_shop.Models.ThanhVien", "thanhvien")
                        .WithMany()
                        .HasForeignKey("thanhvienid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("thanhvien");
                });

            modelBuilder.Entity("Repair_shop.Models.HoaDonTam", b =>
                {
                    b.Navigation("hoaDonTamLinhKienXes");
                });

            modelBuilder.Entity("Repair_shop.Models.KhachHang", b =>
                {
                    b.Navigation("hoaDonTams");

                    b.Navigation("khachHangXes");
                });

            modelBuilder.Entity("Repair_shop.Models.LinhKien", b =>
                {
                    b.Navigation("linhKienXes");
                });

            modelBuilder.Entity("Repair_shop.Models.Xe", b =>
                {
                    b.Navigation("hoaDonTams");

                    b.Navigation("khachHangXes");

                    b.Navigation("linhKienXes");
                });
#pragma warning restore 612, 618
        }
    }
}