using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public struct Employee
    {
        Vacancies Vacancy { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public DateTime EmploymentDate { get; set; }
        public Employee(Vacancies vacancy,string name,int salary,DateTime date)
        {
            Vacancy = vacancy;
            Name = name;
            Salary = salary;
            EmploymentDate = date;
        }
    }
}
