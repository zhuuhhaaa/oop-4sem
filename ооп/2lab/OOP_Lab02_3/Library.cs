using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace OOP_Lab02_3
{
    [DataContract]
    public class Library
    {
        public static bool work = true;
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
        public static void Validatename(string str)
        {
            if (str.Length < 2)
                MessageBox.Show("Имя не может быть менее 2-ух символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            work = false;
        }
        public static void Validateauthor(string str)
        {
            if (str.Length < 2)
                MessageBox.Show("Автор не может быть менее 2-ух символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Validateyear(int _year)
        {
            if (_year < 0 || _year > 2022)

                MessageBox.Show("Год от 0 до 2022!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }  
        public static void Validatepublisher(int input)
        {
            if (input < 2)
                MessageBox.Show("Издательство не может быть менее 2-ух символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       
    }
}
