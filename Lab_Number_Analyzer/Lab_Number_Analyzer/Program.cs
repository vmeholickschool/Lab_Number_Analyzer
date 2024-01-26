
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine().ToLower().Trim();
        // Ask for number 

        Console.Write("Enter an integer between 1 and 100 inclusive; ");
        int userNumber = int.Parse(Console.ReadLine());


        for (int i = 0; i < userNumber; i++)
            if (i > 0 && i < 101)
            {
                continue;
            }


        // Use if/else statements to analyze the entered number
        if (userNumber <= 0 && userNumber > 100)
        {
            Console.WriteLine($"{userNumber} is not valid.");
        }
        else if (userNumber % 2 == 1 && userNumber < 60)
        {
            Console.WriteLine($"{userNumber} is Odd and less than 60.");
        }
        else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 24)
        {
            Console.WriteLine($"{userNumber} is even and less than 25.");
        }
        else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
        {
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        }
        else if (userNumber % 2 == 0 && userNumber > 60)
        {
            Console.WriteLine($"{userNumber} is Even and greater than 60.");
        }
        else if (userNumber % 2 == 1 && userNumber > 60)
        {
            Console.WriteLine($"{userNumber} is Odd and greater than 60.");
        }

        else if (userNumber <= 0 && userNumber > 100)
        {
            Console.WriteLine($"{userNumber} is not valid.");
        }



        Console.WriteLine($"Thank you, for using the Number Analyzer!");
    }
}