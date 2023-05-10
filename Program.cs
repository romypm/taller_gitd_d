using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int result = sum(2, 3);
            string nombrecompleto = nombrecompleto("andy", "guzman");
        }
        public int sum (int n1, int n2) 
        {
            return n1 + n2;
        }
        public string nombrecompleto(string name, string lastname) 
        {
            return name + lastname;
        }
    }
}