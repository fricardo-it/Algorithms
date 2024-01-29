namespace Ex11
{
    public class Program
    {
        public static void Main()
        {
            int number1 = 1;
            int number2 = 1;
            int number3 = 1;

            do
            {
                Console.Write("Input the number1 (positive, non zero): ");
                number1 = int.Parse(Console.ReadLine());
            } while (number1 < 1);

            do
            {
                Console.Write("Input the number2 (positive, non zero): ");
                number2 = int.Parse(Console.ReadLine());
            } while (number2 < 1);

            do
            {
                Console.Write("Input the number3 (positive, non zero): ");
                number3 = int.Parse(Console.ReadLine());
            } while (number3 < 1);

            if ((number1 > number2) && (number1 > number3))
            {
                //a² = (b² + c²)
                if ((number1 * number1) == ((number2 * number2) + (number3 * number3)))
                {
                    Console.WriteLine("its a right triangle");
                }
                else
                    Console.WriteLine("its not a right triangle");
            }
            else
                if ((number2 > number1) && (number2 > number3))
            {
                //b² = (a² + c²)
                if ((number2 * number2) == ((number1 * number1) + (number3 * number3)))
                {
                    Console.WriteLine("its a right triangle");
                }
                else
                    Console.WriteLine("its not a right triangle");
            }
            else
                    if ((number3 > number1) && (number3 > number2))
            {
                //c² = (a² + b²)
                if ((number3 * number3) == ((number1 * number1) + (number2 * number2)))
                {
                    Console.WriteLine("its a right triangle");
                }
                else
                    Console.WriteLine("its not a right triangle");
            }
        }
    }
}
