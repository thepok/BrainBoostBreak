using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainBoostBreak.Server.Database.Topics
{
    public class QuestionsQuote
    {
        public static void InitData(ModelBuilder modelBuilder)
        {
            var topicQuote = new Topic() { TopicId = -1, Name = "Zitate" };

            modelBuilder.Entity<Topic>().HasData(topicQuote);

            QuestionCreator.Create("Wem wird folgendes Zitat zugeschrieben: 'Wer glaubt, etwas zu sein, hat aufgehört, etwas zu werden.'", topicQuote, modelBuilder, "Sokrates", "Platon", "Friedrich Nietzsche", "Paracelsus", "Erasmus von Rotterdam", "Baruch de Spinoza");
            QuestionCreator.Create("Wem wird folgendes Zitat zugeschrieben: 'Gewalt ist die Waffe des Schwachen.'", topicQuote, modelBuilder, "Mahatma Gandhi", "Fidel Castro", "Sokrates", "Platon", "Friedrich Nietzsche", "Paracelsus");
            QuestionCreator.Create("Wem wird folgendes Zitat zugeschrieben: 'Das Geld, das man besitzt, ist das Mittel zur Freiheit, dasjenige, dem man nachjagt, das Mittel zur Knechtschaft.'", topicQuote, modelBuilder, "Jean-Jacques Rousseau", "Fidel Castro", "Sokrates", "Platon", "Friedrich Nietzsche", "Paracelsus");
            QuestionCreator.Create("Wem wird folgendes Zitat zugeschrieben: 'Wir sind, was wir denken. Alles, was wir sind, entsteht aus unseren Gedanken. Mit unseren Gedanken formen wir die Welt.'", topicQuote, modelBuilder, "Siddhartha Gautama", "Fidel Castro", "Sokrates", "Platon", "Friedrich Nietzsche", "Paracelsus");
            QuestionCreator.Create("Wem wird folgendes Zitat zugeschrieben: 'Gegen eine Dummheit, die gerade in Mode ist, kommt keine Klugheit auf.'", topicQuote, modelBuilder, "Theodor Fontane", "Fidel Castro", "Sokrates", "Platon", "Friedrich Nietzsche", "Paracelsus");

        }
    }
}
