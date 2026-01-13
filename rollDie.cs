using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2
{
    internal class rollDie
    {
        private static double rollTwoDie()
        {
            double die1, die2;

            Random random = new Random();
            die1 = random.Next(1, 7);
            die2 = random.Next(1, 7);

            return die1 + die2;
        }

        public static List<double> rollLoop(double numrolls)
        {
            double rolls = 0;
            double result;
            var rollTotals = new List<double>();


            while (rolls < numrolls)
            {
                result = rollTwoDie();
                rollTotals.Add(result);
                rolls++;
            }

            return rollTotals;
        }
    }
}
