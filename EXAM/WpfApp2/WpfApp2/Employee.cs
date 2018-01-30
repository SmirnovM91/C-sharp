using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{

    public class Employee
    {
        public Guid Id { get; private set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public override string ToString()
        {
            return this.FullName;
        }
    }
}
