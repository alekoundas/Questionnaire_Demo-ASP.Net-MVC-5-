using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.Entity
{
     public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionValue { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
