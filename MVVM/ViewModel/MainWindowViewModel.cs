using mvvm_example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_example.MVVM.ViewModel
{
    class MainWindowViewModel : ObservableObject
    {
        private object _currentView;

        /// <summary>
        /// CurrentView для смены View в главном окне (MainWindow.xaml)
        /// </summary>
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; NotifyPropertyChanged(); }
        }
        /// <summary>
        /// Излишнее свойство, можно обойтись без него, можно с ним.
        /// </summary>
        public LoginViewModel LoginViewModel { get; set; }
        public MainWindowViewModel()
        {
            // инициализируем
            LoginViewModel = new LoginViewModel();

            // показываем VM
            // заглянуть стоит в App.xaml, там указаны DataTemplat'ы для Login\Register View's. 
            CurrentView = LoginViewModel;
        }
    }
}
