using System;

internal class Program
{
    public delegate int SumDelegate(int x, int y);

    public static void Main(string[] args)
    {
        SumDelegate sd1 = delegate (int x, int y) { return x + y; };
        Console.WriteLine(sd1(20, 30));
    }
}
