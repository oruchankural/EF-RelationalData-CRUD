using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Business.Abstract
{
    public interface IGenericService<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        Task<List<T>> GetListAsync();
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetListByFilterAsync(Expression<Func<T, bool>> filter);
    }
}
