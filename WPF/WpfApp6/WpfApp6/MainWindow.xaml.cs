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

namespace WpfApp6
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

        private void OnTargetUpdated(object sender, DataTransferEventArgs e)
        {
            sum.Text = (int.Parse(fuelBox92.Text) + int.Parse(fuelBox95.Text)+ int.Parse(fuelBox98.Text)+ int.Parse(food1.Text)+int.Parse(food2.Text)+ int.Parse(food3.Text)).ToString();
        }
    }
}
