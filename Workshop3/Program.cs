using System;

class Program
{
    static void Main(string[] args)
    {    //Task1
        Operators op = new Operators();

        op.Add(10, 10);
        op.Subtract(10, 5);
        op.Multiply(10, 5);
        op.Divide(10, 5);
        op.OddEvenFinder(10);
        op.OddEvenFinder(9);

        //Task2
        NullOperations nullOps = new NullOperations();
        nullOps.PerformNullChecks();

        //Task3
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 13)
        {
            Console.WriteLine("You are a child.");
        }
        else if (age >= 13 && age < 20)
        {
            Console.WriteLine("You are a teenager.");
        }
        else if (age >= 20 && age < 60)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a senior citizen.");
        }
        //Task4
        Console.Write("Enter a number (1–7): ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day number");
                break;
        }
        //Task5
        Console.Write("Enter a number (N): ");
        int N = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Sum from 1 to {N} = {sum}");

        Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");
        int number = 1;

        while (number <= 20)
        {
            if (number == 15)
                break;

            if (number % 4 == 0)
            {
                number++;
                continue;
            }

            Console.WriteLine(number);
            number++;
        }

        int[] numbers = { 5, 10, 15, 20, 25 };
        int total = 0;

        foreach (int num in numbers)
        {
            total += num;
        }

        Console.WriteLine($"\nSum of all elements in the array = {total}");
        Console.ReadLine();

    }
}
