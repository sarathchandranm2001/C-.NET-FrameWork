using System;
using System.Threading;
internal class Program
{
    static void PrintNumbers(){
        for(int i=1;i<=10;i++){
            Console.WriteLine(i);
            Thread.Sleep(500);
        }
    }
    
    static void Main(String [] args){
        Thread numberThread=new Thread(new ThreadStart(PrintNumbers));
        numberThread.Start();
           for (char c = 'A'; c <= 'J'; c++)
        {
            Console.WriteLine(c);
            Thread.Sleep(500); // Sleep for 500 milliseconds
        }

        // Wait for the numberThread to finish before exiting
        numberThread.Join();
    }
}