using Questionnaire.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.Database
{
    public class QuestionnaireDbContext:DbContext,IDisposable
    {
        public QuestionnaireDbContext():base("name=ConnString")
        {

        }
        public DbSet<Answer> AnswersDb { get; set; }
        public DbSet<Question> QuestionsDb { get; set; }
        public DbSet<Theme> ThemesDb { get; set; }
    }
}
