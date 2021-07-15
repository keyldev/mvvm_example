using mvvm_example.Core;
using mvvm_example.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_example.MVVM.ViewModel
{
    class CalculatorViewModel : ObservableObject
    {
        CalculatorModel calculator = new CalculatorModel();

        #region PROPERTIES

        private string _firstNumber;
        private string _secondNumber;
        private string _result;

        public string FirstNumber
        {
            get { return _firstNumber; }
            set { _firstNumber = value; NotifyPropertyChanged(); }
        }

        public string SecondNumber
        {
            get { return _secondNumber; }
            set { _secondNumber = value; NotifyPropertyChanged(); }
        }
        public string Result
        {
            get { return _result; }
            set { _result = value; NotifyPropertyChanged(); }
        }
        public RelayCommand CalculateButton { get; set; }

        #endregion
        public CalculatorViewModel()
        {
            CalculateButton = new RelayCommand(o => {
                Result = calculator.Calculate(FirstNumber, SecondNumber).ToString();
            });
        }
    }
}
