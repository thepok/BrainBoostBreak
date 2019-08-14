using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainBoostBreak.Shared;

namespace BrainBoostBreak.Client
{
    public class BBBModel
    {
        public string Player { get; set; } = "DemoPlayer";
        public bool UseVoiceSystem { get; set; } = false;

        public TopicTO[] Topics { get; set; } = new TopicTO[0];

        public Random Rnd = new Random();
    }
}
