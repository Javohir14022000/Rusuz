﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rusuz.Brokers.Storages;

#nullable disable

namespace Rusuz.Migrations
{
    [DbContext(typeof(StorageBroker))]
    [Migration("20241222052954_TwoMigrate1")]
    partial class TwoMigrate1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Rusuz.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Rusuz.Models.Sektion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionPicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Sektions");
                });

            modelBuilder.Entity("Rusuz.Models.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("English")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishTrans")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExampleEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExampleUz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SektionId")
                        .HasColumnType("int");

                    b.Property<string>("Uzbek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WordPicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SektionId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("Rusuz.Models.Sektion", b =>
                {
                    b.HasOne("Rusuz.Models.Category", "Category")
                        .WithMany("Sekions")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Rusuz.Models.Word", b =>
                {
                    b.HasOne("Rusuz.Models.Sektion", "Sektion")
                        .WithMany("Words")
                        .HasForeignKey("SektionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sektion");
                });

            modelBuilder.Entity("Rusuz.Models.Category", b =>
                {
                    b.Navigation("Sekions");
                });

            modelBuilder.Entity("Rusuz.Models.Sektion", b =>
                {
                    b.Navigation("Words");
                });
#pragma warning restore 612, 618
        }
    }
}
