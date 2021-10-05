using DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected  ApplicationContext _dBcotext { get; set; }

        public RepositoryBase(ApplicationContext dBContext)
        {
            _dBcotext = dBContext;
        }
        public void Create(T entity)
        {
            _dBcotext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _dBcotext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
            return _dBcotext.Set<T>().ToList();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _dBcotext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            this._dBcotext.Set<T>().Update(entity);
        }
    }
}
