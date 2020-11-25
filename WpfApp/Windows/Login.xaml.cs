using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp.ViewModels;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly LoginViewModel _loginViewModel;
       // public Login() { InitializeComponent(); }
        public Login(LoginViewModel vm)
        {
            _loginViewModel = vm;
            DataContext = _loginViewModel;

            InitializeComponent();
        }

        private void CancelButton(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void EnterButton(object sender, RoutedEventArgs e)
        {
            if (_loginViewModel.Login())
                
            {
                Global.ID= _loginViewModel.UD(LoginBox.Text);
                DialogResult = true;
                this.Close();
                var m = new Menu();
                m.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Error");
            }
        }
       
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            {
                ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password;
            }
        }
    }
}

