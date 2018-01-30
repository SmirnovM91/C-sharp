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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для AddEditForm.xaml
    /// </summary>
    /// 

    public partial class AddEditForm : Window
    {
        public Employee employee { get; set; }
        

        private bool _isNew;
        public AddEditForm(Employee e, bool isNew = false)
        {
            this.DataContext = this;
           
            employee = e;
           
            InitializeComponent();
           
          
            _isNew = isNew;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataService.SaveEmployee(employee, _isNew);
            this.Close();
        }

     
    }
}
