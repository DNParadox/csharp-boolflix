﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_boolfix.Data;

#nullable disable

namespace csharpboolfix.Migrations
{
    [DbContext(typeof(BoolfixDbContext))]
    [Migration("20221206104035_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContenutoVideoGenere", b =>
                {
                    b.Property<int>("ContenutiVideoId")
                        .HasColumnType("int");

                    b.Property<int>("GeneriId")
                        .HasColumnType("int");

                    b.HasKey("ContenutiVideoId", "GeneriId");

                    b.HasIndex("GeneriId");

                    b.ToTable("ContenutoVideoGenere");
                });

            modelBuilder.Entity("ContenutoVideoPlayList", b =>
                {
                    b.Property<int>("ContenutiVideoId")
                        .HasColumnType("int");

                    b.Property<int>("PlayListsId")
                        .HasColumnType("int");

                    b.HasKey("ContenutiVideoId", "PlayListsId");

                    b.HasIndex("PlayListsId");

                    b.ToTable("ContenutoVideoPlayList");
                });

            modelBuilder.Entity("ContenutoVideoProfilo", b =>
                {
                    b.Property<int>("ContenutiVideoId")
                        .HasColumnType("int");

                    b.Property<int>("ProfiliId")
                        .HasColumnType("int");

                    b.HasKey("ContenutiVideoId", "ProfiliId");

                    b.HasIndex("ProfiliId");

                    b.ToTable("ContenutoVideoProfilo");
                });

            modelBuilder.Entity("csharp_boolfix.Models.ContenutoVideo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Durata")
                        .HasColumnType("int");

                    b.Property<string>("Titolo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContenutiVideo");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ContenutoVideo");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("csharp_boolfix.Models.Genere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generi");
                });

            modelBuilder.Entity("csharp_boolfix.Models.PlayList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProfiloId")
                        .HasColumnType("int");

                    b.Property<string>("Titolo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProfiloId")
                        .IsUnique();

                    b.ToTable("PlayLists");
                });

            modelBuilder.Entity("csharp_boolfix.Models.Profilo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profili");
                });

            modelBuilder.Entity("csharp_boolfix.Models.Film", b =>
                {
                    b.HasBaseType("csharp_boolfix.Models.ContenutoVideo");

                    b.HasDiscriminator().HasValue("Film");
                });

            modelBuilder.Entity("csharp_boolfix.Models.Serie", b =>
                {
                    b.HasBaseType("csharp_boolfix.Models.ContenutoVideo");

                    b.Property<int>("NumeroEpisodi")
                        .HasColumnType("int");

                    b.Property<int>("SerieId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Serie");
                });

            modelBuilder.Entity("ContenutoVideoGenere", b =>
                {
                    b.HasOne("csharp_boolfix.Models.ContenutoVideo", null)
                        .WithMany()
                        .HasForeignKey("ContenutiVideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolfix.Models.Genere", null)
                        .WithMany()
                        .HasForeignKey("GeneriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContenutoVideoPlayList", b =>
                {
                    b.HasOne("csharp_boolfix.Models.ContenutoVideo", null)
                        .WithMany()
                        .HasForeignKey("ContenutiVideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolfix.Models.PlayList", null)
                        .WithMany()
                        .HasForeignKey("PlayListsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContenutoVideoProfilo", b =>
                {
                    b.HasOne("csharp_boolfix.Models.ContenutoVideo", null)
                        .WithMany()
                        .HasForeignKey("ContenutiVideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolfix.Models.Profilo", null)
                        .WithMany()
                        .HasForeignKey("ProfiliId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("csharp_boolfix.Models.PlayList", b =>
                {
                    b.HasOne("csharp_boolfix.Models.Profilo", null)
                        .WithOne("LaMiaPlaylist")
                        .HasForeignKey("csharp_boolfix.Models.PlayList", "ProfiloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("csharp_boolfix.Models.Profilo", b =>
                {
                    b.Navigation("LaMiaPlaylist");
                });
#pragma warning restore 612, 618
        }
    }
}
