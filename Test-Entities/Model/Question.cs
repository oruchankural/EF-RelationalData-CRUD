using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class Question : IEntity
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionDescription { get; set; }
    }
}
