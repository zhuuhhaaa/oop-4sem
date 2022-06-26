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
    public abstract class Prototype
    {
        [DataMember]
        public string name;
        [DataMember]
        [FormValidation]
        public string author;
        [DataMember]
        public int year;
        [DataMember]
        public int bookSize;
        [DataMember]
        public string publisher;
        [DataMember]
        public FileFormat fileFormat;
        [DataMember]
        public float fileSize;
        [DataMember]
        public DateTime uploadDate;
        

        public abstract Prototype Clone();
    }

    [DataContract]
    public class BookFile : Prototype
    {

        // КОНСТРУКТОРЫ -------------------------------------------------------------------------

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


        public BookFile()
        {

        }

        public BookFile(string name, string author, int year)
        {
            Name = name;
            Author = author;
            Year = year;
        }
        public override Prototype Clone()
        {
            return new BookFile(name, author, year, bookSize, publisher, fileFormat, fileSize, uploadDate);
        }

        // СВОЙСТВА --------------------------------------------------------------------------


        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 2)
                    throw new Exception("Недопустимая длина Имени.");
                else
                    name = value;
            }
        }

        public string Author
        {
            get => author;
            set
            {
                if (value.Length < 2)
                    throw new Exception("Недопустимая длина Автора.");
                else
                    author = value;
            }
        }
        public string Publisher
        {
            get => publisher;
            set
            {
                if (value.Length < 2)
                    throw new Exception("Недопустимая длина Издательства.");
                else
                    publisher = value;
            }
        }

        public float FileSize
        {
            get => fileSize;
            set
            {
                if (value < 0.001)
                    throw new Exception("Недопустимый размер файла.");
                else
                    fileSize = value;
            }
        }
        public int Year {
            get => year;
            set
            {
                if (value < 0 || value > 2022)
                    throw new Exception("Недопустимый год создания.");
                else
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

    }
}
