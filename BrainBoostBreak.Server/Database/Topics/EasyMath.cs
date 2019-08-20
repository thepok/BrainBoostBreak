using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainBoostBreak.Server.Database.Topics
{
    public class EasyMath
    {

        public static void InitData(ModelBuilder modelBuilder)
        {

            var topicLetters = new Topic() { TopicId = -5, Name = "Einfache Mathe" };

            modelBuilder.Entity<Topic>().HasData(topicLetters);

            QuestionCreator.Create("1 + 1", topicLetters, modelBuilder, "2");
            QuestionCreator.Create("1 + 2", topicLetters, modelBuilder, "3");
            QuestionCreator.Create("2 + 1", topicLetters, modelBuilder, "3");
            QuestionCreator.Create("2 + 3", topicLetters, modelBuilder, "5");
            QuestionCreator.Create("3 + 2", topicLetters, modelBuilder, "5");
            QuestionCreator.Create("1 + 1 + 1", topicLetters, modelBuilder, "3");
            QuestionCreator.Create("2 + 1 + 1", topicLetters, modelBuilder, "4");

            QuestionCreator.Create("1 + 2 + 1", topicLetters, modelBuilder, "4");
            QuestionCreator.Create("1 + 1 + 2", topicLetters, modelBuilder, "4");
            QuestionCreator.Create("2 + 2 + 1", topicLetters, modelBuilder, "5");
            QuestionCreator.Create("1 + 2 + 2", topicLetters, modelBuilder, "5");
            QuestionCreator.Create("2 + 1 + 2", topicLetters, modelBuilder, "5");
            QuestionCreator.Create("2 + 2 + 2", topicLetters, modelBuilder, "6");

        }
    }
}
