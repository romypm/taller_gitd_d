using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int result = sum(2, 3);
        }
        public int sum (int n1, int n2) 
        {
            return n1 + n2;
        }
    }
}