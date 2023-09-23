using mvvm_example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_example.MVVM.ViewModel
{
    internal class RegisterViewModel : ObservableObject
    {
        private string _loginText;

        public string LoginText
        {
            get { return _loginText; }
            set { _loginText = value; NotifyPropertyChanged(); }
        }
        private string _passwordText;

        public string PasswordText
        {
            get { return _passwordText; }
            set { _passwordText = value;NotifyPropertyChanged(); }
        }


        public RegisterViewModel()
        {
            
        }

    }
}
