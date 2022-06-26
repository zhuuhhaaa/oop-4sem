using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _6_7_2_
{

    public partial class Search : Window
    {
        private BindingList<Cloth> bList = new BindingList<Cloth>();
        private BindingList<Cloth> clothes;
        int index;
        public void Acctivate(BindingList<Cloth> c, int i)
        {
            index = i;

            clothes = c;
            DGClothes.ItemsSource = clothes;
            Activate();
            Show();

        }

        public Search()
        {
            InitializeComponent();
        }

        private void DataGridHyperlinkColumn_Click(object sender, RoutedEventArgs e)
        {
            int index = DGClothes.SelectedIndex;

            More dlg = new More();
            dlg.Acctivate(clothes[index]);
        }
    }
}
