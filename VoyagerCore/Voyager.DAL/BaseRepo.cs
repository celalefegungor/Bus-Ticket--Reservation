using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.DAL
{
    public class BaseRepo<T> : IDisposable, IRepo<T> where T : class
    {

        private VoyagerContext db;

        public BaseRepo (DbContext voyageCtx)
        {
            db = (VoyagerContext)voyageCtx;
        }

        public T Add(T item)
        {
            return db.Set<T>().Add(item);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>().Where(predicate);
        }

        public IList<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            var propInfo = GetIdPropInfo();
            return db.Set<T>().SingleOrDefault(x => (int)propInfo.GetValue(x) == Id);
        }

        public void Remove(T item)
        {
            db.Set<T>().Remove(item);
        }

        public void Update(T item)
        {
            db.Entry<T>(item).State = System.Data.Entity.EntityState.Modified;
        }

        private PropertyInfo GetIdPropInfo()
        {
            var type = typeof(T);
            var result = "Id";
            return type.GetProperty(result);
        }
    }
}
