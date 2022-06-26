using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OOP_Lab02_3
{
    public enum SearchFormat
    {
        LINQ = 0,
        REGEX
    }
    public partial class SearchForm : Form
    {
        private SearchFormat searchFormat = SearchFormat.LINQ;

        public SearchForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void inputBookTitle_TextChanged(object sender, EventArgs e)
        {
            if (searchFormat == SearchFormat.LINQ)
            {
                var search = library.GetBookCollection().Where(x => x.Name == inputBookTitle.Text.ToString());
       
                listBoxSearchResult.Items.Clear();
                foreach (BookFile item in search)
                {
                    listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author);
                }
                listBoxSearchResult.Update();

                labelFound.Text = "Found: " + listBoxSearchResult.Items.Count.ToString();
            }
            else if(searchFormat == SearchFormat.REGEX)
            {
                var search = library.GetBookCollection().Where(x => regCheck(x.Name, inputBookTitle.Text.ToString()));

                listBoxSearchResult.Items.Clear();
                foreach (BookFile item in search)
                {
                    listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author + " | " + "Год издания: " + item.Year + " | " + "Всего страниц: " + item.BookSize);
                }
                listBoxSearchResult.Update();

                labelFound.Text = "Found: " + listBoxSearchResult.Items.Count.ToString();
            }
        }

        private bool regCheck(string sorce, string substr)
        {
            substr = substr.Trim();
            string[] words = Regex.Split(substr, @"\s+");

            string regex = "";
            foreach (string item in words)
            {
                regex += (item + "|");
            }

            regex = regex.Remove(regex.Length-1);
            Regex reg = new Regex(regex);
          
            return Regex.IsMatch(sorce, regex);
        }

        private void btnYearSort_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
            var sorted = library.GetBookCollection().OrderByDescending(u => u.Year);
            foreach (BookFile item in sorted)
            {
                listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author + " | " + "Год издания: " + item.Year + " | " + "Всего страниц: " + item.BookSize);
            }
            listBoxSearchResult.Update();
        }

        private void btnPageSort_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
            var sorted = library.GetBookCollection().OrderByDescending(u => u.BookSize);
            foreach (BookFile item in sorted)
            {
                listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author + " | " + "Год издания: " + item.Year + " | " + "Всего страниц: " + item.BookSize);
            }
            listBoxSearchResult.Update();
        }

        private void btnUploadSort_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
            var sorted = library.GetBookCollection().OrderByDescending(u => u.UploadDate);
            foreach (BookFile item in sorted)
            {
                listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author + " | "  + item.UploadDate + " | " + "Страниц: " + item.BookSize);
            }
            listBoxSearchResult.Update();
        }

        private void rbSearchFormat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLinq.Checked)
            {
                searchFormat = SearchFormat.LINQ;
            }
            else if (rbRegex.Checked)
            {
                searchFormat = SearchFormat.REGEX;
            }
        }
    }
}
