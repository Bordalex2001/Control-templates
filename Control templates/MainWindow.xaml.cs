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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Control_templates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameField.Text;
            string password = passwordField.Password;

            // Здесь можно добавить логику проверки имени пользователя и пароля
            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Login successful!");
                // Здесь можно открыть новое окно или выполнить другие действия после успешной аутентификации
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.");
            }
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}