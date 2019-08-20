﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BrainBoostBreak.Shared
{
    public class QuestionTO
    {
        public string Text { get; set; }

        public string VoiceText { get; set; }

        public int Id { get; set; }

        public AnswerTO[] Answers { get; set; }

        public AnswerTO CorrectAnswer { get; set; }

    }
}
