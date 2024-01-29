namespace Ex26
{
    public class Program
    {
        public static void Main()
        {
            //step1 - getting the user input
            Console.WriteLine("Insert the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Insert the second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Insert the third number:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //step2 - comparison
            int high;
            int med;
            int low;
            if (num1 > num2)
            {
                med = num1;
                low = num2;
            }
            else
            {
                med = num2;
                low = num1;
            }
            if (med > num3)
            {
                high = med;
                if (low > num3)
                {
                    med = low;
                    low = num3;
                }
                else
                {
                    med = num3;
                }
            }
            else high = num3;

            Console.WriteLine("The ascending order is: " + low + ", " + med + ", " + high);
        }
    }
}