using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Money
    {
        private int nominal;
        private int count;
        public Money(int n = 0, int c = 0)
        {
            nominal = n;
            count = c;
        }
        public int GetNominal()
        {
            return nominal;
        }
        public int GetCount()
        {
            return count;
        }
        public void SetNominal(int val)
        {
            nominal = val;
        }
        public void SetCount(int val)
        {
            count = val;
        }
        public bool IsEnough(int val)
        {
            return count * nominal <= val;
        }
        public int GetCountItemsToBuy(int price)
        {
            return count * nominal / price;
        }
        public int GetMoneyValue()
        {
            return count * nominal;
        }

    }
}
