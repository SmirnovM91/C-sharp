using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Window : IPart
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public Window(int w, int h, int l)
        {
            Width = w;
            Height = h;
            Length = l;
        }
    }
}
