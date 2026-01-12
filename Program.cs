using Mission2Assignment;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?\nNumber?:");
        string userInput = System.Console.ReadLine();
        int numRolls = int.Parse(userInput);

        RollDices Dices = new RollDices(numRolls);
        decimal[] percentages = Dices.SimulateRolls();

        System.Console.WriteLine(
            "\nDICE ROLLING SIMULATION RESULTS\n" +
            "Each \"*\" represents 1% of the total number of rolls." +
            "\nTotal number of rolls = " + numRolls + ".\n"
            );

        for (int i = 2; i <= 12; i++) {
            System.Console.Write(i.ToString() + ": ");
            for (int j = 0; j < (int)Math.Round(percentages[i]); j++) {
                System.Console.Write("*");
            }
            System.Console.Write("\n");
        }
        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

    }
}