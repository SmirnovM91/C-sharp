using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class DisplayName : Attribute
    {
        public string Name { get; set; }
        

        public DisplayName()
        { }

        public DisplayName(string name)
        {
            Name = name;
        }
    }
}
