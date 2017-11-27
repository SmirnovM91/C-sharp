using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания (1-5) = ");
            switch (Console.ReadLine())
            {
                case "1":
                    ToDo1();
                    break;
                case "2":
                    ToDo2();
                    break;
                case "3":
                    ToDo3();
                    break;
                case "4":
                    ToDo4();
                    break;
                case "5":
                    ToDo5();
                    break;

            }
            Console.ReadKey();

        }
        static public void ToDo1()
        {
            //1.	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов.
            Console.WriteLine("Введите строку и в конце ввода поставьте точку =");
            int countSpace = 0;
            char symbol;
            while ((symbol = Console.ReadKey().KeyChar) != '.')
            {
                if (symbol == ' ')
                    countSpace++;
            }
            Console.WriteLine("\nКол-во пробелов {0}", countSpace);
        }
        static public void ToDo2()
        {
            /*
            2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) и про-верить является ли данный билет счастливым 
            (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
            */
            Console.WriteLine("Введите номер билета =");
            string bilet = Console.ReadLine();

            int firstPart = int.Parse(bilet[0].ToString()) + int.Parse(bilet[1].ToString()) + int.Parse(bilet[2].ToString());
            int secondPart = int.Parse(bilet[3].ToString()) + int.Parse(bilet[4].ToString()) + int.Parse(bilet[5].ToString());
            if (firstPart == secondPart)
            {
                Console.WriteLine("Билет счастливый!!");
            }
            else
            {
                Console.WriteLine("Билет НЕсчастливый!!");
            }
        }
        static public void ToDo3()
        {
            /*
            3.	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. 
                Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.
            */
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            int upCaseEnd = 90;  // Символ "Z"
            int distanse = 32;
            foreach (var ch in str)
            {
                if (ch > upCaseEnd)
                {
                    Console.Write((char)((int)ch - 32));
                }
                else
                {
                    Console.Write((char)((int)ch + 32));
                }
            }
            Console.ReadKey();
        }
        static public void ToDo4()
        {
            /*
             4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; 
                при этом каждое число должно выводиться количество раз, равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
		        3 3 3
                4 4 4 4
                5 5 5 5 5
                6 6 6 6 6 6
                7 7 7 7 7 7 7
             */
            Console.Write("Введите а =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b =");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.Write("\n");
            }
        }
        static public void ToDo5()
        {
            /*
            5.	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. Например, если было введено число 345, то программа должна вывести число 543.
            */
            Console.Write("Введите число =");
            string str = Console.ReadLine();
            Console.Write((str.Reverse().ToArray()));
        }
    }

}
