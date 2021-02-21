using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleModule
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            Console.WriteLine("Hello, Wrld");
            int age = Convert.ToInt32(Console.ReadLine());
            var number = 123444444;
            Console.WriteLine(number);
            string name = Console.ReadLine();
            Console.WriteLine($"Age is {age}\nName is {name}");
            Console.ReadKey();
        }
    }
}
