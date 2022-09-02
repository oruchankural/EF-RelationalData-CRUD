using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class Answer : IEntity
    {
        [Key]
        public int AnswerId { get; set; }
        public string AnswerDescription { get; set; }
    }
}
