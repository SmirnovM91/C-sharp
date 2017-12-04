using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class RangeOfArray
    {
        public int minIndex;
        public int maxIndex;
        private object[] arr;
        public object this[int index]
        {
            get
            {

                return arr[index - minIndex];
            }
            set
            {
                arr[index - minIndex] = value;
            }
        }
        public RangeOfArray(int min, int max)
        {
            if (min < max)
            {
                minIndex = min;
                maxIndex = max;
                arr = new object[max - min + 1];
            }
            else
            {
                minIndex = max;
                maxIndex = min;
                arr = new object[min - max + 1];
            }

        }
    }
}
