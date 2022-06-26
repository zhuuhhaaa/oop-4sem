using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace OOP_Lab02_3
{
    public enum FileFormat
    {
        FB2 = 1,
        EPUB,
        TXT,
    }

    [DataContract]
    public class BookFile
    {
        // ПОЛЯ
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

        public BookFile()
        {
        }

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

        public string Name {
            get => name;
            set
            {
                if (value.Length < 2)
                    throw new Exception("Недопустимая длина Имени.");
                else
                    name = value;
            }
        }

        public string Author {
            get => author;
            set
            {
                if (value.Length < 2)
                    throw new Exception("Недопустимая длина Автора.");
                else
                    author = value;
            }
        }

        public int Year {
            get => year;
            set
            {
                    if (value < 0 || value > 2022)
                        MessageBox.Show("Год от 0 до 2022!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public string Publisher {
            get => publisher;
            set
            {
                
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
    }
}
