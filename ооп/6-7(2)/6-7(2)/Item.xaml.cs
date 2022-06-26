using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Shoppinh_Cart.UserControls
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();

        }


        static FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();

        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(Item), metadata, new ValidateValueCallback(ValidateValue));

        public string Count
        {

            get { return (string)GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }

        public static readonly DependencyProperty CountProperty = DependencyProperty.Register("Count", typeof(string), typeof(Item));

        private static bool ValidateValue(object value)
        {
            int currentValue = 0;
            if (value != null)
            {
                currentValue = (int)value;
            }
                if (currentValue >= 0) // если текущее значение от нуля и выше
                    return true;
                return false;
            
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
        
    }   
}