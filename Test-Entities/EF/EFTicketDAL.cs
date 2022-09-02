using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Test_Entities.GenericRepository;
using Test_Entities.Model;

namespace Test_Entities.EF
{
    public class EFTicketDAL : GenericRepository<Ticket>, ITicketDAL
    {
       
        public async Task<Ticket>  GetTicket(int id  , List<Expression<Func<Ticket,IEntity>> > expressionList)
        {
            using (var c = new Context())
            {
                var ticket = c.Tickets.Where(x => x.TicketId == id);
                foreach (var expression in expressionList)
                {
                    ticket.Include(expression);
                }
                return await ticket.SingleOrDefaultAsync();
                
            }
        }
    }
}
