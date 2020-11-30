﻿// <auto-generated />
using System;
using Content.Server.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Content.Server.Database.Migrations.Sqlite
{
    [DbContext(typeof(SqliteServerDbContext))]
    partial class SqliteServerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("Content.Server.Database.Admin", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("user_id")
                        .HasColumnType("TEXT");

                    b.Property<int?>("AdminRankId")
                        .HasColumnName("admin_rank_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.HasIndex("AdminRankId");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("Content.Server.Database.AdminFlag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("admin_flag_id")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("AdminId")
                        .HasColumnName("admin_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Flag")
                        .IsRequired()
                        .HasColumnName("flag")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Negative")
                        .HasColumnName("negative")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("Flag", "AdminId")
                        .IsUnique();

                    b.ToTable("admin_flag");
                });

            modelBuilder.Entity("Content.Server.Database.AdminRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("admin_rank_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("admin_rank");
                });

            modelBuilder.Entity("Content.Server.Database.AdminRankFlag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("admin_rank_flag_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdminRankId")
                        .HasColumnName("admin_rank_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Flag")
                        .IsRequired()
                        .HasColumnName("flag")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdminRankId");

                    b.HasIndex("Flag", "AdminRankId")
                        .IsUnique();

                    b.ToTable("admin_rank_flag");
                });

            modelBuilder.Entity("Content.Server.Database.Antag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("antag_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AntagName")
                        .IsRequired()
                        .HasColumnName("antag_name")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfileId")
                        .HasColumnName("profile_id")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId", "AntagName")
                        .IsUnique();

                    b.ToTable("antag");
                });

            modelBuilder.Entity("Content.Server.Database.AssignedUserId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("assigned_user_id_id")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnName("user_name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("assigned_user_id");
                });

            modelBuilder.Entity("Content.Server.Database.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("job_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnName("job_name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnName("priority")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfileId")
                        .HasColumnName("profile_id")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("job");
                });

            modelBuilder.Entity("Content.Server.Database.Preference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("preference_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SelectedCharacterSlot")
                        .HasColumnName("selected_character_slot")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("preference");
                });

            modelBuilder.Entity("Content.Server.Database.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("profile_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnName("age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CharacterName")
                        .IsRequired()
                        .HasColumnName("char_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("EyeColor")
                        .IsRequired()
                        .HasColumnName("eye_color")
                        .HasColumnType("TEXT");

                    b.Property<string>("FacialHairColor")
                        .IsRequired()
                        .HasColumnName("facial_hair_color")
                        .HasColumnType("TEXT");

                    b.Property<string>("FacialHairName")
                        .IsRequired()
                        .HasColumnName("facial_hair_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("HairColor")
                        .IsRequired()
                        .HasColumnName("hair_color")
                        .HasColumnType("TEXT");

                    b.Property<string>("HairName")
                        .IsRequired()
                        .HasColumnName("hair_name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PreferenceId")
                        .HasColumnName("preference_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PreferenceUnavailable")
                        .HasColumnName("pref_unavailable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnName("sex")
                        .HasColumnType("TEXT");

                    b.Property<string>("SkinColor")
                        .IsRequired()
                        .HasColumnName("skin_color")
                        .HasColumnType("TEXT");

                    b.Property<int>("Slot")
                        .HasColumnName("slot")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PreferenceId");

                    b.HasIndex("Slot", "PreferenceId")
                        .IsUnique();

                    b.ToTable("profile");
                });

            modelBuilder.Entity("Content.Server.Database.SqliteConnectionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("connection_log_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Time")
                        .HasColumnName("time")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnName("user_name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("connection_log");
                });

            modelBuilder.Entity("Content.Server.Database.SqlitePlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("player_id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FirstSeenTime")
                        .HasColumnName("first_seen_time")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastSeenAddress")
                        .IsRequired()
                        .HasColumnName("last_seen_address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastSeenTime")
                        .HasColumnName("last_seen_time")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastSeenUserName")
                        .IsRequired()
                        .HasColumnName("last_seen_user_name")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LastSeenUserName");

                    b.ToTable("player");
                });

            modelBuilder.Entity("Content.Server.Database.SqliteServerBan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ban_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnName("address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BanTime")
                        .HasColumnName("ban_time")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BanningAdmin")
                        .HasColumnName("banning_admin")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ExpirationTime")
                        .HasColumnName("expiration_time")
                        .HasColumnType("TEXT");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnName("reason")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ban");
                });

            modelBuilder.Entity("Content.Server.Database.SqliteServerUnban", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("unban_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BanId")
                        .HasColumnName("ban_id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UnbanTime")
                        .HasColumnName("unban_time")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("UnbanningAdmin")
                        .HasColumnName("unbanning_admin")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BanId")
                        .IsUnique();

                    b.ToTable("unban");
                });

            modelBuilder.Entity("Content.Server.Database.Admin", b =>
                {
                    b.HasOne("Content.Server.Database.AdminRank", "AdminRank")
                        .WithMany("Admins")
                        .HasForeignKey("AdminRankId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("Content.Server.Database.AdminFlag", b =>
                {
                    b.HasOne("Content.Server.Database.Admin", "Admin")
                        .WithMany("Flags")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Content.Server.Database.AdminRankFlag", b =>
                {
                    b.HasOne("Content.Server.Database.AdminRank", "Rank")
                        .WithMany("Flags")
                        .HasForeignKey("AdminRankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Content.Server.Database.Antag", b =>
                {
                    b.HasOne("Content.Server.Database.Profile", "Profile")
                        .WithMany("Antags")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Content.Server.Database.Job", b =>
                {
                    b.HasOne("Content.Server.Database.Profile", "Profile")
                        .WithMany("Jobs")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Content.Server.Database.Profile", b =>
                {
                    b.HasOne("Content.Server.Database.Preference", "Preference")
                        .WithMany("Profiles")
                        .HasForeignKey("PreferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Content.Server.Database.SqliteServerUnban", b =>
                {
                    b.HasOne("Content.Server.Database.SqliteServerBan", "Ban")
                        .WithOne("Unban")
                        .HasForeignKey("Content.Server.Database.SqliteServerUnban", "BanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}