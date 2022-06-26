using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OOP_Lab02_3.Properties;

namespace OOP_Lab02_3
{
    public partial class MainForm : Form
    {
        Library library = new Library("Библиотека");
        public MainForm()
        {
            InitializeComponent();
        }
        public class FormValidator
        {
            public static bool nameCheck(TextBox studentName)
            {
                if (String.IsNullOrEmpty(studentName.Text))
                {
                    MessageBox.Show("Пустое поле имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (studentName.Text.Length < 2)
                {
                    MessageBox.Show("Имя не может быть меньше 2-ух символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {

                    return true;
                }
            }

            public static bool publisherCheck(TextBox studentName)
            {
                if (String.IsNullOrEmpty(studentName.Text))
                {
                    MessageBox.Show("Пустое поле издатель!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (studentName.Text.Length < 2)
                {
                    MessageBox.Show("Издатель не может быть меньше 2-ух символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {

                    return true;
                }
            }
        }
        public bool isFormValid()
        {
            bool isFormCorrect = true;

            if (!FormValidator.nameCheck(inputNameField)) isFormCorrect = false;
            if (!FormValidator.publisherCheck(inputPublisherField)) isFormCorrect = false;
            //if (!FormValidator.yearCheck(inputYearField)) isFormCorrect = false;

            return isFormCorrect;

        }
        private void loadInFile_Click(object sender, EventArgs e)
        {
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Library));

                using (FileStream fs = new FileStream("library.json", FileMode.Truncate))
                {
                    jsonFormatter.WriteObject(fs, library);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void loadFromFile_Click(object sender, EventArgs e)
        {
            Library jsonLibrary;

            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Library));

                using (FileStream fs = new FileStream("library.json", FileMode.OpenOrCreate))
                {
                    jsonLibrary = (Library)jsonFormatter.ReadObject(fs);
                }
                List<BookFile> books = jsonLibrary.GetBookCollection();

                foreach (BookFile book in books)
                {
                    library.GetBookCollection().Add(book);
                    listBox.Items.Add("Название: " + book.Name + " | " + "Автор: " + book.Author);
                }
                listBox.Update();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            MessageBox.Show("Успешно загружено!", "Загрузка из файла.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool isFormCorrect = isFormValid();

            int year = 1000;
            float fileSize = 5000;
            // проверка воодимых данных
            while (isFormCorrect == true) {
                if (string.IsNullOrEmpty(inputNameField.Text) || string.IsNullOrEmpty(inputAuthorField.Text) ||
                    string.IsNullOrEmpty(inputYearField.Text) || string.IsNullOrEmpty(inputPublisherField.Text) ||
                    string.IsNullOrEmpty(inputFileSizeField.Text))
                {
                    MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isFormCorrect = false;
                }
                else if (!int.TryParse(inputYearField.Text, out year) || !float.TryParse(inputFileSizeField.Text, out fileSize))
                {
                    MessageBox.Show("Год или размер должен иметь числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isFormCorrect = false;
                }

                FileFormat format = FileFormat.FB2;
                if (rbFormat1.Checked)
                    format = FileFormat.FB2;
                if (rbFormat2.Checked)
                    format = FileFormat.EPUB;
                if (rbFormat3.Checked)
                    format = FileFormat.TXT;

                BookFile book = new BookFile(inputNameField.Text, inputAuthorField.Text, int.Parse(inputYearField.Text),
                    bookSizeTrackBar.Value, inputPublisherField.Text, format, int.Parse(inputFileSizeField.Text), System.DateTime.Now);

                if (!BookFile.ValidateBook(book))
                {
                    MessageBox.Show("Год от 0 до 2022", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isFormCorrect = false;
                }
                else
                {
                    library.AddBook(book);
                    listBox.Items.Add("Название: " + book.Name + " | " + "Автор: " + book.Author);
                    listBox.Update();
                    isFormCorrect = false;
                }
            }
        }

        private void bookSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            bookSizeLabel.Text = "Размер книги (" + bookSizeTrackBar.Value.ToString() + ")";
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 1.1.3\n", "About", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(library);
            searchForm.Activate();
            searchForm.Show();
        }
    }
}
