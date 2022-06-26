using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab02_3
{
    public class SettingSingleton
    {
        private static SettingSingleton form1Information;

        public Color BackgroundColor { get; private set; }
        public Font WindowFont { get; private set; }
        public Size WindowSize { get; private set; }

        protected SettingSingleton(Color color, Font font, Size size)
        {
            this.BackgroundColor = color;
            this.WindowFont = font;
            this.WindowSize = size;
        }

        public static SettingSingleton getInstance(Color color, Font font, Size size)
        {
            if (form1Information == null)
                form1Information = new SettingSingleton(color, font, size);
            return form1Information;
        }

        public override string ToString()
        {
            return "Цвет фона: " + this.BackgroundColor.Name + "\nШрифт: " + this.WindowFont.Name + "\nРазмер окна: " + this.WindowSize.Width + "x" + this.WindowSize.Height;
        }


    }
}
