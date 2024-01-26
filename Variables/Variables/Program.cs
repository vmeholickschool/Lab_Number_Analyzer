

bool isEligible = true;
if (isEligible)
{
    Console.WriteLine("You are eligible.");
}

int age = 12;
if (age <13)
{
    Console.WriteLine("You are child");
}
else if (age < 18)
{
    Console.WriteLine("You are a teenager");
}
else
{
    Console.WriteLine("You are an adult");
}

Console.Write("What is the game score?");

string userInput = Console.ReadLine();
int gamescore = int.Parse(userInput);

//int gameScore = int.Parse(Console.ReadLine());

if (gamescore >+= 90)
{
    Console.WriteLine("Great Job");
}

else if (gamescore >= 70)
{
    Console.WriteLine("Good job");
}
else
{
    Console.WriteLine("Good try");
}


int dayNumber = 3;

switch (dayNumber)
{
    case 1: 
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("That is not a day");
        break;
}


