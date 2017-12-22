using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Constances
    {
        private const int CONST_INT = 10;
        private const string CONST_STRING = "Test";

        public int GetInt()
        {
            return CONST_INT;
        }
         public string GetString()
        {
            return CONST_STRING;
        }   
    }
}
