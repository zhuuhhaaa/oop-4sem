using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace _6_7_2_
{
    /// <summary>
    /// Логика взаимодействия для More.xaml
    /// </summary>
    public partial class More : Window
    {
        private Cloth cloth;
        public void Acctivate(Cloth c)
        {
            cloth = c;

            TBName.Text = cloth.Name;
            TBDescription.Text = cloth.Description;
            TBCost.Text = cloth.Cost;
            TBCount.Text = cloth.Count;
            TBMatherial.Text = cloth.Matherial;
            var uri = new Uri(cloth.ImageAdr, UriKind.Relative);
            var bitmap = new BitmapImage(uri);
            TBImage.Source = bitmap;
            Activate();
            Show();
        }

            public More()
        {
            InitializeComponent();

        }

        public void English(object sender, RoutedEventArgs e)
        {
            TImage.Text = "nt";
            TName.Text = "Наименование";
        }
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(TBName.Text) != false)
            {
                MessageBox.Show("Для редактирования элемента необходимо заполненное поле наименование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(TBCost.Text, out int cost) || !int.TryParse(TBCount.Text, out int count))
            {
                MessageBox.Show("Цена или количество должны содержать числовые значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }
    }
}
