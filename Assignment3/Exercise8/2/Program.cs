namespace Ex2
{
    public class program
    {



        public static void Main()
        {



            Console.WriteLine(" Please enter the first number");
            float number1 = float.Parse(Console.ReadLine());



            Console.WriteLine(" Please enter the seconde number");
            float number2 = float.Parse(Console.ReadLine());



            Console.WriteLine(" The sum of the two numbers is: " + (number1 + number2));



            Console.WriteLine(" The product of the two numbers is: " + (number1 * number2));


            Console.WriteLine(" The difference between the two numbers is: " + (number1 - number2));



            Console.WriteLine(" The Quotient of the two numbers is: " + (number1 / number2));



        }
    }

}