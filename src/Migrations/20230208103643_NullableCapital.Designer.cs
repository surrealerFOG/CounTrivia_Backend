﻿// <auto-generated />
using System;
using CounTrivia.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CounTrivia.Migrations
{
    [DbContext(typeof(CounTriviaDbContext))]
    [Migration("20230208103643_NullableCapital")]
    partial class NullableCapital
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CounTrivia.Entities.Challenge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AnswerFormat")
                        .HasColumnType("int");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("CounTrivia.Entities.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("AlternativeAnswerForChallenge")
                        .HasColumnType("char(36)");

                    b.Property<float>("Area")
                        .HasColumnType("float");

                    b.Property<string>("CCA3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Capital")
                        .HasColumnType("longtext");

                    b.Property<string>("CommonName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("CorrectAnswerForChallenge")
                        .HasColumnType("char(36)");

                    b.Property<string>("OfficialName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Population")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AlternativeAnswerForChallenge");

                    b.HasIndex("CorrectAnswerForChallenge");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CounTrivia.Entities.Country", b =>
                {
                    b.HasOne("CounTrivia.Entities.Challenge", null)
                        .WithMany("AlternativeAnswers")
                        .HasForeignKey("AlternativeAnswerForChallenge");

                    b.HasOne("CounTrivia.Entities.Challenge", null)
                        .WithMany("CorrectAnswers")
                        .HasForeignKey("CorrectAnswerForChallenge");
                });

            modelBuilder.Entity("CounTrivia.Entities.Challenge", b =>
                {
                    b.Navigation("AlternativeAnswers");

                    b.Navigation("CorrectAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
