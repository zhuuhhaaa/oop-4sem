using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3
{
    public interface ITarget
    {
        string StartWork();
    }
    public class Adapter : ITarget
    {
        private readonly BookFile book;
        public Adapter(BookFile _book)
        {
            book = _book;
        }
        public string StartWork()
        {
            return $"{book.Name} {book.Author}";
        }
    }
}
