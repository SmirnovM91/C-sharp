using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public partial class Car
    {
        static int countCars;
        static int countBlackCars;
        string mark;
        string name;
        double volume;
        string color;
        int run;
        public Car()
        {
            mark = "Undefined";
            name = "Noname";
            volume = 0;
            color = "Black";
            run = 0;
            IncCount(color);
        }
        static Car()
        {
            countCars = 0;
        }
        static void IncCount(string c)
        {
            countCars++;
            if (c == "Black")
            {
                countBlackCars++;
            }
        }
        public static int GetCountCars()
        {
            return countCars;
        }
        public static int GetCountBlackCars()
        {
            return countBlackCars;
        }
        /// <summary>
        /// Создание новой машины
        /// </summary>
        /// <param name="m">Марка</param>
        /// <param name="n">Название</param>
        /// <param name="v">Объем</param>
        /// <param name="c">Цвет</param>
        /// <param name="r">Пробег</param>
        public Car(string m,string n, double v,string c,int r)
        {
            mark = m;
            name = n;
            volume = v;
            color = c;
            run = r;
            IncCount(color);
        }
        /// <summary>
        /// Создание новой машины(пробег по-умолчанию = 0)
        /// </summary>
        /// <param name="m">Марка</param>
        /// <param name="n">Название</param>
        /// <param name="v">Объем</param>
        /// <param name="c">Цвет</param>
        public Car(string m, string n, double v, string c)
        {
            mark = m;
            name = n;
            volume = v;
            color = c;
            run = 0;
            IncCount(color);
        }
        public string GetMark()
        {
            return mark;
        }
        public void SetMark(string val)
        {
            mark = val;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string val)
        {
            name = val;
        }
        public double GetVolume()
        {
            return volume;
        }
        public void SetVolume(double val)
        {
            volume = val;
        }
        public int GetRun()
        {
            return run;
        }
        public void SetRun(double val)
        {
            volume = run;
        }


    }
}
