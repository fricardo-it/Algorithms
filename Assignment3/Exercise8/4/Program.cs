namespace Ex4
{

    public class program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the first integer number ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second integer number ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third integer number ");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(" The sum of the numbers is: " + (number1 + number2 + number3));

            Console.WriteLine(" The average of the number is: " + ((number1 + number2 + number3) / 3));

            Console.WriteLine(" The product of the numbers is: " + (number1 * number2 * number3));

            if (number1 > number2 && number1 > number3)
                Console.WriteLine(" The largest number is: " + number1);
            else
                if (number2 > number3 && number2 > number1)
                Console.WriteLine(" The largest number is: " + number2);
            else
                if (number3 > number1 && number3 > number2)
                Console.WriteLine(" The largest number is: " + number3);

            if (number1 < number2 && number1 < number3)
                Console.WriteLine(" The smallest number is: " + number1);
            else
                if (number2 < number3 && number2 < number1)
                Console.WriteLine(" The smallest number is: " + number2);
            else
                if (number3 < number1 && number3 < number2)
                Console.WriteLine(" The smallest number is: " + number3);

        }
    }
}