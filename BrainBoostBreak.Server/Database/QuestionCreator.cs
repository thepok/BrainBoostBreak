using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainBoostBreak.Server.Database
{
    public class QuestionCreator
    {
        public static void Create(ModelBuilder modelBuilder, Topic topic, string question, params string[] answers)
        {
            var answerList = new List<Answer>();

            foreach (var answer in answers)
            {
                answerList.Add(new Answer { AnswerId = QuestionDatabase.AnswerId++, Text = answer });
            }

            modelBuilder.Entity<Answer>().HasData(answerList);

            modelBuilder.Entity<Question>().HasData(new Question() { QuestionId = QuestionDatabase.QuestionId++, AnswerId = answerList.FirstOrDefault().AnswerId, Text = question, TopicId = topic.TopicId }); ;
        }

        public static void Create(ModelBuilder modelBuilder, Topic topic, string question, params Answer[] answers)
        {
            modelBuilder.Entity<Answer>().HasData(answers);

            modelBuilder.Entity<Question>().HasData(new Question() { QuestionId = QuestionDatabase.QuestionId++, Answer = answers.FirstOrDefault(), Text = question, Topic = topic });
        }
    }
}
