using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    public class Person
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public int Money { get; private set; }

        public void AddMoney(int value)
        {
            Money += value;
        }
        public void RemoveMoney(int value)
        {
            if (value <= Money)
                Money -= value;
        }
        public int GetMoney()
        {
            return Money;
        }
        public Person(int startMoney)
        {
            Money = startMoney;
        }
        
    }
}
