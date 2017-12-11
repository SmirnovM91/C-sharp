using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  1.	Создать коллекцию List <int> . 
                    a) Вывести на экран позицию и значение элемента, являющегося вторым максимальным значением в коллекции. 
                    b) Вывести на экран сумму элементов на четных позичиях.
            */
            List<int> list = new List<int>();
            Random rand = new Random();
            int sum = 0;
            for (int i = 0; i < rand.Next(5, 15); i++)
            {
                int num = rand.Next(0, 20);
                list.Add(num);
                if (i%2 == 1)
                {
                    sum += num;
                }
                Console.Write(num+"\n");

            }
            list.Remove(list.Max());

            Console.WriteLine("Position = {0} SecondMaxValue = {1}", list.IndexOf(list.Max())+1, list.Max());
            Console.WriteLine("SumAvg = {0}",sum);
            Console.ReadLine();
        }
    }
}
