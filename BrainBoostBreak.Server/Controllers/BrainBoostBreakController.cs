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
    [Route("Question")]
    public class BrainBoostBreakController : ControllerBase
    {
        private readonly ILogger<BrainBoostBreakController> logger;

        public BrainBoostBreakController(ILogger<BrainBoostBreakController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public QuestionTO Get()
        {

#if DEBUG
            //Delay to Keep design
            System.Threading.Thread.Sleep(1000);
#endif
            return ProcedualQuestionGenerator.GenQuestion();
        }
    }
}
