
internal class Program
{
    private static void Main(string[] args)
    {
        

        Console.Write("What is your name? ");
        string userName = Console.ReadLine().Trim();

        Console.Write("Enter an integer between 1 and 100 inclusive:");
        int userNumber = int.Parse(Console.ReadLine());


        if (userNumber <= 0 || userNumber > 100)
        {
            Console.WriteLine($"{userName}, {userNumber} is not valid.");
        }
        else if (userNumber % 2 == 1 && userNumber < 60)
        {
            Console.WriteLine($"{userName}, {userNumber} is odd and less than 60.");
        }
        else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 24)
        {
            Console.WriteLine($"{userName}, {userNumber} is even and less than 25.");
        }
        else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
        {
            Console.WriteLine($"{userName}, {userNumber} is even and between 26 and 60");
        }
        else if (userNumber % 2 == 0 && userNumber > 60)
        {
            Console.WriteLine($"{userName}, {userNumber} is Even and greater than 60.");
        }
        else if (userNumber % 2 == 1 && userNumber > 60)
        {
            Console.WriteLine($"{userName}, {userNumber} is Odd and greater than 60.");
        }

        else
        {
            Console.WriteLine($"{userName}, {userNumber} is not valid.");
        }



        Console.WriteLine($"{userName}, Thank you, for using the Number Analyzer!");

        Console.ReadKey();
    }
}