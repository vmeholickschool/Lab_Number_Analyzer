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
        {
            if (number > 0) {
                Console.WriteLine($"You have selected {number} sides for your die: ");
            }
            else
            {
                Console.WriteLine("Your entry is invalid. Please select a numeric value: ");
            }
        }
        }
    
    }
