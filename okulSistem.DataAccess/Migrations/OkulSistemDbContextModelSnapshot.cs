﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using okulSistem.DataAccess;

#nullable disable

namespace okulSistem.DataAccess.Migrations
{
    [DbContext(typeof(OkulSistemDbContext))]
    partial class OkulSistemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("okulSistem.Entities.Ders", b =>
                {
                    b.Property<int>("dersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("dersId"), 1L, 1);

                    b.Property<string>("dersAciklama")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("dersAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("dersDurum")
                        .HasColumnType("bit");

                    b.HasKey("dersId");

                    b.ToTable("Dersler");
                });

            modelBuilder.Entity("okulSistem.Entities.Ogrenci", b =>
                {
                    b.Property<int>("ogrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ogrenciId"), 1L, 1);

                    b.Property<string>("ogrenciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ogreniDersler")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ogreniciDurum")
                        .HasColumnType("bit");

                    b.Property<string>("ogreniciNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ogreniciSoyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ogrenciId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("okulSistem.Entities.Ogretmen", b =>
                {
                    b.Property<int>("ogretmenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ogretmenId"), 1L, 1);

                    b.Property<string>("ogretmenAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ogretmenDersdersId")
                        .HasColumnType("int");

                    b.Property<bool>("ogretmenDurum")
                        .HasColumnType("bit");

                    b.Property<string>("ogretmenSoyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ogretmenId");

                    b.HasIndex("ogretmenDersdersId");

                    b.ToTable("Ogretmenler");
                });

            modelBuilder.Entity("okulSistem.Entities.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"), 1L, 1);

                    b.Property<string>("userAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("userMail")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("userPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userSoyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("okulSistem.Entities.Ogretmen", b =>
                {
                    b.HasOne("okulSistem.Entities.Ders", "ogretmenDers")
                        .WithMany()
                        .HasForeignKey("ogretmenDersdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ogretmenDers");
                });
#pragma warning restore 612, 618
        }
    }
}
