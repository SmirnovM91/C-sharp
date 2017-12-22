using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class PropertyEventArgs
    {
        public object Property { get; set; }
        public PropertyEventArgs(object property)
        {
            this.Property = property;
        }
    }
}
