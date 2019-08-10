using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainBoostBreak.Server.Database.Topics
{
    public class QuestionsQuote
    {
        public static void InitData(ModelBuilder modelBuilder, Topic topic)
        {
            QuestionCreator.Create(modelBuilder, topic, "Wer wird folgendes Zitat zugeschrieben: 'Wer glaubt, etwas zu sein, hat aufgehört, etwas zu werden.'", "Sokrates", "Platon", "Friedrich Nietzsche", "Paracelsus", "Erasmus von Rotterdam", "Baruch de Spinoza");
            QuestionCreator.Create(modelBuilder, topic, "Wer wird folgendes Zitat zugeschrieben: 'Gewalt ist die Waffe des Schwachen.'", "Mahatma Gandhi", "Fidel Castro", "Sokrates", "Platon", "Friedrich Nietzsche", "Paracelsus");

        }
    }
}
