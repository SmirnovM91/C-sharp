using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo1();
            ToDo2();
            /*
             
1.	С помощью рефлексии получить список методов класса Console и вывести на экран.
2.	Описать класс с несколькими свойствами. Создать экземпляр класса и инициализировать его свойства. 
С помощью рефлексии получить свойства и их значения из созданного экземпляра класса. Вывести полученные значения на экран

             */
            
        }

        private static void ToDo2()
        {

            ReflClass reflClass = new ReflClass()
            {
                Number = 5,
                Str = "Test"
            };
            Type type = reflClass.GetType();
            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine(prop.Name+" = "+prop.GetValue(reflClass));
            }
            Console.ReadLine();

        }

        private static void ToDo1()
        {
            Type type = Type.GetType("System.Console");
            foreach (var method in type.GetMethods())
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
        }
    }
}
