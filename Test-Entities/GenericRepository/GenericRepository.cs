using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Test_Entities.Model;

namespace Test_Entities.GenericRepository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context();

            c.Remove(t);
            c.SaveChangesAsync();

        }

        public async Task<T> GetByIdAsync(int id)
        {
            using var c = new Context();

            return await c.Set<T>().FindAsync(id);

        }

        public async Task<List<T>> GetListAsync()
        {
            using var c = new Context();

            return await c.Set<T>().ToListAsync();

        }

        public async Task<List<T>> GetListByFilterAsync(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();

            return await c.Set<T>().Where(filter).ToListAsync();

        }

        public void Insert(T t)
        {
            using var c = new Context();

            c.AddAsync(t);
            c.SaveChangesAsync();

        }

        public void Update(T t)
        {
            using var c = new Context();

            c.Update(t);
            c.SaveChangesAsync();

        }
    }
}
