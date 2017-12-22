using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class TestClass : IPropertyChanged
    {


      
        private int _propertyInt;
        private string _propertyString;
        public int PropertyInt
        {
            get
            {
                return _propertyInt;
            }
            set
            {
                _propertyInt = value;
                PropertyChanged(this,new PropertyEventArgs(value));
            }
        }
        public string PropertyString
        {
            get
            {
                return _propertyString;
            }
            set
            {
                _propertyString = value;
                PropertyChanged(this, new PropertyEventArgs(value));
            }
        }
        public event PropertyEventHanlder PropertyChanged;

    }
}
