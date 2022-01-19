﻿// <auto-generated />
using CodingAssessment.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodingAssessment.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodingAssessment.Api.Models.Cat", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("adaptability")
                        .HasColumnType("int");

                    b.Property<int>("affection_level")
                        .HasColumnType("int");

                    b.Property<string>("alt_names")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cfa_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("child_friendly")
                        .HasColumnType("int");

                    b.Property<string>("country_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country_codes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dog_friendly")
                        .HasColumnType("int");

                    b.Property<int>("energy_level")
                        .HasColumnType("int");

                    b.Property<int>("experimental")
                        .HasColumnType("int");

                    b.Property<int>("grooming")
                        .HasColumnType("int");

                    b.Property<int>("hairless")
                        .HasColumnType("int");

                    b.Property<int>("health_issues")
                        .HasColumnType("int");

                    b.Property<int>("hypoallergenic")
                        .HasColumnType("int");

                    b.Property<int>("indoor")
                        .HasColumnType("int");

                    b.Property<int>("intelligence")
                        .HasColumnType("int");

                    b.Property<int>("lap")
                        .HasColumnType("int");

                    b.Property<string>("life_span")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("natural")
                        .HasColumnType("int");

                    b.Property<string>("origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rare")
                        .HasColumnType("int");

                    b.Property<int>("rex")
                        .HasColumnType("int");

                    b.Property<int>("shedding_level")
                        .HasColumnType("int");

                    b.Property<int>("short_legs")
                        .HasColumnType("int");

                    b.Property<int>("social_needs")
                        .HasColumnType("int");

                    b.Property<int>("stranger_friendly")
                        .HasColumnType("int");

                    b.Property<int>("suppressed_tail")
                        .HasColumnType("int");

                    b.Property<string>("temperament")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vcahospitals_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vetstreet_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("vocalisation")
                        .HasColumnType("int");

                    b.Property<string>("wikipedia_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("CodingAssessment.Api.Models.Image", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CatId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatId")
                        .IsUnique();

                    b.ToTable("Images");
                });

            modelBuilder.Entity("CodingAssessment.Api.Models.Weight", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CatId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Imperial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Metric")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatId")
                        .IsUnique();

                    b.ToTable("Weights");
                });

            modelBuilder.Entity("CodingAssessment.Api.Models.Image", b =>
                {
                    b.HasOne("CodingAssessment.Api.Models.Cat", null)
                        .WithOne("Image")
                        .HasForeignKey("CodingAssessment.Api.Models.Image", "CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodingAssessment.Api.Models.Weight", b =>
                {
                    b.HasOne("CodingAssessment.Api.Models.Cat", "Cat")
                        .WithOne("Weight")
                        .HasForeignKey("CodingAssessment.Api.Models.Weight", "CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("CodingAssessment.Api.Models.Cat", b =>
                {
                    b.Navigation("Image")
                        .IsRequired();

                    b.Navigation("Weight")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}