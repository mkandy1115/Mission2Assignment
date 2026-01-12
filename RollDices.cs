using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2Assignment
{
    internal class RollDices
    {
        int numRolls;
        public RollDices()
        {
            Random rand = new Random();
            numRolls = rand.Next();
        }

        public RollDices(int userNum)
        {
            numRolls = userNum;
        }

        public decimal[] SimulateRolls()
        {
            int[] rollCounts = new int[13]; // index 0 and 1 will be unused
            Random rand = new Random();
            for (int i = 0; i < numRolls; i++)
            {
                int die1 = rand.Next(1, 7);
                int die2 = rand.Next(1, 7);
                int sum = die1 + die2;
                rollCounts[sum]++;
            }
            decimal[] percentages = new decimal[13];
            for (int i = 2; i <= 12; i++)
            {
                percentages[i] = (decimal)rollCounts[i] / numRolls * 100;
            }
            return percentages;
        }

    }
}
