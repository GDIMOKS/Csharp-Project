﻿// <auto-generated />
using System;
using IntelligentWorkKeeper.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IntelligentWorkKeeper.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthorIntelligentWork", b =>
                {
                    b.Property<Guid>("AuthorsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IntelligentWorksId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AuthorsId", "IntelligentWorksId");

                    b.HasIndex("IntelligentWorksId");

                    b.ToTable("AuthorIntelligentWork");
                });

            modelBuilder.Entity("IntelligentWorkKeeper.Domain.Models.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberInList")
                        .HasColumnType("int");

                    b.Property<string>("PatronymicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortPatronymicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("IntelligentWorkKeeper.Domain.Models.Indexation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IntelligentWorkId")
                        .HasColumnType("int");

                    b.Property<Guid?>("IntelligentWorkId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IntelligentWorkId1");

                    b.ToTable("Indexations");
                });

            modelBuilder.Entity("IntelligentWorkKeeper.Domain.Models.IntelligentWork", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DOI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GRNTI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("IntelligentWorks");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IntelligentWork");
                });

            modelBuilder.Entity("IntelligentWorkKeeper.Domain.Models.KeyWord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IntelligentWorkId")
                        .HasColumnType("int");

                    b.Property<Guid?>("IntelligentWorkId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Word")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IntelligentWorkId1");

                    b.ToTable("KeyWords");
                });

            modelBuilder.Entity("IntelligentWorkKeeper.Domain.Models.Publication", b =>
                {
                    b.HasBaseType("IntelligentWorkKeeper.Domain.Models.IntelligentWork");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UDK")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Publication");
                });

            modelBuilder.Entity("IntelligentWorkKeeper.Domain.Models.RegistrationCertificate", b =>
                {
                    b.HasBaseType("IntelligentWorkKeeper.Domain.Models.IntelligentWork");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RightHolder")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("RegistrationCertificate");
                });

            modelBuilder.Entity("IntelligentWorkKeeper.Domain.Models.Article", b =>
                {
                    b.HasBaseType("IntelligentWorkKeeper.Domain.Models.Publication");

                    b.Property<string>("ArticleType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollectionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndPage")
                        .HasColumnType("int");

                    b.Property<int>("MagazineNumber")
                        .HasColumnType("int");

                    b.Property<int>("Part")
                        .HasColumnType("int");

                    b.Property<int>("StartPage")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Article");
                });

            modelBuilder.Entity("IntelligentWorkKeeper.Domain.Models.Book", b =>
                {
                    b.HasBaseType("IntelligentWorkKeeper.Domain.Models.Publication");

                    b.Property<string>("BookType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edition")
                        .HasColumnType("int");

                    b.Property<string>("EditionType")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Book");
                });

            modelBuilder.Entity("AuthorIntelligentWork", b =>
                {
                    b.HasOne("IntelligentWorkKeeper.Domain.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntelligentWorkKeeper.Domain.Models.IntelligentWork", null)
                        .WithMany()
                        .HasForeignKey("IntelligentWorksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IntelligentWorkKeeper.Domain.Models.Indexation", b =>
                {
                    b.HasOne("IntelligentWorkKeeper.Domain.Models.IntelligentWork", "IntelligentWork")
                        .WithMany("Indexations")
                        .HasForeignKey("IntelligentWorkId1");

                    b.Navigation("IntelligentWork");
                });

            modelBuilder.Entity("IntelligentWorkKeeper.Domain.Models.KeyWord", b =>
                {
                    b.HasOne("IntelligentWorkKeeper.Domain.Models.IntelligentWork", "IntelligentWork")
                        .WithMany("KeyWords")
                        .HasForeignKey("IntelligentWorkId1");

                    b.Navigation("IntelligentWork");
                });

            modelBuilder.Entity("IntelligentWorkKeeper.Domain.Models.IntelligentWork", b =>
                {
                    b.Navigation("Indexations");

                    b.Navigation("KeyWords");
                });
#pragma warning restore 612, 618
        }
    }
}
