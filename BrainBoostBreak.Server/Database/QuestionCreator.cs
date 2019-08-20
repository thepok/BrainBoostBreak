using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainBoostBreak.Server.Database
{
    public class QuestionCreator
    {

        public static void Create(string question, string voiceText, Topic topic, ModelBuilder modelBuilder, params string[] answers)
        {
            var answerList = new List<Answer>();

            foreach (var answer in answers)
            {
                answerList.Add(new Answer { AnswerId = QuestionDatabase.AnswerId++, Text = answer, TopicId = topic.TopicId });
            }

            modelBuilder.Entity<Answer>().HasData(answerList);

            modelBuilder.Entity<Question>().HasData(new Question() { QuestionId = QuestionDatabase.QuestionId++, VoiceText=voiceText, AnswerId = answerList.FirstOrDefault().AnswerId, Text = question, TopicId = topic.TopicId }); ;
        }

        public static void Create(string question, Topic topic, ModelBuilder modelBuilder, params string[] answers)
        {
            Create(question, question, topic ,modelBuilder, answers);
        }

    }
}
