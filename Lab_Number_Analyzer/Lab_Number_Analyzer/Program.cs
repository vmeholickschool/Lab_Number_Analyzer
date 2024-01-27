using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine().Trim();
        int userNumber = 0;
        bool playAgain;

        do
        {
            Console.Write("Enter an integer between 1 and 100 inclusive: ");

            while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1 || userNumber > 100)
            {
                Console.Write($"{userName}, {userNumber} is not valid. Please enter an integer between 1 and 100 inclusive: ");
            }

            if (userNumber % 2 == 1 && userNumber < 60)
            {
                Console.WriteLine($"{userName}, {userNumber} is odd and less than 60.");
            }
            else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 24)
            {
                Console.WriteLine($"{userName}, {userNumber} is even and less than 25.");
            }
            else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
            {
                Console.WriteLine($"{userName}, {userNumber} is even and between 26 and 60.");
            }
            else if (userNumber % 2 == 0 && userNumber > 60)
            {
                Console.WriteLine($"{userName}, {userNumber} is even and greater than 60.");
            }
            else if (userNumber % 2 == 1 && userNumber > 60)
            {
                Console.WriteLine($"{userName}, {userNumber} is odd and greater than 60.");
            }
            else
            {
                Console.WriteLine($"{userName}, {userNumber} is not valid.");
            }

            Console.Write("Do you want to play again? (y/n): ");
            playAgain = Console.ReadLine().Trim().ToLower() == "y";
        } while (playAgain);

        Console.WriteLine($"{userName}, Thank you for using the Number Analyzer!");
    }
}



