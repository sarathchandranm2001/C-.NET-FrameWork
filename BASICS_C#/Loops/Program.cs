using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outer loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j);  // Executes 6 times (2 * 3)
                }
            }

            int i=0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}

