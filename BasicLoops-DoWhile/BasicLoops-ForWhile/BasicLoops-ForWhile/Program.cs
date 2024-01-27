// Prompt the user for a number.
//Use a for loop to output all the numbers from that number to 0. 
//After that loop finishes, use another loop to output all the numbers from 0 to that number.

do
{
    Console.Write("Enter a number: ");
    int userInput = int.Parse(Console.ReadLine());

    
    for (int i = userInput; i >= 0; i--)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
    
    for (int i = 0; i <= userInput; i++)
    {
        
        if (i < userInput)
        {
            Console.Write(i + " ");
        }
        else
        {
            Console.Write(i);
        }
    }

    Console.Write("\nDo you want to continue? (yes/no): ");
    string continueInput = Console.ReadLine().ToLower();

    if (continueInput != "yes")
    {
        Console.WriteLine("Goodbye!");
        break;
    }

    Console.WriteLine(); 

} while (true); 
