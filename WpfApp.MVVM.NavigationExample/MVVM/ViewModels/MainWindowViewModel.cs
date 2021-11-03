using System;

namespace WpfApp.MVVM.NavigationExample.MVVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Console.WriteLine("Loaded MainWindowViewModel");
            this.CurrentViewModel = new Screen1ViewModel();
        }
    }
}