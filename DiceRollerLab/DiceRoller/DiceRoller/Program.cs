//Create an application that simulates dice rolling

using System;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int diceRoll = randomGenerator.Next(1,30);
    
        
        Console.WriteLine("Welcome to Grand Circus Casino! ");
        Console.WriteLine("Please enter the number of sides for a pair of dice: ");
        int number = int.Parse(Console.ReadLine());
        }
    
    }
}