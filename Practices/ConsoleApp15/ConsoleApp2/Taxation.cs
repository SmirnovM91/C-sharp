using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Taxation
    {
        public static void GetTax(int value)
        {
            Console.WriteLine("Налог с суммы {0} состовляет {1}",value,value*0.12);
            
        }
    }
}
