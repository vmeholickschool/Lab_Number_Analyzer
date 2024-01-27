using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        bool doorLocked = true;

        while (doorLocked)
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
                Console.WriteLine("Wrong Code, please enter your keycode: ");
            }

        }
        Console.ReadLine();
    }

}
