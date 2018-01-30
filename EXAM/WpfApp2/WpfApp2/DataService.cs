using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public static class DataService
    {
        public static ObservableCollection<Employee> employeeList;
        public static ObservableCollection<DateCheck> dateCheckList;
        public static void SaveEmployee(Employee employee, Boolean isNew = false)
        {
            if (isNew)
            {
              
                employeeList.Add(employee);
               
            }
            SaveToFile();
        }

        public static void SaveToFile()
        {
            using (StreamWriter file = File.CreateText("data.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, employeeList);
               
            }
        }

        public static void SaveToFileChecks()
        {
            using (StreamWriter file = File.CreateText("data_checks.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, dateCheckList);

            }
        }

        public static ObservableCollection<Employee> GetEmployees()
        {
            ObservableCollection<Employee> list = new ObservableCollection<Employee>();
          
            
            if (File.Exists("data.json"))
            using (StreamReader stream = new StreamReader("data.json"))
            {

                list = JsonConvert.DeserializeObject<ObservableCollection<Employee>>(stream.ReadToEnd());
            }
            return list;
        }

        public static ObservableCollection<DateCheck> GetChecks()
        {
            ObservableCollection<DateCheck> list = new ObservableCollection<DateCheck>();


            if (File.Exists("data_checks.json"))
                using (StreamReader stream = new StreamReader("data_checks.json"))
                {

                    list = JsonConvert.DeserializeObject<ObservableCollection<DateCheck>>(stream.ReadToEnd());
                }
            return list;
        }

        public static ObservableCollection<DateCheck> GetChecksByDate(DateTime date)
        {
            var items = dateCheckList.Where(item => item.Date == date).ToList();
            if (items.Count == 0)
            {
                foreach (var item in employeeList)
                {
                    DateCheck dateCheck = new DateCheck() {
                        Date = date, Employee = item, isWas = false
                    };
                    items.Add(dateCheck);
                    dateCheckList.Add(dateCheck);
                }
            }
           
            return new ObservableCollection<DateCheck>(items);
        }

    }
}
