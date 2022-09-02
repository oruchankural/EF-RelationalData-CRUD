using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class AnswerQuestion : IEntity
    {
        [Key]
        public int AnswerQuestionId { get; set; }

        public int SurveyId { get; set; }

        virtual public Question Question { get; set; }
        virtual public Answer Answer { get; set; }

    }
}
