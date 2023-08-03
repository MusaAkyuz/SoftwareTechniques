using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasic
{
    internal class File : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Read file");
        }

        public void WriteFile()
        {
            Console.WriteLine("Write file");
        }

        public void SearchFile()
        {
            Console.WriteLine("Search file");
        }
    }
}
