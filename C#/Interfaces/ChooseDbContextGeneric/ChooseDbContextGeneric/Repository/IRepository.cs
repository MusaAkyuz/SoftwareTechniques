using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDbContextGeneric.Repository
{
    internal interface IRepository : IDisposable
    {
        void Insert(IStoreObject entity);
        void Update(IStoreObject entity);
        void Delete(IStoreObject entity);
    }

    internal interface IRepository<T> : IRepository where T : class
    {
        void Commit();
        void ExecuteSql(string query);
        T GetById(int id);
        IEnumerable<T> GetAll();
        //...
    }
}
