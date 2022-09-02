using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Test_Entities.Business.Abstract;
using Test_Entities.GenericRepository;
using Test_Entities.Model;

namespace Test_Entities.Business.Concrete
{
    public class TicketManager : ITicketService
    {
        ITicketDAL dalObject;

        public TicketManager(ITicketDAL dalObject)
        {
            this.dalObject = dalObject;
        }
        public void Delete(Ticket t)
        {
            dalObject.Delete(t);
        }

        public async Task<Ticket> GetByIdAsync(int id)
        {
            return await dalObject.GetByIdAsync(id);
        }

        public async Task<List<Ticket>> GetListAsync()
        {
            return await dalObject.GetListAsync();
        }

        public async Task<List<Ticket>> GetListByFilterAsync(Expression<Func<Ticket, bool>> filter)
        {
            return await dalObject.GetListByFilterAsync(filter);
        }

        public async Task<Ticket> GetTicket(int id, List<Expression<Func<Ticket, IEntity>>> expressionList)
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

        public void Insert(Ticket t)
        {
            dalObject.Insert(t);
        }

        public void Update(Ticket t)
        {
            dalObject.Update(t);
        }
    }
}
