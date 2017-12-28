using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.	Создать массив сотрудников. Длина массива задается пользователем, заполнение массива производится им же. Выполнить следующее:
    a.	вывести полную информацию обо всех сотрудниках;
    b.	найти в массиве всех менеджеров, зарплата которых больше средней зарплаты всех клерков, вывести на экран полную информацию о таких менеджерах отсортированной по их фамилии.
2.	Для получения места в общежитии формируется список студентов, который включает Ф.И.О. студента, группу, средний балл, доход на члена семьи, пол (перечисление), форма обучения(перечисление). 
Общежитие в первую очередь предоставляется тем, у кого доход на члена семьи меньше двух минимальных зарплат, затем остальным в порядке уменьшения среднего балла. 
Вывести список очередности предоставления мест в общежитии.
*/
            ToDo1();
            Console.WriteLine("Task #2");
            ToDo2();
        }

        private static void ToDo2()
        {
            const int minSalary = 5000;
            const int studentCount = 10;
            Student[] students = new Student[studentCount];

            Random random = new Random();
            Console.WriteLine();
            for (int i = 0; i < studentCount; i++)
            {
                students[i] = new Student()
                {
                    AvgValue = random.Next(2, 5) + random.NextDouble(),
                    FirstName = "FirstName #" + i,
                    LastName = "LastName #" + i,
                    Sex = (Sex)random.Next(0, 1),
                    EduType = (EduType)random.Next(0, 1),
                    ParentsSalary = random.Next(3000, 20000)
                };
            }
            foreach (var student in students)
            {
                if (student.ParentsSalary < minSalary * 2)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName + " = " + " " + student.ParentsSalary);
                }
            }
            Console.WriteLine();
            foreach (var student in students.OrderByDescending(student => student.AvgValue).Where(student=> !(student.ParentsSalary < minSalary * 2)))
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " = " + " " + Math.Round(student.AvgValue, 2));
            }
            Console.ReadLine();

        }

        private static void ToDo1()
        {
            const int personCount = 10;
            Person[] people = new Person[personCount];

            Random random = new Random();

            int avgSalary = 0;
            for (int i = 0; i < personCount; i++)
            {
                people[i] = new Person()
                {
                    FirstName = "FirstName #" + i,
                    LastName = "LastName #" + i,
                    Salary = random.Next(1000, 10000)
                };
                avgSalary += people[i].Salary;
            }
            avgSalary /= personCount;
            ToDO1A(people);
            Console.WriteLine();
            ToDo1B(people, avgSalary);
            Console.WriteLine();


        }

        private static void ToDO1A(Person[] people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " = " + person.Salary);
            }
        }

        private static void ToDo1B(Person[] people, int avg)
        {
            Console.WriteLine("AVG Salary = " + avg);
            foreach (var person in people)
            {
                if (person.Salary > avg)
                {
                    Console.WriteLine(person.FirstName + " " + person.LastName + " = " + person.Salary);
                }
            }
        }
    }
}
