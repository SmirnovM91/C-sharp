using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для CalendarWindow.xaml
    /// </summary>
    public partial class CalendarWindow : Window
    {
        public ObservableCollection<DateCheck> currentDayList { get; set; }
        public CalendarWindow()
        {
            this.DataContext = this;
            DataService.dateCheckList = DataService.GetChecks();
            DataService.dateCheckList.CollectionChanged += DateCheckList_CollectionChanged;
            currentDayList = DataService.GetChecksByDate(DateTime.Now.Date);
            InitializeComponent();

            dataGrid.ItemsSource = DataService.dateCheckList;
          
        }

        private void DateCheckList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            DataService.SaveToFileChecks();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var date = (sender as Calendar).SelectedDate;
            dataGrid.ItemsSource = DataService.GetChecksByDate(date.Value);
        }
    }
}
