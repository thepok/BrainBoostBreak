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
            if (DateTime.Now.Millisecond % 2 == 0)
            {
                return new QuestionTO() { Id = 1, Text = "What is 5 + 5?", Answers = new AnswerTO[] { new AnswerTO() { Text = "10", Id = 1 }, new AnswerTO() { Text = "100", Id = 2 }, new AnswerTO() { Text = "50", Id = 3 }, new AnswerTO() { Text = "42", Id = 4 } } };
            }
            return new QuestionTO() { Id = 2, Text = "Hallo Echo?", Answers = new AnswerTO[] { new AnswerTO() { Text = "Hallo Du", Id = 1 }, new AnswerTO() { Text = "Hallo Otto", Id = 2 } } };
        }
    }
}
