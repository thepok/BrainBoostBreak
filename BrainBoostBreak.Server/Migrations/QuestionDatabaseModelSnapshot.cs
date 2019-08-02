﻿// <auto-generated />
using BrainBoostBreak.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BrainBoostBreak.Server.Migrations
{
    [DbContext(typeof(QuestionDatabase))]
    partial class QuestionDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.0.0-preview7.19362.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("BrainBoostBreak.Server.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("Answer");

                    b.Property<string>("Text");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}