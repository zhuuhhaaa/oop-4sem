using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.IO;
using _6_7_2_.Services;
using System.Windows.Input;
using System.Linq;

using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace _6_7_2_
{
    public partial class MainWindow : Window
    {
        public static RoutedCommand Exit { get; set; }

        private int ind;
        private List<BindingList<Cloth>> cloth_Data;
        private readonly string PATH = $"{Environment.CurrentDirectory}\\dataList.json";
        private bool bUp;
        private IOservice _IOservice;

        public BindingList<Cloth> DeepCopy(BindingList<Cloth> list)
        {
            var bList = new BindingList<Cloth>();

            foreach (var item in list)
            {
                bList.Add(new Cloth() { Cost=item.Cost, Count = item.Count, Description = item.Description, HyperlinkText = item.HyperlinkText, ImageAdr = item.ImageAdr, Matherial = item.Matherial, Name=item.Name});
            }
            return bList;
        }

        public MainWindow()
        {
            InitializeComponent();
            ind = 0;
            BtnRedo.IsEnabled = false;
            BtnUndo.IsEnabled = false;

            _IOservice = new IOservice(PATH);
            cloth_Data = new List<BindingList<Cloth>>
            {
                new BindingList<Cloth>()
            };
            cloth_Data[ind] = _IOservice.cloth_Data();
            DGClothes.ItemsSource = cloth_Data[ind];

            CommandBinding commandBinding = new CommandBinding();
            commandBinding.Command = ApplicationCommands.Help;
            commandBinding.Executed += CommandBinding_Executed;
            helpButton.Command = ApplicationCommands.Help;

        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string value = ucItem.Count;
            Int32.TryParse(value, out int a);
            int index = a - 1;
            cloth_Data.Add(DeepCopy(cloth_Data[ind]));
            ind++;

            if (cloth_Data[ind].Count > index && index > -1)
            {
                cloth_Data[ind].RemoveAt(index);
                DGClothes.ItemsSource = cloth_Data[ind];
                BtnUndo.IsEnabled = true;
            }
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            int index = DGClothes.SelectedIndex;
            cloth_Data.Add( DeepCopy(cloth_Data[ind]));
            ind++;
            
            if (cloth_Data[ind].Count > index && index>-1)
            {
                cloth_Data[ind].RemoveAt(index);
                DGClothes.ItemsSource = cloth_Data[ind];
                BtnUndo.IsEnabled = true;
            }
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            int index = DGClothes.SelectedIndex;
            AddDialog dlg = new AddDialog();
            
            cloth_Data.Add(DeepCopy(cloth_Data[ind]));
            
            ind++;
            if (index > cloth_Data[ind].Count - 1)
            {
                dlg.Acctivate(cloth_Data[ind], -1);
                DGClothes.ItemsSource = cloth_Data[ind];
                BtnUndo.IsEnabled = true;
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            int index = DGClothes.SelectedIndex;

            cloth_Data.Add(DeepCopy(cloth_Data[ind]));

            ind++;

            if (cloth_Data[ind].Count > index && index > -1)
            {
                DGClothes.ItemsSource = cloth_Data[ind];
                AddDialog dlg = new AddDialog();
                dlg.Acctivate(cloth_Data[ind], index);
            }
            BtnUndo.IsEnabled = true;
        }

        private void RussBtn_Click(object sender, RoutedEventArgs e)
        {
            AddBtn.Content = "Добавить";
            EditBtn.Content = "Редактировать";
            DelBtn.Content = "Удалить";
            _name.Header = "Название";
            _cost.Header = "Стоимость";
            _count.Header = "Количество";
            _matherial.Header = "Материал";
            BtnWhite.Content = "Светло";
            BtnBlack.Content = "Темно";
            BtnUndo.Content = "Назад";
            BtnRedo.Content = "Вперед";
            helpButton.Content = "Удалить выбранные";
        }

        private void EnglishBtn_Click(object sender, RoutedEventArgs e)
        {
            AddBtn.Content = "Add";
            EditBtn.Content = "Edit";
            DelBtn.Content = "Delete";
            _name.Header = "Name of product";
            _cost.Header = "Cost";
            _count.Header = "Count";
            _matherial.Header = "Matherial";
            BtnBlack.Content = "Dark"; 
            BtnWhite.Content = "Light";
            BtnUndo.Content = "Undo";
            BtnRedo.Content = "Redo";
            helpButton.Content = "Delete Selected";
             More more = new More();
            more.English(sender, e);

        }

        private void DataGridHyperlinkColumn_Click(object sender, RoutedEventArgs e)
        {
            int index = DGClothes.SelectedIndex;

            More dlg = new More();
            dlg.Acctivate(cloth_Data[ind][index]);
        }

        private void BtnUndo_Click(object sender, RoutedEventArgs e)
        {
            if(ind !=0)
            {
                ind--;
                DGClothes.ItemsSource = cloth_Data[ind];
                if (ind == 0)
                {
                    BtnUndo.IsEnabled = false;
                }
                BtnRedo.IsEnabled = true;
            }
        }

        private void BtnRedo_Click(object sender, RoutedEventArgs e)
        {
            if (ind < cloth_Data.Count-1)
            {
                ind++;
                DGClothes.ItemsSource = cloth_Data[ind];
                if (ind == cloth_Data.Count - 1)
                {
                    BtnRedo.IsEnabled = false;
                }
                BtnUndo.IsEnabled = true;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            _IOservice.SaveData(cloth_Data[ind], sender);
        }

        private void BtnBlack_Click(object sender, RoutedEventArgs e)
        {
            //var uri = new Uri(@"Services\Black.xaml", UriKind.Relative);
            //ResourceDictionary resourceDictionary = Application.LoadComponent(uri) as ResourceDictionary;
            //Application.Current.Resources.Clear();
            //Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }

        private void BtnWhite_Click(object sender, RoutedEventArgs e)
        {
            //var uri = new Uri(@"Services\White.xaml", UriKind.Relative);
            //ResourceDictionary resourceDictionary = Application.LoadComponent(uri) as ResourceDictionary;
            //Application.Current.Resources.Clear();
            //Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }

        private void DGClothes_Sorting(object sender, System.Windows.Controls.DataGridSortingEventArgs e)
        {
            for (int i = 0; i < cloth_Data[ind].Count; i++)
            {
                for (int j = i; j < cloth_Data[ind].Count; j++)
                {
                    if(bUp)
                    {
                        if (Int32.Parse(cloth_Data[ind][i].Count) > Int32.Parse(cloth_Data[ind][j].Count))
                        {
                            var temp = cloth_Data[ind][i];
                            cloth_Data[ind][i] = cloth_Data[ind][j];
                            cloth_Data[ind][j] = temp;
                        }
                        
                    }
                    else
                    {
                        if (Int32.Parse(cloth_Data[ind][i].Count) < Int32.Parse(cloth_Data[ind][j].Count))
                        {
                            var temp = cloth_Data[ind][i];
                            cloth_Data[ind][i] = cloth_Data[ind][j];
                            cloth_Data[ind][j] = temp;
                        }
                    }
                }
            }
            bUp = !bUp;
        }

        private void menuSelector_Checked(object sender, RoutedEventArgs e)
        {
            if (TBFind.Text != null && TBFind.Text != "Введите элемент" && TBFind.Text != "")
            {
                Search search = new Search();
                string outString = TBFind.Text.Substring(0, 1).ToUpper() + TBFind.Text.Substring(1).ToLower();

                RadioButton selectedRadio = (RadioButton)e.Source;
                var bList = new BindingList<Cloth>();
                string findAttr = selectedRadio.Content.ToString();

                bList.Clear();

                foreach (var item in cloth_Data[ind])
                {
                    switch (findAttr)
                    {
                        case "Материал":
                            if (item.Matherial == outString)
                            {
                                bList.Add(new Cloth()
                                {

                                    Cost = item.Cost,
                                    Count = item.Count,
                                    HyperlinkText = item.HyperlinkText,
                                    ImageAdr = item.ImageAdr,
                                    Description = item.Description,
                                    Name=item.Name,
                                    Matherial=item.Matherial,

                                });
                            }
                            break;

                        case "Количество":
                            if (item.Count == outString)
                            {
                                bList.Add(new Cloth()
                                {

                                    Cost = item.Cost,
                                    Count = item.Count,
                                    HyperlinkText = item.HyperlinkText,
                                    ImageAdr = item.ImageAdr,
                                    Description = item.Description,
                                    Name = item.Name,
                                    Matherial = item.Matherial,

                                });
                            }
                            break;
                    }
                }
                search.Acctivate(bList, -1);
            }
        }
        private void TBFind_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TBFind.Text = null;
        }

        private void TBFind_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(TBFind.Text, @"""\w*"))
            {
                TBFind.Text = TBFind.Text.Remove(TBFind.Text.Length - 1);
                TBFind.SelectionStart = TBFind.Text.Length;
            }

        }

        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            //{
            //    writer.WriteLine("Выход из приложения: " + DateTime.Now.ToShortDateString() + " " +
            //    DateTime.Now.ToLongTimeString());
            //    writer.Flush();
            //}

            //this.Close();
            Search search = new Search();
            search.Acctivate(cloth_Data[ind], -1);
        }
    }
}

        