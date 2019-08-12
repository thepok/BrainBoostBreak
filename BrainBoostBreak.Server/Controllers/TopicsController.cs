using BrainBoostBreak.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BrainBoostBreak.Server.Controllers
{
    [ApiController]
    [Route("topics")]
    public class TopicsController : ControllerBase
    {
        private readonly ILogger<BrainBoostBreakController> logger;

        public TopicsController(ILogger<BrainBoostBreakController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public ResultTO Get(int  QuestionId, int AnswerId)
        {
            //Datenbank abfragen

            using (QuestionDatabase db = new QuestionDatabase())
            {
                var question = db.Questions.Single(q => q.QuestionId == QuestionId);
                Console.WriteLine("Question was  " + question.Text);
                if (question.AnswerId == AnswerId)
                    return new ResultTO() { Correct = true, Text = "Richtig!" };
                else
                {
                    var answer = db.Answers.Single(a => a.AnswerId == question.AnswerId);
                    return new ResultTO() { Correct = false, Text = "Falsch! Richtig wäre " + answer.Text };
                }
            }
        }
    }
}
