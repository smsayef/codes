
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

namespace wpf
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        int count = 0;
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string username = Username.Text;
            string password = Password.Password;

            if (username != "" && password != "")
            {
                MainWindow dashboard = new MainWindow(username);
                //ui dashboard = new ui(username);
                dashboard.Show();
                this.Close();
            }
        }



    }
}
