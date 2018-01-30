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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataService.employeeList = DataService.GetEmployees();
            DataService.employeeList.CollectionChanged += List_CollectionChanged;
           
            dataGrid.ItemsSource = DataService.employeeList;
        }
        private static void List_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
         
            DataService.SaveToFile();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm(new Employee() { FullName = "КТО Я?" },true);
            addEditForm.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm(DataService.employeeList[dataGrid.SelectedIndex]);
            addEditForm.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (DataService.employeeList.Count > 0)
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    DataService.employeeList.Remove(DataService.employeeList[dataGrid.SelectedIndex]);
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CalendarWindow calendarWindow = new CalendarWindow();
            calendarWindow.Show();
        }
    }
}
