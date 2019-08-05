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

namespace BrainBoostBreak.Server
{
    public class QuestionDatabase : DbContext
    {

        public DbSet<Question> Questions { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Answer> Answers { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID = BrainBoostBreak; Password = BrainBoostPW; Server = 127.0.0.1; Port = 5432; Database = BrainBoostBreak; Pooling = true;", opt => opt.CommandTimeout(300));
        }
    }
    public class Question
    {
        //Classname+"Id" at end is automatic primary Key
        public int QuestionId { get; set; }

        [Required]
        public Topic Topic {get; set;}

        [Required]
        public string Text { get; set; }

        [Required]
        public Answer Answer { get; set; }

    }

    public class Answer
    {
        public int AnswerId { get; set; }

        [Required]
        public string Text { get; set; }
    }

    public class Topic
    {
        public int TopicId {get; set;}

        [Required]
        public string Name;
    }
}
