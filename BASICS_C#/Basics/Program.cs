namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Program for checking Odd or Even Number");
            Console.WriteLine("Enter a Number :");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Even Number");

            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.WriteLine("Program For Checking the Day by giving a number ");
            Console.WriteLine("Enter a Number :");
            int b= int.Parse(Console.ReadLine());
            switch (b)
            {
                case 1: Console.WriteLine("Monday");
                    break;
                    case 2: Console.WriteLine("Tuesday");
                    break;
                    case 3: Console.WriteLine("Wednesday");
                    break;
                    case 4: Console.WriteLine("Thursday");
                    break;
                    case 5: Console.WriteLine("Friday");
                    break;
                    case 6: Console.WriteLine("Saturday");
                    break;
                    case 7: Console.WriteLine("Sunday");
                    break;
                    default: Console.WriteLine("Enter A Valid Number");
                    break;
            }
        }
    }
}
