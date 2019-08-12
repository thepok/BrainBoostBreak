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
    [Migration("20190812074152_AddTopicToAnswers")]
    partial class AddTopicToAnswers
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

                    b.Property<int>("TopicId");

                    b.Property<string>("Url");

                    b.HasKey("AnswerId");

                    b.HasIndex("TopicId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            AnswerId = 1,
                            Text = "Sokrates",
                            TopicId = -1
                        },
                        new
                        {
                            AnswerId = 2,
                            Text = "Platon",
                            TopicId = -1
                        },
                        new
                        {
                            AnswerId = 3,
                            Text = "Friedrich Nietzsche",
                            TopicId = -1
                        },
                        new
                        {
                            AnswerId = 4,
                            Text = "Paracelsus",
                            TopicId = -1
                        },
                        new
                        {
                            AnswerId = 5,
                            Text = "Erasmus von Rotterdam",
                            TopicId = -1
                        },
                        new
                        {
                            AnswerId = 6,
                            Text = "Baruch de Spinoza",
                            TopicId = -1
                        },
                        new
                        {
                            AnswerId = 7,
                            Text = "Mahatma Gandhi",
                            TopicId = -1
                        },
                        new
                        {
                            AnswerId = 8,
                            Text = "Fidel Castro",
                            TopicId = -1
                        },
                        new
                        {
                            AnswerId = 9,
                            Text = "Sokrates",
                            TopicId = -1
                        },
                        new
                        {
                            AnswerId = 10,
                            Text = "Platon",
                            TopicId = -1
                        },
                        new
                        {
                            AnswerId = 11,
                            Text = "Friedrich Nietzsche",
                            TopicId = -1
                        },
                        new
                        {
                            AnswerId = 12,
                            Text = "Paracelsus",
                            TopicId = -1
                        },
                        new
                        {
                            AnswerId = 13,
                            Text = "a",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 14,
                            Text = "b",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 15,
                            Text = "c",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 16,
                            Text = "d",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 17,
                            Text = "e",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 18,
                            Text = "f",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 19,
                            Text = "g",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 20,
                            Text = "h",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 21,
                            Text = "i",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 22,
                            Text = "j",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 23,
                            Text = "k",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 24,
                            Text = "l",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 25,
                            Text = "m",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 26,
                            Text = "n",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 27,
                            Text = "o",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 28,
                            Text = "p",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 29,
                            Text = "q",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 30,
                            Text = "r",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 31,
                            Text = "s",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 32,
                            Text = "t",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 33,
                            Text = "u",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 34,
                            Text = "v",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 35,
                            Text = "w",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 36,
                            Text = "x",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 37,
                            Text = "y",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 38,
                            Text = "z",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 39,
                            Text = "ä",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 40,
                            Text = "ü",
                            TopicId = -2
                        },
                        new
                        {
                            AnswerId = 41,
                            Text = "ö",
                            TopicId = -2
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
                            Text = "Wem wird folgendes Zitat zugeschrieben: 'Wer glaubt, etwas zu sein, hat aufgehört, etwas zu werden.'",
                            TopicId = -1
                        },
                        new
                        {
                            QuestionId = 2,
                            AnswerId = 7,
                            Text = "Wem wird folgendes Zitat zugeschrieben: 'Gewalt ist die Waffe des Schwachen.'",
                            TopicId = -1
                        },
                        new
                        {
                            QuestionId = 3,
                            AnswerId = 13,
                            Text = "A",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 4,
                            AnswerId = 14,
                            Text = "B",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 5,
                            AnswerId = 15,
                            Text = "C",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 6,
                            AnswerId = 16,
                            Text = "D",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 7,
                            AnswerId = 17,
                            Text = "E",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 8,
                            AnswerId = 18,
                            Text = "F",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 9,
                            AnswerId = 19,
                            Text = "G",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 10,
                            AnswerId = 20,
                            Text = "H",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 11,
                            AnswerId = 21,
                            Text = "I",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 12,
                            AnswerId = 22,
                            Text = "J",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 13,
                            AnswerId = 23,
                            Text = "K",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 14,
                            AnswerId = 24,
                            Text = "L",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 15,
                            AnswerId = 25,
                            Text = "M",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 16,
                            AnswerId = 26,
                            Text = "N",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 17,
                            AnswerId = 27,
                            Text = "O",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 18,
                            AnswerId = 28,
                            Text = "P",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 19,
                            AnswerId = 29,
                            Text = "Q",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 20,
                            AnswerId = 30,
                            Text = "R",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 21,
                            AnswerId = 31,
                            Text = "S",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 22,
                            AnswerId = 32,
                            Text = "T",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 23,
                            AnswerId = 33,
                            Text = "U",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 24,
                            AnswerId = 34,
                            Text = "V",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 25,
                            AnswerId = 35,
                            Text = "W",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 26,
                            AnswerId = 36,
                            Text = "X",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 27,
                            AnswerId = 37,
                            Text = "Y",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 28,
                            AnswerId = 38,
                            Text = "Z",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 29,
                            AnswerId = 39,
                            Text = "Ä",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 30,
                            AnswerId = 40,
                            Text = "Ü",
                            TopicId = -2
                        },
                        new
                        {
                            QuestionId = 31,
                            AnswerId = 41,
                            Text = "Ö",
                            TopicId = -2
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
                        },
                        new
                        {
                            TopicId = -2
                        });
                });

            modelBuilder.Entity("BrainBoostBreak.Server.Answer", b =>
                {
                    b.HasOne("BrainBoostBreak.Server.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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