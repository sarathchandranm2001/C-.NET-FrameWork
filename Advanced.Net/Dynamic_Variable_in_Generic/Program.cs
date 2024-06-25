using System;

namespace Dynamic_Variable_in_Generic
{
    internal class Program
    {
        public void Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            T sum = x + y;
            Console.WriteLine($"Result of adding{a} and {b} :{sum}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two values to add");
            int x=int.Parse(Console.ReadLine());
            int y =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Two Strings to Concatinate");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();


            Program program = new Program();

            program.Add(x, y);
            program.Add(str1, str2); 
        }
    }
}
