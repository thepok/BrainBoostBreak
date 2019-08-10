﻿// <auto-generated />
using BrainBoostBreak.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrainBoostBreak.Server.Migrations
{
    [DbContext(typeof(QuestionDatabase))]
    [Migration("20190810214914_test2")]
    partial class test2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("BrainBoostBreak.Server.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnswerDescription");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<string>("Url");

                    b.HasKey("AnswerId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            AnswerId = 1,
                            Text = "Sokrates"
                        },
                        new
                        {
                            AnswerId = 2,
                            Text = "Platon"
                        },
                        new
                        {
                            AnswerId = 3,
                            Text = "Friedrich Nietzsche"
                        },
                        new
                        {
                            AnswerId = 4,
                            Text = "Paracelsus"
                        },
                        new
                        {
                            AnswerId = 5,
                            Text = "Erasmus von Rotterdam"
                        },
                        new
                        {
                            AnswerId = 6,
                            Text = "Baruch de Spinoza"
                        },
                        new
                        {
                            AnswerId = 7,
                            Text = "Mahatma Gandhi"
                        },
                        new
                        {
                            AnswerId = 8,
                            Text = "Fidel Castro"
                        },
                        new
                        {
                            AnswerId = 9,
                            Text = "Sokrates"
                        },
                        new
                        {
                            AnswerId = 10,
                            Text = "Platon"
                        },
                        new
                        {
                            AnswerId = 11,
                            Text = "Friedrich Nietzsche"
                        },
                        new
                        {
                            AnswerId = 12,
                            Text = "Paracelsus"
                        });
                });

            modelBuilder.Entity("BrainBoostBreak.Server.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnswerId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<int>("TopicId");

                    b.HasKey("QuestionId");

                    b.HasIndex("AnswerId");

                    b.HasIndex("TopicId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            AnswerId = 1,
                            Text = "Wer wird folgendes Zitat zugeschrieben: 'Wer glaubt, etwas zu sein, hat aufgehört, etwas zu werden.'",
                            TopicId = -1
                        },
                        new
                        {
                            QuestionId = 2,
                            AnswerId = 7,
                            Text = "Wer wird folgendes Zitat zugeschrieben: 'Gewalt ist die Waffe des Schwachen.'",
                            TopicId = -1
                        });
                });

            modelBuilder.Entity("BrainBoostBreak.Server.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("TopicId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicId = -1
                        });
                });

            modelBuilder.Entity("BrainBoostBreak.Server.Question", b =>
                {
                    b.HasOne("BrainBoostBreak.Server.Answer", "Answer")
                        .WithMany()
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BrainBoostBreak.Server.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
