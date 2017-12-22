using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public delegate void PropertyEventHanlder(object sender, PropertyEventArgs args);
    public interface IPropertyChanged
    {

        event PropertyEventHanlder PropertyChanged;
    }
}
