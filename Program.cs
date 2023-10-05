# Module 4.1 


using System;
class Program
{
    static void Main()
    {
        Console.Write("Perfect Number finder\n");
        Console.Write("Enter a number (1 - 10000): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 1 && number <= 10000)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine($"{number} perfect number.");
            }
            else
            {
                Console.WriteLine($"{number} not a perfect number.");
            }
        }
        else
        {
            Console.WriteLine("Enter a number, not a letter!");
            Console.WriteLine("Try again");
        }
    }
}

