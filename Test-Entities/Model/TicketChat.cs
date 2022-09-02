using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class TicketChat : IEntity
    {
        [Key]
        public int TicketChatId { get; set; }

        public int TicketId { get; set; }
      
        public string Message { get; set; }
        public DateTime Time { get; set; }

        virtual public User Receiver { get; set; }

        virtual public User Sender { get; set; }
        virtual public List<TicketChatAttachment> TicketChatAttachments { get; set; }
    }
}
