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

            Console.Write("How old are you, " + inp + "?");
            inp = Console.ReadLine();

            Console.WriteLine("So you are " + inp + " years old, huh? Cool!");
            
            Console.ReadKey();
        }
    }
}
