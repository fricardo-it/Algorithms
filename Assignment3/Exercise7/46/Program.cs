//46 –	Write a program that displays all the prime numbers from 1 to 50,000.

namespace Ex46
{
    public class Program
    {
        public static void Main()
        {

            int qty = 50000;                        //qty of numbers 
            int[] arrayPrime = new int[qty];        //array prime numbers
            bool control = false;                   //control if any before is divisible
            int qtyPrime = 0;                       //qty numbers prime found
            bool prime = false;
            int j = 0;

            //from number-1 to 2, decreasing 1 each loop
            //control false is none % == 0

            while (qty > 0)
            {
                j = qty - 1;
                control = false;
                while (j > 1)
                {
                    if (control == false)
                        if ((qty % j == 0))
                        {
                            prime = false;
                            control = true;
                        }
                        else
                        {
                            prime = true;
                        }
                    j--;
                }
                if (prime == true)
                {
                    arrayPrime[qtyPrime] = qty;
                    Console.Write(arrayPrime[qtyPrime] + " ");
                    qtyPrime++;
                }
                qty--;
            }
        }
    }
}