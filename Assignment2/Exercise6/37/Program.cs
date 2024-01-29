//37 –	Write an algorithm that reads a positive integer ( > 0 ) and determines whether it is a prime number.
// (Hint: try dividing the number by the numbers coming before it.) Validate the input.

namespace Ex37
{
    public class Program
    {
        public static void Main()
        {
            int number = 0;
            bool control = false;
            bool prime = false;
            Console.WriteLine("-----FOR------ \n");

            do
            {
                Console.WriteLine("Enter a positive integer (>0): ");
                number = int.Parse(Console.ReadLine());
            } while (number < 1);

            //from number-1 to 2, decreasing 1 each loop
            //control false is none % == 0
            for (int i = number - 1; i > 1; i--)
            {
                if (control == false)
                    if ((number % i == 0))
                    {
                        prime = false;
                        control = true;
                    }
                    else
                        prime = true;
            }
            if (prime == true)
                Console.WriteLine("Number " + number + " is prime");
            else
                Console.WriteLine("Number " + number + " is not prime");


            //-------------------------------------------------

            Console.WriteLine("\n-----WHILE------ \n");

            do
            {
                Console.WriteLine("Enter a positive integer (>0): ");
                number = int.Parse(Console.ReadLine());
            } while (number < 1);

            //from number-1 to 2, decreasing 1 each loop
            //control false is none % == 0
            int j = number - 1;
            control = false;
            while (j > 1)
            {
                if (control == false)
                    if ((number % j == 0))
                    {
                        prime = false;
                        control = true;
                    }
                    else
                        prime = true;
                j--;
            }
            if (prime == true)
                Console.WriteLine("Number " + number + " is prime");
            else
                Console.WriteLine("Number " + number + " is not prime");

        }
    }
}
