using System;

class PasswordCheck
{
    static void Main(string[] args)
    {
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        try
        {
            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }
            Console.WriteLine("Password satisfied the requirement");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}
