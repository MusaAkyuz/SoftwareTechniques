using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDbContextGeneric.Repository
{
    internal class BaseEfRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public BaseEfRepository(DbContext context)
        {
            _context = context;
        }

        private DbSet<T> GetDbSet()
        {
            return _context.Set<T>();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return GetDbSet().AsEnumerable();
        }

        public void Delete(IStoreObject entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            GetDbSet().Attach((T)entity);
            GetDbSet().Remove((T)entity);
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }

        public void ExecuteSql(string query)
        {
            _context.Database.SetCommandTimeout(5000);
            using (var dbTran = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Database.ExecuteSqlRaw(query);
                    dbTran.Commit();
                }
                catch (Exception ex)
                {
                    dbTran.Rollback();
                }
            }
        }

        public T GetById(int id)
        {
            return GetDbSet().Find(id);
        }

        public void Insert(IStoreObject entity)
        {
            GetDbSet().Add((T)entity);
        }

        public void Update(IStoreObject entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            GetDbSet().Attach((T)entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
