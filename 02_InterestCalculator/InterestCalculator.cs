using System;

namespace _02_InterestCalculator
{
    class InterestCalculator
    {
        public decimal Amount { get; private set; }
        public double Interest { get; private set; }
        public int Years { get; private set; }
        private Func<decimal, double, int, decimal> calculateInterest;

        public decimal CalculatedAmount
        {
            get { return this.calculateInterest(this.Amount, this.Interest, this.Years); }
        }

        public InterestCalculator(decimal amount, double interest, int years, 
            Func<decimal, double, int, decimal> func)
        {
            this.Amount = amount;
            this.Interest = interest;
            this.Years = years;
            this.calculateInterest = func;
        }


    }
}
