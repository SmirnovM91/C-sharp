using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите задание (1-8): ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "4":
                        Task4();
                        break;
                    case "5":
                        Task5();
                        break;
                    case "6":
                        Task6();
                        break;
                    case "7":
                        Task7();
                        break;
                    case "8":
                        Task8();
                        break;
                    default:
                        return;

                }
                Console.ReadKey();
            }

           
            
        }
        //Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
        private static void Task8()
        {
            Console.WriteLine("\n//Вычислить значение логического выражения при всех возможных значениях логических величин при X = true и Y = false:");
            bool x = true, y = false;
            Console.WriteLine(" a. не X и не Y = {0:G}", !x && !y);
            Console.WriteLine(" b. X или(не X и Y) = {0:G}", x || (!x && y));
            Console.WriteLine(" c. (не X и Y) или Y. = {0:G}", (!x && y) || y);



        }

        //В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456. Найти число x.
        private static void Task7()
        {
            Console.WriteLine("\n//В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456. Найти число x.");
            Console.Write("Введите трехзначное число = ");
            int number = int.Parse(Console.ReadLine());
            int firstNumb = number / 100;
            int secondNumb = (number % 100) / 10;
            int thirdNumb = number % 10;
            Console.WriteLine("Ответ: {0:G}{1:G}{2:G}", firstNumb, thirdNumb, secondNumb);

        }

        //Дано четырехзначное число. Найти: a.сумму его цифр; b.произведение его цифр.
        private static void Task6()
        {
            Console.WriteLine("\n//Дано четырехзначное число. Найти: \na.сумму его цифр; \nb.произведение его цифр.");
            Console.Write("Введите четырехзначное число = ");
            int number = int.Parse(Console.ReadLine());
            int firstNumb = number / 1000;
            int secondNumb = (number % 1000) / 100;
            int thirdNumb = ((number % 1000) % 100) / 10;
            int fourthNumb = number % 10;
            Console.WriteLine("Сумма цифр: {0:G}", firstNumb + secondNumb + thirdNumb + fourthNumb);
            Console.WriteLine("Произведение цифр: {0:G}", firstNumb * secondNumb * thirdNumb * fourthNumb);

        }

        //Дано двузначное число. Найти: a. число десятков в нем; b. число единиц в нем; c. сумму его цифр; d. произведение его цифр
        private static void Task5()
        {
            Console.WriteLine("\n//Дано двузначное число. Найти: \na. число десятков в нем; \nb. число единиц в нем; \nc. сумму его цифр; \nd. произведение его цифр");
            Console.Write("Введите двухзначное число = ");
            int number = int.Parse(Console.ReadLine());
            int del = 10;
            int firstNumb = number / del;
            int secondNumb = number - firstNumb * del;
            int countOnes = firstNumb == 1 ? 1 : 0 + secondNumb == 1 ? 1 : 0;

            Console.WriteLine("Число десятков: {0:G}", firstNumb);
            Console.WriteLine("Число единицы: {0:G}", countOnes);
            Console.WriteLine("Сумма цифр: {0:G}", firstNumb + secondNumb);
            Console.WriteLine("Произведение: {0:G}", firstNumb * secondNumb);
        }


        //С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
        private static void Task4()
        {
            Console.WriteLine("\n//С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");
            int days = 234;
            int weeks = days / 7;
            Console.WriteLine("Полных недель прошло за этот период = {0:G}", weeks);
        }

        //Дано расстояние в сантиметрах. Найти число полных метров в нем.
        private static void Task3()
        {
            Console.WriteLine("\n//Дано расстояние в сантиметрах. Найти число полных метров в нем.");
            Console.Write("Введите расстояние в сантиметрах = ");
            int distanceSm = int.Parse(Console.ReadLine());
            int distanceMt = distanceSm / 100;
            Console.WriteLine("Полных метров = {0:G}", distanceMt);
        }

        //Дан радиус окружности. Найти длину окружности и площадь круга;
        private static void Task2()
        {
            Console.WriteLine("\n//Дан радиус окружности. Найти длину окружности и площадь круга;");
            Console.Write("Введите радиус окружности = ");
            int r = int.Parse(Console.ReadLine());
            double l = 2 * r * Math.PI;
            double s = Math.PI * r * r;
            Console.WriteLine("Длина окружности = {0:G}", l);
            Console.WriteLine("Площадь круга = {0:G}", s);
        }

        //вычисления значения функции y=7x^2-3x+4 при любом значении x;
        private static void Task1()
        {
            Console.WriteLine("\n//вычисления значения функции y=7x^2-3x+4 при любом значении x;");
            Console.Write("Введите значение x = ");
            int x = int.Parse(Console.ReadLine());
            int y = 7 * x * x - 3 * x + 4;
            Console.WriteLine("y = {0:G}", y);
        }
    }
}
