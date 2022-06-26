using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3
{
    public interface IBuilder
    {
        void BuildName(string name);
        void BuildAuthor(string author);
        void BuildSize(int pages);
        void BuildPublising(string publising);
        void BuildDate(DateTime time);
        void BuildYear(int year);

    }

    public class Builder : IBuilder
    {
        public BookFile book = new BookFile();

        public void BuildDate(DateTime time)
        {
            book.UploadDate = time;
        }

        public void BuildAuthor(string author)
        {
            book.Author = author;
        }

        public void BuildName(string name)
        {
            book.Name = name;
        }

        public void BuildPublising(string publising)
        {
            book.Publisher = publising;
        }

        public void BuildSize(int size)
        {
            book.BookSize = size;
        }

        public void BuildYear(int year)
        {
            book.Year = year;
        }
    }
}
