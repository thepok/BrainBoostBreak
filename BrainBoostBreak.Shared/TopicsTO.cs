using System;
using System.Collections.Generic;
using System.Text;

namespace BrainBoostBreak.Shared
{
    class TopicsTO
    {
        TopicTO[] Topics;
    }

    class TopicTO
    {
        int Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        bool Enabled { get; set; }
    }
}
