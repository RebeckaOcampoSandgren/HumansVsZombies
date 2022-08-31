﻿// <auto-generated />
using System;
using HumansVsZombies_Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HumansVsZombies_Backend.Migrations
{
    [DbContext(typeof(HvZDbContet))]
    [Migration("20220831142144_initial-migration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Chat", b =>
                {
                    b.Property<int>("ChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ChatTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<bool>("IsHumanGlobal")
                        .HasColumnType("bit");

                    b.Property<bool>("IsZombieGlobal")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("SquadId")
                        .HasColumnType("int");

                    b.HasKey("ChatId");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("SquadId");

                    b.ToTable("Chat");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GameId1")
                        .HasColumnType("int");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GameState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NwLat")
                        .HasColumnType("float");

                    b.Property<double>("NwLng")
                        .HasColumnType("float");

                    b.Property<double>("SeLat")
                        .HasColumnType("float");

                    b.Property<double>("SeLng")
                        .HasColumnType("float");

                    b.HasKey("GameId");

                    b.HasIndex("GameId1");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Kill", b =>
                {
                    b.Property<int>("KillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("KillerId")
                        .HasColumnType("int");

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Lng")
                        .HasColumnType("float");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<string>("Story")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeOfDeath")
                        .HasColumnType("datetime2");

                    b.Property<int>("VictimId")
                        .HasColumnType("int");

                    b.HasKey("KillId");

                    b.HasIndex("GameId");

                    b.HasIndex("KillerId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("VictimId");

                    b.ToTable("Kill");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Mission", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<bool>("IsHumanVisible")
                        .HasColumnType("bit");

                    b.Property<bool>("IsZombieVisible")
                        .HasColumnType("bit");

                    b.Property<string>("MissionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("MissionId");

                    b.HasIndex("GameId");

                    b.ToTable("Mission");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BiteCode")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<bool>("IsHuman")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPatientZero")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Squad", b =>
                {
                    b.Property<int>("SquadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<bool>("IsHuman")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SquadId");

                    b.HasIndex("GameId");

                    b.ToTable("Squad");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.SquadCheckin", b =>
                {
                    b.Property<int>("SquadCheckinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Lng")
                        .HasColumnType("float");

                    b.Property<int>("SquadId")
                        .HasColumnType("int");

                    b.Property<int>("SquadMemberId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("SquadCheckinId");

                    b.HasIndex("GameId");

                    b.HasIndex("SquadId");

                    b.HasIndex("SquadMemberId");

                    b.ToTable("SquadCheckin");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.SquadMember", b =>
                {
                    b.Property<int>("SquadMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<int>("SquadId")
                        .HasColumnType("int");

                    b.HasKey("SquadMemberId");

                    b.HasIndex("GameId");

                    b.HasIndex("SquadId");

                    b.ToTable("SquadMember");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Chat", b =>
                {
                    b.HasOne("HumansVsZombies_Backend.Models.Game", "Game")
                        .WithMany("Chats")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumansVsZombies_Backend.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumansVsZombies_Backend.Models.Squad", "Squad")
                        .WithMany("Chats")
                        .HasForeignKey("SquadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Player");

                    b.Navigation("Squad");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Game", b =>
                {
                    b.HasOne("HumansVsZombies_Backend.Models.Game", null)
                        .WithMany("Games")
                        .HasForeignKey("GameId1");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Kill", b =>
                {
                    b.HasOne("HumansVsZombies_Backend.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumansVsZombies_Backend.Models.Player", "Killer")
                        .WithMany()
                        .HasForeignKey("KillerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumansVsZombies_Backend.Models.Player", null)
                        .WithMany("Kills")
                        .HasForeignKey("PlayerId");

                    b.HasOne("HumansVsZombies_Backend.Models.Player", "Victim")
                        .WithMany()
                        .HasForeignKey("VictimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Killer");

                    b.Navigation("Victim");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Mission", b =>
                {
                    b.HasOne("HumansVsZombies_Backend.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Player", b =>
                {
                    b.HasOne("HumansVsZombies_Backend.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumansVsZombies_Backend.Models.User", "User")
                        .WithMany("Players")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Squad", b =>
                {
                    b.HasOne("HumansVsZombies_Backend.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.SquadCheckin", b =>
                {
                    b.HasOne("HumansVsZombies_Backend.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumansVsZombies_Backend.Models.Squad", "Squad")
                        .WithMany("SquadCheckins")
                        .HasForeignKey("SquadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumansVsZombies_Backend.Models.SquadMember", "SquadMember")
                        .WithMany("SquadCheckins")
                        .HasForeignKey("SquadMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Squad");

                    b.Navigation("SquadMember");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.SquadMember", b =>
                {
                    b.HasOne("HumansVsZombies_Backend.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumansVsZombies_Backend.Models.Squad", "Squad")
                        .WithMany("SquadMembers")
                        .HasForeignKey("SquadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Squad");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Game", b =>
                {
                    b.Navigation("Chats");

                    b.Navigation("Games");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Player", b =>
                {
                    b.Navigation("Kills");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.Squad", b =>
                {
                    b.Navigation("Chats");

                    b.Navigation("SquadCheckins");

                    b.Navigation("SquadMembers");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.SquadMember", b =>
                {
                    b.Navigation("SquadCheckins");
                });

            modelBuilder.Entity("HumansVsZombies_Backend.Models.User", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
