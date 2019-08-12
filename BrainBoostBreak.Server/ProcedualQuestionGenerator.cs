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
            using (QuestionDatabase db = new QuestionDatabase())
            {
                var rnd = new Random();
                var toSkip = rnd.Next(0, db.Questions.Count() - 1);

                var q = db.Questions.OrderBy(r => Guid.NewGuid()).Skip(toSkip).Take(1).FirstOrDefault();

                return new QuestionTO()
                {
                    Text = q.Text,
                    Id = q.QuestionId,
                    Answers = db.Answers.Take(5).Select(a => new AnswerTO() { Id = a.AnswerId, Text = a.Text }).ToArray()
                };
            }
        }
    }
}
