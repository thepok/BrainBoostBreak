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

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Use negative PrimaryKeys to avoid conflicts with Database Sequenze generated Keys
            var topicZitate = new Topic() { TopicId = -1, Name = "Zitate" };

            var a1 = new Answer() { AnswerId = -1, Text = "abc" };
            var a2 = new Answer() { AnswerId = -2, Text = "abcd" };
            var a3 = new Answer() { AnswerId = -3, Text = "abce" };
            var a4 = new Answer() { AnswerId = -4, Text = "abcf" };

            modelBuilder.Entity<Topic>().HasData(topicZitate);

            modelBuilder.Entity<Answer>().HasData(a1, a2, a3, a4);

            modelBuilder.Entity<Question>().HasData(new Question() { QuestionId = -1, AnswerId = a1.AnswerId, Text = "bla bla?", TopicId = topicZitate.TopicId });

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
    }

    public class Topic
    {
        public int TopicId { get; set; }

        [Required]
        public string Name;
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

        public int AnswerId { get; set; }

        [Required]
        public Answer Answer { get; set; }

    }

    public enum ObjectTypeEnum
    {
        Answer = 1,
        Question = 0
    }

    public class Link
    {
        public int LinkId { get; set; }

        [Required]
        public int ObjectId { get; set; }

        [Required]
        public ObjectTypeEnum ObjectType { get; set; }

        [Required]
        public string Url { get; set; }
    }
}
