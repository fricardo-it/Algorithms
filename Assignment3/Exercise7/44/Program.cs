// 44 –	You just won a million dollars! You decide to invest $500,000 in a term deposit for a period of 5 years.
// The annual interest rate is 10%, and the interest is added to the principal sum each year (compound interest).
// How much will your savings be worth in 5 years?

// a)	Make the algorithm with specified number (internal data).
// b)	Generalize for any amount, any duration, and any interest rate.



using System;
using System.Runtime.ConstrainedExecution;

namespace Ex44
{
    public class Program
    {
        public static void Main()
        {
            // a) fixed
            Console.WriteLine("a) fixed \n");

            const double award = 500000.00;
            const double rate = 0.10;
            const int time = 5;
            double savings = 0;

            for(int i = 0; i < time; i++)
            {
                switch (i)
                {
                    case 0:
                        savings = award * (1 + rate);
                        break;
                    default: 
                        savings = savings * (1 + rate);
                        break;
                }
                Console.WriteLine("savings year "+ (i+1) + " : CAD "+ savings);
            }
            Console.WriteLine("Total savings: CAD " + savings);

            // b) inputs
            Console.WriteLine("\n\nb) inputs \n");

            double award2 = 0;
            double rate2 = 0;
            int time2 = 0;
            double savings2 = 0;

            Console.Write("Enter your grand award: \n CAD ");
            award2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the interest rate (% by year): \n");
            rate2 = double.Parse(Console.ReadLine());

            Console.Write("Enter how many years will be the investmet: \n ");
            time2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < time2; i++)
            {
                switch (i)
                {
                    case 0:
                        savings2 = award2 * (1 + (rate2/100));
                        break;
                    default:
                        savings2 = savings2 * (1 + (rate2/100));
                        break;
                }
                Console.WriteLine("An award of " + award2 + " at a rate of " + rate2 + " % per annum, generated a bonus of " + savings2 + " in "+ i+1 + " year");
            }
            Console.WriteLine("Summary: \n Award: CAD " + award2 + " \n Rate per annum (%): " + rate2 + "\n During : " + time2 +" years ");
            Console.WriteLine("Generated a total savings of: CAD " + savings2);
        }
    }
}