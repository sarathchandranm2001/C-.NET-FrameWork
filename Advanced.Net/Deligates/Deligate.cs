//what is a deligate: 
//it is the representative of class
//A delegate in C# is a type that represents references to methods with a specific parameter list and return type.
//Delegates are used to pass methods as arguments to other methods, allowing for flexible and reusable code.
using System;

namespace Deligate_Generics
{
    internal class Program
    {
        // Define a delegate that can reference any method that takes two integers and returns an integer
        public delegate int SumDeligate(int x, int y);

        static void Main(string[] args)
        {
            // Instantiate the delegate, pointing it to the Add method
            SumDeligate sd = Add;

            // Use the delegate to call the method
            int result = sd(5, 3);

            // Print the result
            Console.WriteLine("The sum is: " + result);

            // You can also change the delegate to point to another method
            sd = Subtract;
            result = sd(5, 3);
            Console.WriteLine("The difference is: " + result);
        }

        // A method that matches the delegate signature
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Another method that matches the delegate signature
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}

