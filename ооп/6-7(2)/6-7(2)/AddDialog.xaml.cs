using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace _6_7_2_
{
    /// <summary>
    /// Логика взаимодействия для AddDialog.xaml
    /// </summary>
    /// 

    public partial class AddDialog : Window
    {
        private BindingList<Cloth> clothes;
        int index;
        public void Acctivate(BindingList<Cloth> c, int i)
        {
            clothes = c;
            index = i;
            if (index != -1)
            {
                TBName.Text = clothes[index].Name;
                TBDescription.Text = clothes[index].Description;
                TBCost.Text = clothes[index].Cost;
                TBCount.Text = clothes[index].Count;
                TBMatherial.Text = clothes[index].Matherial;
                TBImage.Text = clothes[index].ImageAdr;
            }
            Activate();
            Show();
        }

        public AddDialog()
        {
            InitializeComponent();
        }



        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {   
            if (String.IsNullOrEmpty(TBName.Text) != false)
            {
                System.Windows.MessageBox.Show("Для добавления элемента необходимо заполненное поле наименование", "Ошибка", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
            else if(!uint.TryParse(TBCost.Text, out uint cost) || !uint.TryParse(TBCount.Text, out uint count))
            {
                MessageBox.Show("Цена или количество должны содержать числовые значения больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Cloth cloth = new Cloth() { Name = TBName.Text, Description = TBDescription.Text, Matherial = TBMatherial.Text, Cost = TBCost.Text, Count = TBCount.Text, ImageAdr = TBImage.Text };
                if (index == -1 && clothes.Count > index)
                {
                    clothes.Add(cloth);
                }
                else
                {
                    clothes[index] = cloth;
                }
                Close();
            }
        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdPicture = new OpenFileDialog();
            ofdPicture.Filter =
                "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            ofdPicture.FilterIndex = 1;

            ofdPicture.ShowDialog();
            TBImage.Text = ofdPicture.FileName.Remove(0,27);
     
        }
    }
}
