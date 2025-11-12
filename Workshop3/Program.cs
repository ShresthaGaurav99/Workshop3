using System;

class Program
{
    static void Main(string[] args)
    {
        Operators op = new Operators();

        op.Add(10, 5);
        op.Subtract(10, 5);
        op.Multiply(10, 5);
        op.Divide(10, 5);
        op.OddEvenFinder(10);
        op.OddEvenFinder(7);

        Console.ReadLine(); // To keep console open
    }
}
