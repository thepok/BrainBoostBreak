using BrainBoostBreak.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoreLinq;
using Microsoft.EntityFrameworkCore;

namespace BrainBoostBreak.Server
{
    public class ProcedualQuestionGenerator
    {

        public static QuestionTO GenQuestion()
        {
            using (QuestionDatabase db=new QuestionDatabase())
            {
                var questions = db.Questions.Include(e=>e.Answer).ToArray();
                Random rnd = new Random(System.Environment.TickCount);
                var randomQuestion = questions[rnd.Next(questions.Length)];
                var answers = db.Answers.Where(a=>a.TopicId==randomQuestion.TopicId).Select(a => new AnswerTO() { Id = a.AnswerId, Text = a.Text }).Shuffle(rnd).Take(5).ToList();

                answers.Add(new AnswerTO() { Text = randomQuestion.Answer.Text, Id = randomQuestion.AnswerId });

                return new QuestionTO() {Text=randomQuestion.Text, Id= randomQuestion.QuestionId, Answers=answers.Shuffle().ToArray()};
            }
        }
    }
}
