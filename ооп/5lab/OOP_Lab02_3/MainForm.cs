using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
                if (studentName.Text.Length < 2)
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
                if (studentName.Text.Length < 2)
                {
                    MessageBox.Show("Издатель не может быть меньше 2-ух символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {

                    return true;
                }
            }
            public static bool authorCheck(TextBox studentName)
            {
                if (studentName.Text.Length < 2)
                {
                    MessageBox.Show("Автор не может быть меньше 2-ух символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {

                    return true;
                }
            }

            public static bool YearCheck(TextBox years)
            {
                if (!int.TryParse(years.Text, out int year))
                {
                    MessageBox.Show("Год должен иметь числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (year > 2022 && year < 0)
                {
                    MessageBox.Show("Год от 0 до 2022", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (!FormValidator.authorCheck(inputAuthorField)) isFormCorrect = false;
            else if (!FormValidator.publisherCheck(inputPublisherField)) isFormCorrect = false;
            if (!FormValidator.YearCheck(inputYearField)) isFormCorrect = false;

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

        Random r = new Random(); 
        int k = 0;
        public List<BookFile.Memento> mementos = new List<BookFile.Memento>();
        private void addButton_Click(object sender, EventArgs e)
        {
            k++;
            bool isFormCorrect = isFormValid();
           
            // проверка воодимых данных
            while (isFormCorrect == true) {

                if (string.IsNullOrEmpty(inputNameField.Text) || string.IsNullOrEmpty(inputAuthorField.Text) ||
                                    string.IsNullOrEmpty(inputYearField.Text) || string.IsNullOrEmpty(inputPublisherField.Text) ||
                                    string.IsNullOrEmpty(inputFileSizeField.Text))
                {
                    MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isFormCorrect = false;
                }

                else
                {

                    FileFormat format = FileFormat.FB2;
                    if (rbFormat1.Checked)
                        format = FileFormat.FB2;
                    if (rbFormat2.Checked)
                        format = FileFormat.EPUB;
                    if (rbFormat3.Checked)
                        format = FileFormat.TXT;
                    
                    int rnd = r.Next();
                    BookFile book = null;
                    rnd %= 3;
                    switch(rnd)
                    {
                        case 0:
                             book = new BookFile(inputNameField.Text, inputAuthorField.Text, int.Parse(inputYearField.Text),
                bookSizeTrackBar.Value, inputPublisherField.Text, format, int.Parse(inputFileSizeField.Text), System.DateTime.Now);
                            break;
                        case 1:
                            book = new DetectiveBook(inputNameField.Text, inputAuthorField.Text, int.Parse(inputYearField.Text),
               bookSizeTrackBar.Value, inputPublisherField.Text, format, int.Parse(inputFileSizeField.Text), System.DateTime.Now);
                            break;
                        case 2:
                            book = new Document(inputNameField.Text, inputAuthorField.Text, int.Parse(inputYearField.Text),
               bookSizeTrackBar.Value, inputPublisherField.Text, format, int.Parse(inputFileSizeField.Text), System.DateTime.Now);
                            break;
                    }
                    Composite dec = new Composite();
                    dec.book = book;
                    book.SaveTo(mementos);
                    library.AddBook(dec.book);
                    listBox.Items.Add(dec.GetInfo());
                    listBox.Update();
                    isFormCorrect = false;

                }
            }
        }

        private void RestoreState_Click(object sender, EventArgs e)
        {
            BookFile book = new BookFile();
            int value = int.Parse(textBoxForRestore.Text);
            book.RestoreState(mementos[value]);
            listBox.Items.Add(book.GetInfo());
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

        private void button2_Click(object sender, EventArgs e)
        {
            SettingSingleton form1 = SettingSingleton.getInstance(BackColor, Font, Size);
            MessageBox.Show(form1.ToString(), "Информация об форме");
        }

        private void clon_btn_Click(object sender, EventArgs e)
        {
            FileFormat format = FileFormat.FB2;
            BookFile book = new BookFile(inputNameField.Text, inputAuthorField.Text, int.Parse(inputYearField.Text),
                    bookSizeTrackBar.Value, inputPublisherField.Text, format, int.Parse(inputFileSizeField.Text), System.DateTime.Now);
            book.Clone();
            library.AddBook(book);
            listBox.Items.Add("Название: " + book.Name + " | " + "Автор: " + book.Author + " | " + "Издательство: " + book.Publisher + " | " + "Год: " + book.Year + " | " + "Размер: " + book.FileSize);
            listBox.Update();

        }

        private void Director_button_Click(object sender, EventArgs e)
        {
            bool isFormCorrect = isFormValid();

            // проверка воодимых данных
            while (isFormCorrect == true)
            {

                if (!int.TryParse(inputYearField.Text, out int year) || !float.TryParse(inputFileSizeField.Text, out float fileSize))
                {
                    MessageBox.Show("Год или размер должен иметь числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isFormCorrect = false;
                }


                else
                {
                    BookFile book = Director.BuildOther(inputPublisherField.Text, inputNameField.Text, inputAuthorField.Text
                    );
                    library.AddBook(book);
                    listBox.Items.Add("Название: " + book.Name + " | " + "Автор: " + book.Author + " | " + "Издательство: " + book.Publisher + " | " + "Год: " + book.Year + " | " + "Размер: " + book.FileSize);

                    listBox.Update();
                    isFormCorrect = false;
                    //outputTextBox.Size = settings.FontSize;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void BookBook_Click(object sender, EventArgs e)
        {
            var factory = new ElectroBookFactory();
            factory.CreateBook();


        }
    }
}
