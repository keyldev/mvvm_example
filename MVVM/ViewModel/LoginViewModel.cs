using mvvm_example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace mvvm_example.MVVM.ViewModel
{
    internal class LoginViewModel : ObservableObject
    {
        // пропсы для текстбоксов, на примере с логинвью

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
            set { _passwordText = value; NotifyPropertyChanged(); }
        }
        // команда для авторизации
        public RelayCommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(o => Login(o));
        }

        private void Login(object o)
        {
            // т.к. PasswordBox по соображениям безопасности запрещает прямой DB, есть некое решение через параметр команды (CommandParameter в LoginView.xaml)
            // 

            var password = o as PasswordBox;
            if (password != null)
            {
                PasswordText = password.Password;
                MessageBox.Show(PasswordText);
            }
        }
    }

}
