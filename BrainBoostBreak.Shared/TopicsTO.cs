using System;
using System.Collections.Generic;
using System.Text;

namespace BrainBoostBreak.Shared
{
    public class TopicsTO
    {
        public TopicTO[] Topics { get; set; }
    }

    public class TopicTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Enabled { get; set; }
    }
}
