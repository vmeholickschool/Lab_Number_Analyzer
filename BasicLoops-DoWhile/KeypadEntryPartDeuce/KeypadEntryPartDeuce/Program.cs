internal class Program
{
    private static void Main(string[] args)
    {
        bool doorLocked = true;
        int i = 0;

        while (doorLocked && i < 5)
        {
            Console.Write("Enter your keycode: ");
            string userKeyCode = Console.ReadLine();

            if (userKeyCode == "13579")
            {
                doorLocked = false;
                Console.WriteLine("Welcome Home!");
            }
            else
            {
                i++;

                if (i >= 5)
                {
                    Console.WriteLine("You have now made too many incorrect attempts, the door cannot be unlocked at this time.");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Code, please enter the correct keycode.");
                }
            }
        }

        Console.ReadLine();
    }
}