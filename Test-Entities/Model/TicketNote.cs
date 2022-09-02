using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class TicketNote : IEntity
    {
        [Key]
        public int TicketNotesId { get; set; }
        virtual public User Sender { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }

        public int TicketId { get; set; }
    }
}
