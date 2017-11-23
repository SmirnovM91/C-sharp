using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int countCars = 5;
            Car[] cars = new Car[countCars];
            cars[0] = new Car("Mercedes-Benz", "GLK-250", 1.9, "Black");
            cars[1] = new Car("Лада", " калина", 1.5, "Black");
            cars[2] = new Car("Toyota", "Prado", 4.5, "White");
            cars[3] = new Car("Volskwagen", "Touareg", 4.2, "Silver");
            cars[4] = new Car("Mercedes-Benz", "S", 4.3, "White");

            Console.WriteLine("Количество машин = {0}",Car.GetCountCars());
            Console.WriteLine("Количество машин черного цвета = {0}", Car.GetCountBlackCars());
            Console.ReadKey();
        }
    }
}
