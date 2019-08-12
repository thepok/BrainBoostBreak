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
            using (QuestionDatabase db = new QuestionDatabase())
            {
                var rnd = new Random();
                var toSkip = rnd.Next(0, db.Questions.Count() - 1);

                var question = db.Questions.Include(q=>q.Answer).OrderBy(r => Guid.NewGuid()).Skip(toSkip).Take(1).FirstOrDefault();
                var answers = db.Answers.Where(a=>a.TopicId==question.TopicId).Select(a => new AnswerTO() { Id = a.AnswerId, Text = a.Text }).Take(5).ToList();

                answers.Add(new AnswerTO() { Text = question.Answer.Text, Id = question.AnswerId });

                return new QuestionTO() {
                    Text =question.Text,
                    Id = question.QuestionId,
                    Answers =answers.Shuffle().ToArray(),
                    CorrectAnswerId=question.AnswerId
                };
            }
        }
    }
}
