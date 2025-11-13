using System;

namespace Task1
{
    public class ExceptionHandlingTasks
    {
        // Number conversion with exception handling
        public void ConvertToInteger()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                Console.WriteLine($"Converted Number: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        // Password length validation with 'throw'
        public void CheckPassword()
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
        }
    }
}