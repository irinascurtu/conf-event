﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechEvent.Domain.Entities;

namespace TechEvent.Domain.Migrations
{
    [DbContext(typeof(TechEventContext))]
    [Migration("20190219114457_SponsorSinglePhoto")]
    partial class SponsorSinglePhoto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TechEvent.Domain.Entities.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tagline");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Editions");
                });

            modelBuilder.Entity("TechEvent.Domain.Entities.Paper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EditionId");

                    b.HasKey("Id");

                    b.ToTable("Papers");
                });

            modelBuilder.Entity("TechEvent.Domain.Entities.PaperStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("PaperStatuses");
                });

            modelBuilder.Entity("TechEvent.Domain.Entities.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<string>("CompanyWebsite");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("Facebook");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("GitHub");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LinkedIn");

                    b.Property<string>("PageSlug");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Skype");

                    b.Property<string>("Twitter");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("TechEvent.Domain.Entities.Sponsor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Facebook");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PageSlug");

                    b.Property<int?>("SponsorPhotoId");

                    b.Property<int>("SponsorTypeId");

                    b.Property<string>("Website")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("SponsorPhotoId");

                    b.HasIndex("SponsorTypeId");

                    b.ToTable("Sponsors");
                });

            modelBuilder.Entity("TechEvent.Domain.Entities.SponsorPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageMimeType");

                    b.Property<string>("ImageName");

                    b.Property<byte[]>("PhotoFile");

                    b.Property<int>("SponsorId");

                    b.HasKey("Id");

                    b.HasIndex("SponsorId");

                    b.ToTable("SponsorPhoto");
                });

            modelBuilder.Entity("TechEvent.Domain.Entities.SponsorType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SponsorTypes");
                });

            modelBuilder.Entity("TechEvent.Domain.Entities.Talk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SpeakerId");

                    b.Property<int>("TalkTypeId");

                    b.HasKey("Id");

                    b.ToTable("Talks");
                });

            modelBuilder.Entity("TechEvent.Domain.Entities.TalkType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Duration");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TalkTypes");
                });

            modelBuilder.Entity("TechEvent.Domain.Entities.Workshop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SpeakerId");

                    b.Property<int>("TalkTypeId");

                    b.HasKey("Id");

                    b.ToTable("Workshops");
                });

            modelBuilder.Entity("TechEvent.Domain.Entities.Sponsor", b =>
                {
                    b.HasOne("TechEvent.Domain.Entities.SponsorPhoto", "Photo")
                        .WithMany()
                        .HasForeignKey("SponsorPhotoId");

                    b.HasOne("TechEvent.Domain.Entities.SponsorType", "SponsorType")
                        .WithMany("Sponsors")
                        .HasForeignKey("SponsorTypeId")
                        .HasConstraintName("FK_Sponsors_SponsorTypes");
                });

            modelBuilder.Entity("TechEvent.Domain.Entities.SponsorPhoto", b =>
                {
                    b.HasOne("TechEvent.Domain.Entities.Sponsor", "Sponsor")
                        .WithMany()
                        .HasForeignKey("SponsorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
