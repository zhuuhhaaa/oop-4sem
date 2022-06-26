using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppinh_Cart.Models
{
    class ModelText
    {
        private string _path;
        private string _title;
        private string _color;
        private double _price;
        private string _desc;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public string Title
            { get { return _title; } set { _title = value; } }
        public double Price
            { get { return _price; } set { _price = value; } }
        public string Color
            { get { return _color; } set { _color = value; } }
        public string Description
        { get { return _desc; } set { _desc = value; } }
    }
}
