using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.DAL
{
    public interface IRepo<T>
    {
        void Remove(T item);

        void Update(T item);
        T GetById(int Id);

        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

        T Add(T item);
        IList<T> GetAll();
    }
}
