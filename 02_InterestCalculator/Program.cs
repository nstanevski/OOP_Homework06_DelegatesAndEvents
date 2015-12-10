using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InterestCalculator
{
    class Program
    {
        static void Main()
        {
            Func<decimal, double, int, decimal> CalculateInterest;

            InterestType interestType = InterestType.Compound;

            if (interestType == InterestType.Simple)
            {
                CalculateInterest = GetSimpleInterst;
            }
            else
            {
                CalculateInterest = GetCompoundInterest;
            }

            //InterestCalculator interestCalculator = new InterestCalculator(2500, 7.2, 15, CalculateInterest);
            InterestCalculator interestCalculator = new InterestCalculator(500, 5.6, 10, CalculateInterest);
            decimal calculatedAmount = interestCalculator.CalculatedAmount;
            Console.WriteLine("Result: {0:F4}", calculatedAmount);

        }

        private static decimal GetCompoundInterest(decimal amount, double interest, int years)
        {
            const int NumbersPerYear = 12;
            return amount * (decimal)Math.Pow(1 + interest / 100.0 / NumbersPerYear, 
                years * NumbersPerYear);
        }

        private static decimal GetSimpleInterst(decimal amount, double interest, int years)
        {
            return amount * (decimal)(1 + (interest / 100) * years);
        }
    }
}
