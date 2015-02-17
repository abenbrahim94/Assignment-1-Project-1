using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"Welcome to Program1\"");
            Console.WriteLine();
            Console.Write("Type any character: ");
            string prompt = Console.ReadLine();
            char newValue = Convert.ToChar(prompt);
            Console.WriteLine("Your Response is: \"{0}\"", newValue);
            Console.WriteLine();
            Console.WriteLine("\"Press any key to exit\"");
            Console.ReadKey();
        }
    }
}