using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Task1();
            Task2();
            /*
             
1.	Прочитать содержимое XML файла со списком последних новостей по ссылке https://habrahabr.ru/rss/interesting/
Создать класс Item со свойствами: Title, Link, Description, PubDate.
Создать коллекцию типа List<Item> и записать в нее данные из файла.
2.	С помощью класса XmlDocument создать класс который будет описывать студента и вывести его на консоль или сохранить в текстовый файл

             */


        }

        private static void Task2()
        {
            XmlDocument xmlDocument = new XmlDocument();

            var students = xmlDocument.CreateElement("students");
            xmlDocument.AppendChild(students);

            var student = xmlDocument.CreateElement("student");
            student.SetAttribute("FirstName", "Mikhail");
            student.SetAttribute("LastName", "Smirnov");
            students.AppendChild(student);

            Console.WriteLine(xmlDocument.DocumentElement.FirstChild.Attributes["FirstName"].Value +" "+ xmlDocument.DocumentElement.FirstChild.Attributes["LastName"].Value);
            Console.ReadLine();
        }

        private static void Task1()
        {
            List<Item> list = new List<Item>();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("habrahabr.ru.xml");
            var items = xmlDocument.DocumentElement.GetElementsByTagName("item");
            foreach (XmlElement item in items)
            {
                list.Add(new Item()
                {
                    Title = item.ChildNodes.Item(0).InnerText,
                    Guid = item.ChildNodes.Item(1).InnerText,
                    Link = item.ChildNodes.Item(2).InnerText,
                    Description = item.ChildNodes.Item(3).InnerText,
                    PubDate = item.ChildNodes.Item(4).InnerText,
                });
            }
            foreach (var item in list)
            {
                Console.Write("{0}\n{1}\n{2}\n{3}\n{4}\n\n", item.Title, item.Guid, item.Link, item.Description, item.PubDate);
            }
            Console.ReadLine();
        }
    }
}
