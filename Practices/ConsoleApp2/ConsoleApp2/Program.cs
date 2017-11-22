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
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание (1-5): ");

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

                    default:
                        return;

                }
                Console.ReadKey();
            }

        }

        private static void Task5()
        {
            /*
             5.	Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
             Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.
             */
            const int size = 5;
            int[] a = new int[size * size];
            Random rand = new Random();
            int min = 100;
            int max = -100;
            int minI = 0;
            int maxI = 0;
            Console.WriteLine("Вывод рандомного массива: ");
            for (int i = 0; i < size * size; i++)
            {
                a[i] = rand.Next(-100, 100);
                Console.Write("{0}\t", a[i]);
                if (a[i] < min)
                {
                    min = a[i];
                    minI = i;
                }
                if (a[i] > max)
                {
                    max = a[i];
                    maxI = i;
                }
                if (i>0 && (i+1)%5==0)
                Console.WriteLine("");

            }
            Console.WriteLine("\nВывод массива где MIN = {0} и MAX {1}: ", min, max);
            if (minI<maxI)
            {
                for (int i = minI+1; i < maxI; i++)
                {
                    Console.Write("{0}\t");
                }
            } else
            {
                for (int i = maxI+1; i < minI; i++)
                {
                    Console.Write("{0}\t",a[i]);
                }
            }
            
        }

        private static void Task4()
        {
            /*
             4.	Подсчитать количество слов во введенном предложении.
             */
            Console.Write("Введите предложение: ");
            Console.WriteLine("Кол-во слов в предложении = {0}", Console.ReadLine().Split(' ').Length);
        }

        private static void Task3()
        {
            /*
             3.	Пользователь вводит строку. Проверить, является ли эта строка палиндромом. Палиндромом называется строка, которая одинаково читается слева направо и справа налево.
              */
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    Console.WriteLine("Строка не является полиндромом");
                    return;
                }
            }
            Console.WriteLine("Строка является полиндромом");
        }

        private static void Task2()
        {
            /*
             2.	Даны 2 массива размерности M и N соответственно. Необходимо переписать в третий массив общие элементы первых двух массивов без повторений. 
             */
            int[] a;
            int[] b;
            int[] c;
            Console.Write("Введите размер массива №1 = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите размер массива №2 = ");
            int n = int.Parse(Console.ReadLine());
            a = new int[m];
            b = new int[n];
            c = new int[m * n];
            Random rand = new Random();
            Console.WriteLine("\nМассив №1: ");
            int counter = 0;
            for (int i = 0; i < m; i++)
            {
                a[i] = rand.Next(1, 20);
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\nМассив №2: ");
            for (int i = 0; i < n; i++)
            {
                b[i] = rand.Next(1, 20);
                Console.Write("{0} ", b[i]);
            }
            for (int i = 0; i < m; i++)
            {
                if (!b.Contains(a[i]))
                {
                    c[counter++] = a[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                c[counter++] = b[i];
            }
            Console.WriteLine("\nМассив №3: ");
            for (int i = 0; i < counter; i++)
                Console.Write("{0} ", c[i]);
        }

        private static void Task1()
        {
            /*
             1.	Объявить одномерный (5 элементов ) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. 
             Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов. 
             Вывести на экран значения массивов: массива А в одну строку, массива В — в виде матрицы. 
             Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, 
             общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В.
             */
            const int sizeA = 5;
            const int rows = 3;
            const int cols = 4;
            int[] a = new int[sizeA];
            double[][] b = new double[rows][];
            Random rand = new Random();
            double sum = 0;
            double multip = 1;
            int sumEvenA = 0;
            double sumEvenColsB = 0;
            for (int i = 0; i < sizeA; i++)
            {
                Console.Write("Введите значение a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Массив A: ");

            for (int i = 0; i < sizeA; i++)
            {
                Console.Write("{0} ", a[i]);
                sum += a[i];
                multip *= a[i];
                if (a[i] % 2 == 0)
                {
                    sumEvenA += a[i];
                }
            }
            Console.WriteLine("\nМассив B: ");
            double maxEl = a.Max();
            double minEl = a.Min();

            for (int i = 0; i < rows; i++)
            {
                b[i] = new double[cols];
                for (int j = 0; j < cols; j++)
                {
                    b[i][j] = rand.Next(1, 10);
                    sum += b[i][j];
                    multip *= b[i][j];
                    if (j % 2 == 1)
                    {
                        sumEvenColsB += b[i][j];
                    }
                    Console.Write("{0} ", b[i][j]);
                }
                maxEl = b[i].Max() > maxEl ? b[i].Max() : maxEl;
                minEl = b[i].Min() < minEl ? b[i].Min() : minEl;
                Console.WriteLine("");
            }
            Console.WriteLine("Максимальный элемент: {0}", maxEl);
            Console.WriteLine("Минимальный элемент: {0}", minEl);
            Console.WriteLine("Сумма всех элементов: {0}", sum);
            Console.WriteLine("Произведение всех элементов: {0}", multip);
            Console.WriteLine("Сумма четных элементов массива А: {0}", sumEvenA);
            Console.WriteLine("Cумму нечетных столбцов массива В: {0}", sumEvenColsB);

        }
    }
}
