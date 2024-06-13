using System.Security.Cryptography.X509Certificates;

namespace Enum
{
    
    internal class Program
    {
        public enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,

        }
        static void Main(string[] args)
        {
            

            Days today = Days.Sunday;

            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("Today Is Sunday ");
                    break;
                case Days.Monday:
                    Console.WriteLine("Today is Monday");
                    break;
                    case Days.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;  
                    case Days.Wednesday:
                    Console.WriteLine("To day is wednesday");
                    break;
                    case Days.Thursday:
                    Console.WriteLine();
                    break;
                    case Days.Friday:
                    Console.WriteLine();
                    break;
                    case Days.Saturday:
                        Console.WriteLine();
                        break;
                    default: Console.WriteLine("fgdfgd");
                    break;
            }
        }
    }
}
