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
    [Route("Result")]
    public class ResultController : ControllerBase
    {
        private readonly ILogger<BrainBoostBreakController> logger;

        public ResultController(ILogger<BrainBoostBreakController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("{QuestionId}/{AnswerId}")]
        public ResultTO Get(int  QuestionId, int AnswerId)
        {
            //Datenbank abfragen
            if ((QuestionId == 1 && AnswerId == 4) || (QuestionId == 2 && AnswerId == 2))
            {
                return new ResultTO() { Text = "Right" };
            }
            else
                return new ResultTO() { Text = "False" };
        }
    }
}
