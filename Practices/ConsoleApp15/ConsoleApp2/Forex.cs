using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public delegate void ForexHandler(int value);

    public class Forex
    {
        private ForexHandler _handler;
        public void SetHandler(ForexHandler handler)
        {
            _handler += handler;
        }
        public void UnSetHandler(ForexHandler handler)
        {
            _handler -= handler;
        }
        public void Buy(Person person, int value)
        {
            person.RemoveMoney(value);
            if (_handler != null)
                _handler.Invoke(value);
        }
        public void Sell(Person person, int value)
        {
            person.AddMoney(value);
            if (_handler != null)
                _handler.Invoke(value);
        }
    }
}
