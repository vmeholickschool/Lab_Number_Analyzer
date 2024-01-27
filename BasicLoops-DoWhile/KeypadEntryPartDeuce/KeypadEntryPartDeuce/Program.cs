internal class Program
{
    private static void Main(string[] args)
    {
        bool doorLocked = true;
        int numAttempts = 0;
        int maxNumAttempts = 5;

        while (doorLocked && numAttempts < maxNumAttempts)
        {
            Console.Write("Enter your keycode: ");
            string userKeyCode = Console.ReadLine();

            if (userKeyCode == "13579")
            {
                doorLocked = false;
                Console.WriteLine("Welcome Home!");
            }

            {
                if (numAttempts + 2 == maxNumAttempts)
                {
                    Console.WriteLine("You have now made too many incorrect attempts, the door cannot be unlocked at this time.");
                    break;
                }
            }

            numAttempts++;
        }

        Console.ReadLine();
    }
}
