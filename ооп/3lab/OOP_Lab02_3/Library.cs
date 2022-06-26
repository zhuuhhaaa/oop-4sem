using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OOP_Lab02_3
{
    [DataContract]
    public class Library
    {
        [DataMember]
        private string libraryName;
        [DataMember]
        private List<BookFile> booksList;

        public Library(string libraryName)
        {
            this.libraryName = libraryName;
            booksList = new List<BookFile>();
        }

        public List<BookFile> GetBookCollection()
        {
            return booksList;
        }

        public void AddBook(BookFile book)
        {
            booksList.Add(book);
        }

        public override string ToString()
        {
            return libraryName;
        }
    }
}
