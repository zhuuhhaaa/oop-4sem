using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Shoppinh_Cart.UserControls
{
    public partial class Item : UserControl, INotifyPropertyChanged
    {
        public Item()
        {
            InitializeComponent();
        }
  
        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(Item));


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Item));


        public string Ref
        {
            get { return (string)GetValue(RefProperty); }
            set { SetValue(RefProperty, value); }
        }

        public static readonly DependencyProperty RefProperty = DependencyProperty.Register("Ref", typeof(string), typeof(Item));


        public string Color
        {
            get { return (string)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Color", typeof(string), typeof(Item));


        public string Count
        {
            get { return (string)GetValue(CountProperty); }
            set { SetValue(CountProperty, value); OnPropertyChanged("count"); }
        }

        public static readonly DependencyProperty CountProperty = DependencyProperty.Register("Count", typeof(string), typeof(Item));


        public string Price
        {
            get { return (string)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        public static readonly DependencyProperty PriceProperty = DependencyProperty.Register("Price", typeof(string), typeof(Item));

        public void Button_MouseDownDelete(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ItemGrid.Visibility = Visibility.Collapsed;
        }
        public void Button_MouseDownPlusCounter(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int temp = int.Parse(Count);
            temp++;
            Count = temp.ToString();
        }
        public void Button_MouseDownMinusCounter(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int temp = int.Parse(Count);
            if (temp != 1)
            {
                temp--;
                Count = temp.ToString();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}