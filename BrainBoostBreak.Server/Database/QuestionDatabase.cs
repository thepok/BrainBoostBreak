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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID = Datenbankbenutzer; Password = Datenbankbenutzerpasswort; Server = 127.0.0.1; Port = 5432; Database = DatenbankName; Pooling = true;", opt => opt.CommandTimeout(300));
        }
    }
    public class Question
    {
        //Classname+"Id" at end is automatic primary Key
        public int QuestionId { get; set; }

        public string Text { get; set; }

        public string Answer { get; set; }


    }
}
