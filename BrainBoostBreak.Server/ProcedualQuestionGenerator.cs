using BrainBoostBreak.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainBoostBreak.Server
{
    public class ProcedualQuestionGenerator
    {

        public static QuestionTO GenQuestion()
        {
            using (QuestionDatabase db=new QuestionDatabase())
            {
                var questions = db.Questions.ToArray();
                Random rnd = new Random(System.Environment.TickCount);
                var randomQuestion = questions[rnd.Next(questions.Length)];
                return new QuestionTO() {Text=randomQuestion.Text, Id= randomQuestion.QuestionId,Answers=
                    db.Answers.Take(5).Select(a=>new AnswerTO() { Id = a.AnswerId, Text = a.Text}).ToArray() };
            }
        }
    }
}
