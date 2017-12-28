using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{

    public enum Sex
    {
        FEMALE,
        MALE
    }
    public enum EduType
    {
        TYPE1,
        TYPE2
    }
    public struct Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupName { get; set; }
        public double AvgValue { get; set; }
        public int ParentsSalary { get; set; }
        public Sex Sex { get; set; }
        public EduType EduType { get; set; }
       
    }
}
