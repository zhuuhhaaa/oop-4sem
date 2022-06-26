using OOP_Lab02_3.Properties;
using System;
using System.Collections;
using System.Runtime.Serialization;

namespace OOP_Lab02_3
{
    public enum FileFormat
    {
        FB2 = 1,
        EPUB,
        TXT,
    }

    [DataContract]
    [FormYearValidation(2022)]
    public class BookFile
    { 
        [DataMember]
        private string name;
        [DataMember]
        private string author;
        [DataMember]
        private int    year;
        [DataMember]
        private int    bookSize;
        [DataMember]
        private string publisher;
        [DataMember]
        private FileFormat fileFormat;
        [DataMember]
        private float  fileSize;
        [DataMember]
        private DateTime uploadDate;
        
        // КОНСТРУКТОРЫ --------------------------------------------------------------------------

        public BookFile(string name, string author, int year, int bookSize, string publisher, FileFormat fileFormat, float fileSize, DateTime uploadDate)
        {
            Name = name;
            Author = author;
            Year = year;
            BookSize = bookSize;
            Publisher = publisher;
            FileFormat = fileFormat;
            FileSize = fileSize;
            UploadDate = uploadDate;
        }

        // СВОЙСТВА --------------------------------------------------------------------------

        public string Name {
            get => name;
            set => name = value;
            //{
            //    if (value.Length < 2)
            //        throw new Exception("Недопустимая длина Имени.");
            //    else
            //        name = value;
            //}
        }

        public string Author {
            get => author;
            set
            {
                if (value.Length < 1)
                    throw new Exception("Недопустимая длина Автора.");
                else
                    author = value;
            }
        }

        public int Year {
            get => year;
            set
            {
                 year = value;
            }
        }

        public int BookSize {
            get => bookSize;
            set
            {  
                if (value < 1)
                    throw new Exception("Недопустимое кол-во страниц.");
                else
                    bookSize = value;
            }
        }

        public string Publisher {
            get => publisher;
            set
            {
                if (value.Length < 2)
                    throw new Exception("Недопустимая длина Издательства.");
                else
                    publisher = value;
            }
        }

        public float FileSize {
            get => fileSize;
            set
            {
                if (value < 0.001)
                    throw new Exception("Недопустимый размер файла.");
                else
                    fileSize = value;
            }
        }

        public DateTime UploadDate {
            get => uploadDate;
            set => uploadDate = value;
        }
        internal FileFormat FileFormat {
            get => fileFormat;
            set => fileFormat = value;
        }

        // МЕТОДЫ --------------------------------------------------------------------------

        public int CompareTo(object obj)
        {
            return name.CompareTo(obj);
        }

        public static bool ValidateBook(BookFile book)
        {
            Type type = typeof(BookFile);
            // получаем все атрибуты класса Person
            object[] attributes = type.GetCustomAttributes(false);

            // проходим по всем атрибутам
            foreach (Attribute attr in attributes)
            {
                // если атрибут представляет тип AgeValidationAttribute
                if (attr is FormYearValidationAttribute yearAttribute)
                    // возвращаем результат проверки по year
                    return book.Year > 0 && book.Year <= yearAttribute.Year;
            }
            return true;
        }
    }
}
