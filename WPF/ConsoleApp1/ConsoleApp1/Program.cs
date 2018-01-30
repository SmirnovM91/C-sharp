using Shell32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = new Shell().NameSpace(@"C:\Users\User\Pictures");
            foreach (FolderItem2 item in folder.Items())
            {
                var company = item.ExtendedProperty("Company");
                var author = item.ExtendedProperty("Author");
                var name = item.Name;
                Console.WriteLine("FileName = {0}, Author = {1}", name,author);
                // Etc.
            }
        }
    }
}
