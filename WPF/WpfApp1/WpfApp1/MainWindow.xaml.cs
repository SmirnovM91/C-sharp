using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int k = 1;
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    CalendarCell calendarCell = new CalendarCell();

                    Grid.SetRow(calendarCell, i);
                    Grid.SetColumn(calendarCell, j);
                    calendarCell.Number.Text = k.ToString();
                    calendarCell.Text.Text = "Label #" + k;

                    Calendar.Children.Add(calendarCell);
                    k++;
                }
            }
        }
    }
}
