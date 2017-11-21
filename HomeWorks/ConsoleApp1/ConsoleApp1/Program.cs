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
                Console.WriteLine("Выберите задание (1-10): ");

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
                    case "9":
                        Task9();
                        break;
                    case "10":
                        Task10();
                        break;
                    default:
                        return;

                }
                Console.ReadKey();
            }
        }

        private static void Task10()
        {

            Console.WriteLine(" Напечатать 'столбиком': \n 1. все целые числа от 20 до 35;\n 2. квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);\n 3. третьи степени всех целых чисел от a до 50(значение a вводится с клавиатуры; a < 50);\n 4. все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).\n");
            Console.WriteLine("Выберите подзадание (1-4): ");
            switch (Console.ReadLine())
            {
                case "1":
                    for (int i = 20; i <= 35; i++)
                        Console.WriteLine(i);
                    break;
                case "2":
                    Console.WriteLine("Введите b (b>10) = ");
                    int b = int.Parse(Console.ReadLine());
                    for (int i = 10; i <= b; i++)
                        Console.WriteLine(i*i);
                    break;
                case "3":
                    Console.WriteLine("Введите a (b<50) = ");
                    int a = int.Parse(Console.ReadLine());
                    for (int i = a; i < 50; i++)
                        Console.WriteLine(Math.Pow(i,3));
                    break;
                case "4":
                    Console.WriteLine("Введите a = ");
                    int start = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите b = ");
                    int end = int.Parse(Console.ReadLine());
                    for (int i = start; i <= end; i++)
                        Console.WriteLine(i);
                    break;
            }

        }

        private static void Task9()
        {
            Console.WriteLine("\n9. Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?");

            Console.Write("Введите сопротивление цепи №1 = ");
            int r1 = int.Parse(Console.ReadLine());
            Console.Write("Введите напряжение цепи №1 = ");
            int u1 = int.Parse(Console.ReadLine());

            Console.Write("Введите сопротивление цепи  №2 = ");
            int r2 = int.Parse(Console.ReadLine());
            Console.Write("Введите напряжение цепи №2 = ");
            int u2 = int.Parse(Console.ReadLine());

            double i1 = u1 / r1;
            double i2 = u2 / r2;

            Console.WriteLine("Плотность тела №1 = {0:G}", i1);
            Console.WriteLine("Плотность тела №2 = {0:G}", i2);
            if (i1 > i2)
            {
                Console.WriteLine("На участке №1 протекает меньший ток");
            }
            else if (i1 < i2)
            {
                Console.WriteLine("На участке №2 протекает меньший ток");
            }
            else
            {
                Console.WriteLine("На обоих участках протекает одинаковый ток");
            }
        }

        private static void Task8()
        {
            Console.WriteLine("\n8. Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?");

            Console.Write("Введите объем тела №1 = ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Введите массу тела №1 = ");
            int m1 = int.Parse(Console.ReadLine());

            Console.Write("Введите объем тела №2 = ");
            int v2 = int.Parse(Console.ReadLine());
            Console.Write("Введите массу тела №2 = ");
            int m2 = int.Parse(Console.ReadLine());

            double p1 = m1 / v1;
            double p2 = m2 / v2;

            Console.WriteLine("Плотность тела №1 = {0:G}", p1);
            Console.WriteLine("Плотность тела №2 = {0:G}", p2);
            if (p1 > p2)
            {
                Console.WriteLine("Плотность тела №1 больше чем плотность тела №2");
            }
            else if (p1 < p2)
            {
                Console.WriteLine("Плотность тела №2 больше чем плотность тела №1");
            }
            else
            {
                Console.WriteLine("Плотности равны");
            }
        }

        private static void Task7()
        {
            Console.WriteLine("\n7. Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?");
            Console.Write("Введите радиус окружности = ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону квадрата = ");
            int a = int.Parse(Console.ReadLine());
            double sSquare = a * a;
            double sRound = Math.PI * r * r;
            Console.WriteLine("Площадь круга = {0:G}", sRound);
            Console.WriteLine("Площадь квадрата = {0:G}", sSquare);
            if (sSquare > sRound)
            {
                Console.WriteLine("Площадь квадрата больше чем площадь круга");
            }
            else if (sSquare < sRound)
            {
                Console.WriteLine("Площадь круга больше чем площадь квадрата");
            }
            else
            {
                Console.WriteLine("Площади равны");
            }
        }

        private static void Task6()
        {
            Console.WriteLine("\n6. Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:");
            bool A = true, B = false, C = false;
            Console.WriteLine(" a. А или В = {0:G}", A || B);
            Console.WriteLine(" b. А и В = {0:G}", A && B);
            Console.WriteLine(" c. В или С = {0:G}", B || C);

        }

        private static void Task5()
        {
            Console.WriteLine("\n5. Дано двузначное число. Найти: \na. число десятков в нем; \nb. число единиц в нем; \nc. сумму его цифр; \nd. произведение его цифр");
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

        private static void Task4()
        {
            Console.WriteLine("\n4. С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");
            int days = 234;
            int weeks = days / 7;
            Console.WriteLine("Полных недель прошло за этот период = {0:G}", weeks);
        }

        private static void Task3()
        {
            Console.WriteLine("\n3. Дано расстояние в сантиметрах. Найти число полных метров в нем.");
            Console.Write("Введите расстояние в сантиметрах = ");
            int distanceSm = int.Parse(Console.ReadLine());
            int distanceMt = distanceSm / 100;
            Console.WriteLine("Полных метров = {0:G}", distanceMt);
        }

        private static void Task2()
        {
            Console.WriteLine("\n 2.Вывести на экран числа 5, 10 и 21 одно под другим.");
            int num1 = 5, num2 = 10, num3 = 21;
            Console.WriteLine("{0:G}\n{1:G}\n{2:G}", num1, num2, num3);
        }

        private static void Task1()
        {
            Console.WriteLine("\n 1.Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.");
            int num1 = 111, num2 = 222, num3 = 333;
            Console.WriteLine("{0:G}  {1:G}  {2:G}", num1, num2, num3);
        }
    }
}
