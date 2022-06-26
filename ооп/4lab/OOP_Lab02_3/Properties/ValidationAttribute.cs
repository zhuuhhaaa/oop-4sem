using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab02_3.Properties
{
    public class FormValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            BookFile book = value as BookFile;
            if (book.Author.Length == 3)
            {
                ErrorMessage = "Короткая длина автора";
                return false;
            }
            else if (book.Author.Length == 3)
            {
                ErrorMessage = "Короткая длина автора";
                return false;
            }
            return true;
        }

        public static bool Validate(BookFile book)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(book);
            if (!Validator.TryValidateObject(book, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
                return false;
            }
            else
            {
                MessageBox.Show("Все хорошо");
                return true;
            }
        }
    }
}
