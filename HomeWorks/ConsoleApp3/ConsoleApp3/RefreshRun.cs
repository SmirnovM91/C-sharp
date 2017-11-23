using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public partial class Car
    {
        public void RefreshRun(out bool isDone)
        {
            SetRun(0);
            isDone = true;
        }
    }
}
