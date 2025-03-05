﻿// <auto-generated />
using System;
using HannaHabitsService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HannaHabitsService.Migrations
{
    [DbContext(typeof(HannaDbContext))]
    [Migration("20250129144744_Version_1")]
    partial class Version_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HannaHabitsService.Models.Completion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CompletionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("HabitId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("HabitId");

                    b.ToTable("Completions");
                });

            modelBuilder.Entity("HannaHabitsService.Models.DailyDiary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string[]>("GratefulThings")
                        .HasColumnType("text[]");

                    b.Property<string>("Highlight")
                        .HasColumnType("text");

                    b.Property<string[]>("LearnedThings")
                        .HasColumnType("text[]");

                    b.Property<float>("MentalMood")
                        .HasColumnType("real");

                    b.Property<int>("Mood")
                        .HasColumnType("integer");

                    b.Property<float>("PhysicalMood")
                        .HasColumnType("real");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DailyDiaries");
                });

            modelBuilder.Entity("HannaHabitsService.Models.DailyTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DailyDiaryId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DailyDiaryId");

                    b.ToTable("DailyTasks");
                });

            modelBuilder.Entity("HannaHabitsService.Models.Habit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.Property<int[]>("Schedules")
                        .HasColumnType("integer[]");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Habits");
                });

            modelBuilder.Entity("HannaHabitsService.Models.Resolution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("YearResolutionsId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("YearResolutionsId");

                    b.ToTable("Resolutions");
                });

            modelBuilder.Entity("HannaHabitsService.Models.YearResolution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("YearResolutions");
                });

            modelBuilder.Entity("HannaHabitsService.Models.Completion", b =>
                {
                    b.HasOne("HannaHabitsService.Models.Habit", "Habit")
                        .WithMany("Completions")
                        .HasForeignKey("HabitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habit");
                });

            modelBuilder.Entity("HannaHabitsService.Models.DailyTask", b =>
                {
                    b.HasOne("HannaHabitsService.Models.DailyDiary", "DailyDiary")
                        .WithMany("DailyTasks")
                        .HasForeignKey("DailyDiaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DailyDiary");
                });

            modelBuilder.Entity("HannaHabitsService.Models.Resolution", b =>
                {
                    b.HasOne("HannaHabitsService.Models.YearResolution", "YearResolutions")
                        .WithMany("Resolutions")
                        .HasForeignKey("YearResolutionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YearResolutions");
                });

            modelBuilder.Entity("HannaHabitsService.Models.DailyDiary", b =>
                {
                    b.Navigation("DailyTasks");
                });

            modelBuilder.Entity("HannaHabitsService.Models.Habit", b =>
                {
                    b.Navigation("Completions");
                });

            modelBuilder.Entity("HannaHabitsService.Models.YearResolution", b =>
                {
                    b.Navigation("Resolutions");
                });
#pragma warning restore 612, 618
        }
    }
}
