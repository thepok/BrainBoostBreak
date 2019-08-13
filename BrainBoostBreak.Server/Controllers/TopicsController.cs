using BrainBoostBreak.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace BrainBoostBreak.Server.Controllers
{
    [ApiController]
    [Route("api/topics")]
    public class TopicsController : ControllerBase
    {
        private readonly ILogger<BrainBoostBreakController> logger;

        public TopicsController(ILogger<BrainBoostBreakController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public TopicsTO Get()
        {
            var topicsList = new List<TopicTO>();



            using (QuestionDatabase db = new QuestionDatabase())
            {
                var topics = db.Topics.AsNoTracking().ToArray();
                foreach (var ele in topics)
                {
                    topicsList.Add(new TopicTO() { Name = ele.Name, Description = "Desc missing", Enabled = true, Id = ele.TopicId });
                }
                return new TopicsTO() { Topics = topicsList.ToArray() };
            }
        }
    }
}
