//35 –	Write an algorithm that calculates the sum of all the integers contained (inclusively) between two positive integer limits entered by the user.
//The program reads the smallest limit first. Example: the sum of the integers between 5 and 10, inclusively

namespace Ex35
{
    public class Program
    {
        public static void Main()
        {
            int min, max, sum = 0, sum2 = 0;

            Console.WriteLine("-----FOR------ \n");


            Console.WriteLine("Enter the inferior limit (integer number): ");
            min = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the upper limit (integer number): ");
            max = int.Parse(Console.ReadLine());

            if (min > max)
            {
                Console.WriteLine("Min > Max, restart the program and try again");
            }
            else
            {
                for (int i = min; i <= max; i++)
                    sum = sum + i;
                Console.WriteLine("Sum of the number is " + sum);
            }

            //-------------------------------------------------

            Console.WriteLine("\n-----WHILE------ \n");

            Console.WriteLine("Enter the inferior limit (integer number): ");
            min = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the upper limit (integer number): ");
            max = int.Parse(Console.ReadLine());

            if (min > max)
            {
                Console.WriteLine("Min > Max, restart the program and try again");
            }
            else
            {
                int j = min;
                while (j <= max)
                {
                    sum2 = sum2 + j;
                    j++;
                }
                Console.WriteLine("Sum of the number is " + sum2);
            }
        }
    }
}
