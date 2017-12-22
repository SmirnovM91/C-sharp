using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             1.	В файле записана непустая последовательность целых чисел, являющихся числами Фибоначчи. Приписать еще столько же чисел этой последовательности.
2.	Сложить два целых числа А и В.
Входные данные
В единственной строке входного файла INPUT.TXT записано два натуральных числа через пробел.
Выходные данные
В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — сумму чисел А и В.
             */
            Tast1();
            Task2();
          
        }

        private static void Task2()
        {
            using (StreamReader stream = new StreamReader("Fibonachi.txt"))
            {
                string str = stream.ReadLine();
                var numbers = str.Split(' ');
                int sum = 0;
                foreach (var num in numbers)
                {
                    sum += int.Parse(num);
                }
                using (StreamWriter streamWriter = new StreamWriter("OUTPUT.txt"))
                {
                    streamWriter.WriteLine(sum);
                }
            }

        }
        private static void Tast1()
        {
            using (StreamReader stream = new StreamReader("Fibonachi.txt"))
            {
                string str = stream.ReadLine();
                var numbers = str.Split(' ').ToList();
                int count = numbers.Count;
                for (int i = 0; i < count; i++)
                {
                    int num = int.Parse(numbers[numbers.Count - 2]) + int.Parse(numbers[numbers.Count - 1]);
                    numbers.Add(num.ToString());
                }
                foreach (var num in numbers)
                {
                    Console.Write("{0} ", num);
                }

            }
            Console.ReadLine();
        }
    }
}
