using InterfaceWithGeneric.GenericInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceWithGeneric
{
    internal class BaseClass<T> : IRepository<T> where T : class
    {
        public string ClassName()
        {
            return typeof(T).Name;
        }

        public void Print()
        {
            Console.WriteLine("Print");
        }

        public void Read()
        {
            Console.WriteLine("Read");
        }
    }
}
