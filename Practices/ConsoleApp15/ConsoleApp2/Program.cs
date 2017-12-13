using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Forex forex = new Forex();
            forex.SetHandler(new ForexHandler(Taxation.GetTax));
            List<Person> people = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person((i+1)*100));
                forex.Buy(people[i], (i+1) * 10);
            }
            Console.ReadLine();
            

        }
    }
}
