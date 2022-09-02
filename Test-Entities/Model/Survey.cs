using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class Survey : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string Message { get; set; }
        
        
        virtual public List<AnswerQuestion> AnswerQuestion { get; set; }
    }
}
