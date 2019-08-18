using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using Npgsql.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using BrainBoostBreak.Shared;
using BrainBoostBreak.Server.Database.Topics;

namespace BrainBoostBreak.Server
{
    public class QuestionDatabase : DbContext
    {
        public static int AnswerId = 1;
        public static int QuestionId = 1;

        public DbSet<Question> Questions { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Use negative PrimaryKeys to avoid conflicts with Database Sequenze generated Keys
            QuestionsQuote.InitData(modelBuilder);
            UpperAndLowercaseLetters.InitData(modelBuilder);
            UpperAndLowercaseLetters.InitDataMamaPapa(modelBuilder);
            EasyMath.InitData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql("User ID = BrainBoostBreak; Password = BrainBoostPW; Server = 127.0.0.1; Port = 5432; Database = BrainBoostBreak; Pooling = true;", opt => opt.CommandTimeout(300));
        }
    }

    public class Answer
    {
        public int AnswerId { get; set; }

        [Required]
        public string Text { get; set; }
        
        public string Url { get; set; }

        public string AnswerDescription { get; set; }

        [ForeignKey("Topic")]
        public int TopicId { get; set; }

        public Topic Topic { get; set; }
    }

    public class Topic
    {
        public int TopicId { get; set; }

        [Required]
        public string Name { get; set; }
    }

    public class Question
    {
        //Classname+"Id" at end is automatic primary Key
        public int QuestionId { get; set; }

        public int TopicId { get; set; }

        [Required]
        public Topic Topic { get; set; }

        [Required]
        public string Text { get; set; }

        public string VoiceText { get; set; }

        public int AnswerId { get; set; }

        [Required]
        public Answer Answer { get; set; }
    }
}
