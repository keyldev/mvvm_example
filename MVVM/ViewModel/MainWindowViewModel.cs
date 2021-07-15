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

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; NotifyPropertyChanged(); }
        }
        public CalculatorViewModel testViewModel { get; set; }
        public MainWindowViewModel()
        {
            testViewModel = new CalculatorViewModel();

            CurrentView = testViewModel;
        }
    }
}
