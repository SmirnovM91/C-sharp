using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static public double CalcNumbers(object a = null, object b = null)
        {
            /*
            1.	реализовать метод деления двух чисел. Внутри метода проверять входящие параметры. Если они не заданы, то генерировать исключение ArgumentNullException. Если делитель равен нулю, то генерировать исключение ArgumentException.
            */
            if (a == null || b == null)
                throw new ArgumentNullException("Не заданы числа");
            if ((int)b == 0)
                throw new ArgumentException("Делитель не может быть равен 0");

            return (int)a / (int)b;
        }
        static public int GetValueByIndex(int index)
        {
            /*
         2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
             */
            int[] arr = new int[5];
            return arr[index];
            
        }
        static void Main(string[] args)
        {
            /*
           1.	реализовать метод деления двух чисел. Внутри метода проверять входящие параметры. Если они не заданы, то генерировать исключение ArgumentNullException. Если делитель равен нулю, то генерировать исключение ArgumentException.
           */
            try
            {
                Console.WriteLine(CalcNumbers(4, 2));
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            /*
        2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
            */
            try
            {
                GetValueByIndex(11);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Выход за границы массива");
            }
            finally
            {
                Console.WriteLine("Обработка массива завершена");
            }

            Console.ReadLine();
        }
    }
}
