using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    internal class Quizz
    {
        public int Id { get; set; }
        public int TimeInMinutes { get; set; } = 60;
        public List<Question> QuestionList { get; set; } = new List<Question>();
        public DateTime DateOfTheQuizz { get; set; }
    }
}
