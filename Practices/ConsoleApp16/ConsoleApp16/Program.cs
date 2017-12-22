using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            testClass.PropertyChanged += TestClass_PropertyChanged;
            testClass.PropertyInt = 10;
            testClass.PropertyString = "TEST";
            Console.ReadLine();
        }

        private static void TestClass_PropertyChanged(object sender, PropertyEventArgs args)
        {
            Console.WriteLine("Свойство с типом {0} изменило значение на {1}",args.Property.GetType().Name,args.Property);
        }
    }
}
