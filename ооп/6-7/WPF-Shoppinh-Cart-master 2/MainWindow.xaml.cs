using System.Windows;
using Shoppinh_Cart.UserControls;
using Shoppinh_Cart.Models;
using System.ComponentModel;
using System;

namespace Shoppinh_Cart
{
    public partial class MainWindow : Window
    {
        private BindingList<ModelText> toDataList ;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            toDataList = new BindingList<ModelText>();
            ListItems.ItemsSource = toDataList;
            toDataList.ListChanged += ToDataList_ListChanged;
        }

        public MainWindow()
        {
            InitializeComponent();
            Resources = new ResourceDictionary()
            {
                Source = new Uri(String.Format("../../Languages/StringResourcesUs.xaml"), UriKind.Relative)
            };
        }

        private void StackPanel_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == System.Windows.Input.MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void ToDataList_ListChanged(Object sender, ListChangedEventArgs e)
        {
            switch(e.ListChangedType)
            {
                case ListChangedType.ItemDeleted:
                case ListChangedType.ItemAdded:
                case ListChangedType.ItemChanged:
                    break;
            }
        }



        private void Button_MouseDownClose(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }

        private void Button_MouseDownHide(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }

        private void Button_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }

        private void ListItems_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {

        }

        public void Button_MouseDownDelete(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }
        public void Button_MouseDownPlusCounter(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }
        public void Button_MouseDownMinusCounter(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }
    }
}