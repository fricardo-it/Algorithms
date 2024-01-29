// 45 –	Write an algorithm that displays the first 100 numbers of the Fibonacci sequence.
// This sequence begins with the numbers 1, 1, 2, 3, 5, 8, …,
// where each new number in the sequence can be found by adding the two previous numbers in the sequence.


namespace Ex45
{
    public class Program
    {
        public static void Main()
        {
            //fibonacci

            const int numberElements = 100;
            double[] fibonacci = new double[numberElements];

            Console.Write("First " + numberElements + " numbers of Fibonacci is: \n");
            for (int i=0; i < numberElements; i++)
            {
                switch (i) {
                    case 0:
                        fibonacci[i] = 1;
                        break;
                    case 1:
                        fibonacci[i] = 1;
                        break;
                    default:
                        {
                            fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                            break;
                        }
                }
                Console.Write(fibonacci[i] + " ");
            }
        }
    }
}