using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFSamurai.Data;
using EFSamurai.Domain;

namespace EfSamuari.Data.Migrations
{
    [DbContext(typeof(SamuraiContext))]
    [Migration("20170508115113_MigrationBattles")]
    partial class MigrationBattles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFSamurai.Domain.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QuateLength");

                    b.Property<int>("QuoteType");

                    b.Property<int?>("SamuraiId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("EFSamurai.Domain.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HairStyle");

                    b.Property<string>("Name");

                    b.Property<string>("Sword");

                    b.HasKey("Id");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("EFSamurai.Domain.SecretIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RealName");

                    b.Property<int>("SamuraiId");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId")
                        .IsUnique();

                    b.ToTable("SecretIdentity");
                });

            modelBuilder.Entity("EFSamurai.Domain.Quote", b =>
                {
                    b.HasOne("EFSamurai.Domain.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId");
                });

            modelBuilder.Entity("EFSamurai.Domain.SecretIdentity", b =>
                {
                    b.HasOne("EFSamurai.Domain.Samurai")
                        .WithOne("SecretIdentity")
                        .HasForeignKey("EFSamurai.Domain.SecretIdentity", "SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
