using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceWithGeneric.GenericInterface
{
    internal interface IRepository
    {
        void Print();
        void Read();
    }

    internal interface IRepository<T> : IRepository where T : class
    {
        string ClassName();
    }
}
