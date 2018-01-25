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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            var btn = (sender as Button);
            btn.Margin = new Thickness(rand.Next(0, (int)Width - (int)btn.Width*3) , rand.Next(0, (int)Height - (int)btn.Height*3),0,0);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("А ты шустрый малый :)");
        }
    }
}
