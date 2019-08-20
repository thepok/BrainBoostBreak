using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainBoostBreak.Server.Database.Topics
{
    public class UpperAndLowercaseLetters
    {
        public static void InitData(ModelBuilder modelBuilder)
        {

            var topicLetters = new Topic() { TopicId = -2, Name = "Buchstaben lernen" };

            modelBuilder.Entity<Topic>().HasData(topicLetters);


            var abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZÄÜÖ";

            foreach (var letter in abc.Select(c=>c.ToString()))
            {
                QuestionCreator.Create(letter.ToUpper(), topicLetters, modelBuilder, letter.ToLower());
            }
        }

        public static void InitDataMamaPapa(ModelBuilder modelBuilder)
        {

            var topicLetters = new Topic() { TopicId = -3, Name = "Mama und Papa" };

            modelBuilder.Entity<Topic>().HasData(topicLetters);

            QuestionCreator.Create("M", topicLetters, modelBuilder, "M");
            QuestionCreator.Create("a", topicLetters, modelBuilder, "a");
            QuestionCreator.Create("Ma", topicLetters, modelBuilder, "Ma");
            QuestionCreator.Create("Mama", topicLetters, modelBuilder, "Mama");
            QuestionCreator.Create("P", topicLetters, modelBuilder, "P");
            QuestionCreator.Create("Pa", topicLetters, modelBuilder, "Pa");
            QuestionCreator.Create("Papa", topicLetters, modelBuilder, "Papa");

            QuestionCreator.Create("i", topicLetters, modelBuilder, "i");
            QuestionCreator.Create("pi", topicLetters, modelBuilder, "pi");
            QuestionCreator.Create("mi", topicLetters, modelBuilder, "mi");
            QuestionCreator.Create("Papi", topicLetters, modelBuilder, "Papi");
            QuestionCreator.Create("Mami", topicLetters, modelBuilder, "Mami");
            QuestionCreator.Create("Mam", topicLetters, modelBuilder, "Mam");

            topicLetters = new Topic() { TopicId = -4, Name = "Mama und Papa ohne Hilfe" };

            modelBuilder.Entity<Topic>().HasData(topicLetters);

            QuestionCreator.Create("", "M", topicLetters, modelBuilder, "M");
            QuestionCreator.Create("", "a", topicLetters, modelBuilder, "a");
            QuestionCreator.Create("", "Ma", topicLetters, modelBuilder, "Ma");
            QuestionCreator.Create("", "Mama", topicLetters, modelBuilder, "Mama");
            QuestionCreator.Create("", "P", topicLetters, modelBuilder, "P");
            QuestionCreator.Create("", "Pa", topicLetters, modelBuilder, "Pa");
            QuestionCreator.Create("", "Papa", topicLetters, modelBuilder, "Papa");

            QuestionCreator.Create("", "i", topicLetters, modelBuilder, "i");
            QuestionCreator.Create("", "pi", topicLetters, modelBuilder, "pi");
            QuestionCreator.Create("", "mi", topicLetters, modelBuilder, "mi");
            QuestionCreator.Create("", "Papi", topicLetters, modelBuilder, "Papi");
            QuestionCreator.Create("", "Mami", topicLetters, modelBuilder, "Mami");
            QuestionCreator.Create("", "Mam", topicLetters, modelBuilder, "Mam");


        }
    }
}
