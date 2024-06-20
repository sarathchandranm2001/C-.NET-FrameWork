using System;

namespace Module2_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Dividend: ");
                float a = float.Parse(Console.ReadLine());

                Console.Write("Divisor: ");
                float b = float.Parse(Console.ReadLine());

                if (b == 0)
                {
                    Console.WriteLine("Denominator cannot be zero.");
                }
                else
                {
                    float c = a / b;
                    Console.WriteLine("Result: " + c);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
