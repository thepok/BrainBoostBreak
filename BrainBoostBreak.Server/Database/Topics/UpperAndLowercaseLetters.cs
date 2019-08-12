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
                QuestionCreator.Create(modelBuilder, topicLetters, letter.ToUpper(), letter.ToLower());
            }
        }
    }
}
