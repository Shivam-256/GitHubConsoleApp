using System;

namespace GitHubConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Add(123, 22);
            Subtract(222, 211);
            Console.WriteLine( "end of program");
        }
        static void Add(int num1, int num2)
        {
            Console.WriteLine("Sum is {0}", num1+num2);
        }
        static void Subtract(int num1, int num2)
        {
            Console.WriteLine("Diff. is {0}", num1 - num2);
        }
    }
}
