using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ExceptionClass exClass = new ExceptionClass();
                exClass.throwException();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Выход за границы массива");
                Console.ReadKey();
            }
            

        }
    }
}
