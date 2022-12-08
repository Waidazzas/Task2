using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Write a first number: ");
                int NumberA = int.Parse(Console.ReadLine());
                Console.Write("Write a second number: ");
                int NumberB = int.Parse(Console.ReadLine());
                int Result = NumberA + NumberB;
                Console.WriteLine($"Sum is: {Result}");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("You have entered an incorrect value!");
                Console.ReadKey();
            }
        }
    }
}
