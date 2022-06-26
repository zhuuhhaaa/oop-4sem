using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3
{
    public class ElectroBookFactory : IAbstractFactory
    {
        public BookFile CreateBook()
        {

            return new BookFile("Electrobook","123",2002);
        }
    }
}
