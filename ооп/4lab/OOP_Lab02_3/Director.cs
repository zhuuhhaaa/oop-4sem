using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3
{
    public class Director
    {
        public static BookFile BuildBook(string name, string author, int year, string publisher, int bookSize,
            DateTime uploadDate)
        {
            Builder build = new Builder();

            build.BuildDate(uploadDate);
            build.BuildAuthor(author);
            build.BuildName(name);
            build.BuildPublising(publisher);
            build.BuildSize(bookSize);
            build.BuildYear(year);

            return build.book;

        }

        public static BookFile BuildSystem(DateTime date, string name, int year)
        {

            Builder build = new Builder();

            build.BuildDate(date);
            build.BuildName(name);
            build.BuildYear(year);
            return build.book;

        }

        public static BookFile BuildOther(string publisher, string name, string author)
        {

            Builder build = new Builder();

            build.BuildPublising(publisher);
            build.BuildName(name);
            build.BuildAuthor(author);


            return build.book;
        }
    }
}
