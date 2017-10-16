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
using System.IO;

namespace WpfHomeWorkOne
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void ButtonTransition_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow window = new AuthorizationWindow();
            window.Show();
            this.Hide();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxLogin.Clear();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            string[] saveFile = {textBoxLogin.Text};
            File.WriteAllLines(@"D:\WPF\HomeWork\WpfHomeWorkOne\WpfHomeWorkOne\bin\Debug\Login.txt", saveFile);
        }
    }
}
