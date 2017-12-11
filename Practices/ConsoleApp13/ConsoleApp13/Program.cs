using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1.	Удалить все нечетные элементы списка ArrayList
             2.	Дана коллекция. Вывести на экран элементы, значение которых больше среднего арифметического всех элементов коллекции.
            */
            Task1();
            Console.Clear();
            Task2();
        }

        private static void Task1()
        {
            ArrayList array = new ArrayList();
            Random rand = new Random();

            for (int i = 0; i < rand.Next(5, 15); i++)
            {
                int num = rand.Next(0, 10);
                array.Add(num);
                Console.Write(num + "\t");
            }
            Console.WriteLine("");
            ArrayList tmp = new ArrayList();
            for (int i = 0; i < array.Count; i++)
            {
                if (i % 2 == 1)
                {
                    tmp.Add(array[i]);
                }
            }
            array.Clear();
            Console.WriteLine("");
            for (int i = 0; i < tmp.Count; i++)
            {
                Console.Write(tmp[i]+"\t");
            }
            Console.ReadLine();
        }

        private static void Task2()
        {
            ArrayList array = new ArrayList();
            Random rand = new Random();
            int sum = 0;
            for (int i = 0; i < rand.Next(5, 15); i++)
            {
                int num = rand.Next(0, 10);
                array.Add(num);
                Console.Write(num + "\t");
                sum += num;
            }
            double avg = sum / array.Count;
            Console.WriteLine("\nAVG = " + avg);
            for (int i = 0; i < array.Count; i++)
            {

                if ((int)array[i] > avg)
                    Console.Write(array[i] + "\t");
            }

            Console.ReadLine();
        }
    }
}
