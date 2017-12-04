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
            RangeOfArray arr = new RangeOfArray(10, 15);
            arr[10] = "asd";
            Console.WriteLine(arr[10]);
            Console.ReadLine();
        }
    }
}
