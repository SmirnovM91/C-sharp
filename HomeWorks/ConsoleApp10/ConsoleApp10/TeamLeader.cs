using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class TeamLeader : IWorker
    {
        public string Name { get; set; }
        public TeamLeader(string value)
        {
            Name = value;
        }
    }
}
