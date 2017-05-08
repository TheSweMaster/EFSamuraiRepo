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
    [Migration("20170508124001_MigrationSamuraiBattlesLogs2")]
    partial class MigrationSamuraiBattlesLogs2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFSamurai.Domain.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Brutal");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("EFSamurai.Domain.BattleEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BattleLogId");

                    b.HasKey("Id");

                    b.HasIndex("BattleLogId");

                    b.ToTable("BattleEvents");
                });

            modelBuilder.Entity("EFSamurai.Domain.BattleLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BattleId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BattleId")
                        .IsUnique();

                    b.ToTable("BattleLogs");
                });

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

            modelBuilder.Entity("EFSamurai.Domain.SamuraiBattles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BattleId");

                    b.Property<int>("SamuraiId");

                    b.HasKey("Id");

                    b.HasIndex("BattleId");

                    b.HasIndex("SamuraiId");

                    b.ToTable("SamuraiBattles");
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

                    b.ToTable("SecretIdentities");
                });

            modelBuilder.Entity("EFSamurai.Domain.BattleEvent", b =>
                {
                    b.HasOne("EFSamurai.Domain.BattleLog", "BattleLogs")
                        .WithMany("BattleEvents")
                        .HasForeignKey("BattleLogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFSamurai.Domain.BattleLog", b =>
                {
                    b.HasOne("EFSamurai.Domain.Battle", "Battles")
                        .WithOne("BattleLogs")
                        .HasForeignKey("EFSamurai.Domain.BattleLog", "BattleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFSamurai.Domain.Quote", b =>
                {
                    b.HasOne("EFSamurai.Domain.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId");
                });

            modelBuilder.Entity("EFSamurai.Domain.SamuraiBattles", b =>
                {
                    b.HasOne("EFSamurai.Domain.Battle", "Battles")
                        .WithMany("SamuraiBattles")
                        .HasForeignKey("BattleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFSamurai.Domain.Samurai", "Samurais")
                        .WithMany("SamuraiBattles")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFSamurai.Domain.SecretIdentity", b =>
                {
                    b.HasOne("EFSamurai.Domain.Samurai", "Samurai")
                        .WithOne("SecretIdentity")
                        .HasForeignKey("EFSamurai.Domain.SecretIdentity", "SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
