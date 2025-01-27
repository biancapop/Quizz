using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    internal class Deck
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Question> Questions { get; set; } = new List<Question>();
        public List<Quizz> Quizzes { get; set; } = new List<Quizz>();
    }
}
