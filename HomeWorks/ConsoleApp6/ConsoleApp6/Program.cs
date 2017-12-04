using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            SQRArray array = new SQRArray(10);
            array[0] = 10;
            Console.WriteLine(array[0]);
            Console.ReadLine();
        }
    }
}
