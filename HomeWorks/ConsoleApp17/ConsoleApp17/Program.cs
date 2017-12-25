using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1.	Объявить в консольном приложении класс Book с полями: название, стоимость, автор, год. 
             Создать коллекцию элементов Book и заполнить тестовыми данными. 
             С помощью класса BinaryFormatter сохранить состояние приложения в двоичный файл.
2.	На основании задания 1 восстановить состояние приложения из двоичного файла.
3.	Придумать пользовательский атрибут (самостоятельно). Данный атрибут должен выполнять прикладную задачу (а не демонстрационную). Проверить его функциональность.

             */
            Task1();
            Task2();
            Task3();
        }

        private static void Task3()
        {
            List<Book> list = new List<Book>()
            {
                new Book()
                {
                    Author="Пушкин",
                    Name="Сказки1",
                    Price=100,
                    Year=2017
                },
                new Book()
                {
                    Author="Пушкин",
                    Name="Сказки2",
                    Price=200,
                    Year=2019
                },
                new Book()
                {
                    Author="Пушкин",
                    Name="Сказки3",
                    Price=300,
                    Year=2019
                }

            };
            foreach (var book in list)
            {
                Console.WriteLine("Книга " + book.Name);
                Console.WriteLine("\tАттрибуты");
                foreach (var property in book.GetType().GetRuntimeProperties())
                {
                    PropertyInfo propertyInfo = property;
                    var attrs = propertyInfo.GetCustomAttributes(false);
                    if (attrs != null)
                    {

                        foreach (var attr in attrs)
                        {
                            if (attr is DisplayName)
                            {
                                Console.WriteLine("\t\t" + (attr as DisplayName).Name);
                            }
                        }
                    }
                }

            }
            Console.ReadLine();

        }

        private static void Task2()
        {
            using (FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                var books = binaryFormatter.Deserialize(fs) as List<Book>;
                foreach (var book in books)
                {
                    Console.WriteLine(book.Price);
                }
                Console.WriteLine();
            }
        }

        private static void Task1()
        {
            List<Book> list = new List<Book>()
            {
                new Book()
                {
                    Author="Пушкин",
                    Name="Сказки",
                    Price=100,
                    Year=2017
                },
                new Book()
                {
                    Author="Пушкин",
                    Name="Сказки",
                    Price=200,
                    Year=2019
                },
                new Book()
                {
                    Author="Пушкин",
                    Name="Сказки",
                    Price=300,
                    Year=2019
                }

            };
            using (FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, list);
            }

        }
    }
}
