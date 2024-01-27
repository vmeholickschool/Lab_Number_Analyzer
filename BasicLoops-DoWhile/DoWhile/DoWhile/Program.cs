// Use a do-while loop to output "Hello, World!" in a loop
//Each time you output "Hello, World!" ask the user whether they would like to continue.

bool userContinue;
do
{
    Console.WriteLine("Hello, World!\n Would you like to continue (yes/no) ?");
    userContinue = Console.ReadLine().ToLower().Trim() == "y" ? true : false;
    } while (userContinue == true);
Console.WriteLine("Goodbye");
Console.ReadKey();