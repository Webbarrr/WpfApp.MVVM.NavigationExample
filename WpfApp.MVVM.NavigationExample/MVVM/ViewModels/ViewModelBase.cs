using System.Windows.Input;

namespace WpfApp.MVVM.NavigationExample.MVVM.ViewModels
{
    public abstract class ViewModelBase : PropertyChangedBase
    {
        private ICommand _screen1Command;
        private ICommand _screen2Command;
        private ICommand _screen3Command;

        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel { get => _currentViewModel; set => base.SetProperty(ref _currentViewModel, value); }

        private void ChangeViewModel(ViewModelBase viewModelBase)
        {
            this.CurrentViewModel = viewModelBase;
        }

        public ICommand Screen1Command
        {
            get
            {
                if (_screen1Command == null)
                {
                    _screen1Command = new RelayCommand(
                        p => true,
                        p => this.ChangeViewModel(new Screen1ViewModel()));
                }

                return _screen1Command;
            }
        }

        public ICommand Screen2Command
        {
            get
            {
                if (_screen2Command == null)
                {
                    _screen2Command = new RelayCommand(
                        p => true,
                        p => this.ChangeViewModel(new Screen2ViewModel()));
                }

                return _screen2Command;
            }
        }

        public ICommand Screen3Command
        {
            get
            {
                if (_screen3Command == null)
                {
                    _screen3Command = new RelayCommand(
                        p => true,
                        p => this.ChangeViewModel(new Screen3ViewModel()));
                }

                return _screen3Command;
            }
        }
    }
}