using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Shopping_Cart.Commands;

namespace Shoppinh_Cart
{
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        //уведомление о изменение свойства в объекте
        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        //разрешить кольцевые изменения
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string ProperyName = null)
        {
            field = value;
            OnPropertyChanged();
            return true;

        }
    }
    internal class MainWindowModels : ViewModel
    {

        public ICommand ChangeLanguageCommand { get; }

        private bool CanChangeLanguageCommandExecute(object p) => true;

        private void OnChangeLanguageCommandExecuted(object p)
        {
            string laguage = p as string;
            switch (laguage)
            {
                case "ru":
                    Application.Current.MainWindow.Resources.Source = new Uri(String.Format("../Languages/StringResourcesRu.xaml"), UriKind.Relative);
                    break;
                case "us":
                    Application.Current.MainWindow.Resources.Source = new Uri(String.Format("../Languages/StringResourcesUs.xaml"), UriKind.Relative);
                    break;
                default:
                    break;
            }
        }


        public MainWindowModels()
        {

            //CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            ChangeLanguageCommand = new LambdaCommand(OnChangeLanguageCommandExecuted, CanChangeLanguageCommandExecute);

        }
    }
}
