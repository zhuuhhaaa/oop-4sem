using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab02_3.Properties
{
    public class FormYearValidationAttribute: ValidationAttribute
    {
        public int Year { get; }
        public FormYearValidationAttribute(int year) => Year = year;
    }
}
