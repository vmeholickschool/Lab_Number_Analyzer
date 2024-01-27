internal class Program
{
    private static void Main(string[] args)
    {
        bool doorLocked = true;
        int attempts = 0;

        do
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
                attempts++;

                if (attempts < 5)
                {
                    Console.WriteLine("Wrong Code, please enter the correct keycode.");
                }
                else
                {
                    Console.WriteLine("You have now made too many incorrect attempts, the door cannot be unlocked at this time.");
                    break;
                }
            }
        } while (doorLocked && attempts < 5);

        Console.ReadLine();
    }
}