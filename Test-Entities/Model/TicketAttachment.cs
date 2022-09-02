using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class TicketAttachment : IEntity
    {
        [Key]
        public int TicketAttachmentId { get; set; }
        // 150
        [MaxLength(400)]
        public string TicketAttachmentPath { get; set; }
        // 50
        [MaxLength(400)]
        public string TicketAttachmentName { get; set; }

        public int TicketId { get; set; }
    }
}
