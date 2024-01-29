namespace EX3
{
    public class program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the first integer number ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second integer number ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
                Console.WriteLine(number1 + " is greater than " + number2);
            else
                if (number1 < number2)
                Console.WriteLine(number2 + " is greater than " + number1);
            else
                if (number2 == number1)
                Console.WriteLine("These numbers are equal");
        }
    }
}