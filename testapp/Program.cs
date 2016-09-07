using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            var inp = Console.ReadLine();
            Console.Write("Hello, " + inp + "!");
            
            Console.ReadKey();
        }
    }
}
