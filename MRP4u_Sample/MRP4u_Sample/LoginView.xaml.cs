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
using MahApps.Metro.Controls;

namespace MRP4u_Sample
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : MetroWindow
    {
        public LoginView()
        {
            InitializeComponent();
            progressBar.Visibility = Visibility.Collapsed;
            textBox.Focus();
            
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.IsReadOnly = true;
            passwordBox.IsEnabled = false;
            progressBar.Visibility = Visibility.Visible;
            await Task.Delay(1500);
            this.Hide();
            MainWindow mn = new MainWindow();
            mn.Show();
            this.Close();
        }
    }
}
