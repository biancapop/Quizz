using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    internal class Question
    {
        public int Id { get; set; }
        public string Statement { get; set; } = "";
        public string StatementImage { get; set; } = "";
        public string Response { get; set; } = "";
        public string ResponseImage { get; set; } = "";

        public Dictionary<DateTime, bool> History { get; set; } = new Dictionary<DateTime, bool>();
        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
