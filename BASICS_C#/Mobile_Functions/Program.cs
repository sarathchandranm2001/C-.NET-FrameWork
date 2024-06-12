namespace Mobile_Functions
{
    internal class Mobile_Functions
    {
        static void Main(string[] args)
        {
            Mobile mobile=new Mobile("Apple","11Pro");
            Console.WriteLine("Enter choice \t 1.Make Call \t2.Battery Level \t3.Exit");
            int choice=int.Parse(Console.ReadLine());
            while (choice != 3) {
                switch (choice) {
                case 1:
                        Console.WriteLine("Enter PhoneNumber :");
                        string phn=Console.ReadLine();
                        mobile.Make_Call(phn);
                        break;
                case 2:
                        Console.WriteLine("");
                        break;
                default: 
                        Console.WriteLine("Enter Valid Choice :");
                        break;
                 



                }

                Console.WriteLine("Enter choice \t 1.Make Call \t2.Battery Level \t3.Exit");
                choice=int.Parse(Console.ReadLine());

            }

            
        }
    }
}
