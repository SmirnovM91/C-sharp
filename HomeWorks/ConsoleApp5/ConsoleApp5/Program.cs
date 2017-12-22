using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1.	Создать два проекта в решении: библиотека классов и консольное приложение. Подключить библиотеку в консольное приложение.
Добавить Класс Person в библиотеку и добавить класс со статическим методом который принимает в качестве параметра переменную типа Person и возвращает строку, состоящую из нескольких свойств класса Person. 
Вызвать в консольном  приложении метод используя полное пространство имен при обращении к нему.
2.	Создать класс со строковыми и числовыми константами в отдельном файле. В консольном приложении вывести эти константы на экран.

             */
            Person person = new Person() { FirstName = "Mikhail", LastName = "Smirnov" };
            ClassLibrary1.Class1.PrintInfo(person);
            Constances constances = new Constances();
            Console.WriteLine(constances.GetInt());
            Console.WriteLine(constances.GetString());
            Console.ReadLine();
        }
    }
}
