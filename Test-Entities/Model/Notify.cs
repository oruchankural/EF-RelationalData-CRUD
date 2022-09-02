using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class Notify
    {
        [Key]
        public int NotifyId { get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; }
        public bool Showed { get; set; }
        public bool Sounded { get; set; }

        public int? UserId { get; set; }
        virtual public User User {get;set;}
        public int?  TicketId { get; set; }
        virtual public Ticket Ticket { get; set; }
    }
}
