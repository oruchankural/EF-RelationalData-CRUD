using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class TicketChatAttachment : IEntity
    {
        [Key]
        
        public int TicketChatAttachmentId { get; set; }


        public int TicketChatId { get; set; }
        public string TicketChatAttachmentPath { get; set; }
        public string TicketChatAttachmentName { get; set; }
    }
}
