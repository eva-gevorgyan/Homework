using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XndirN2
{
    internal class Answer : Phone
    {
        public string answer { get; set; }
        public Answer(string answer)
        {
            this.answer = answer;
        }
    }
}
