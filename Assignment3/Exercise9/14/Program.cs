namespace Ex14
{
    public class Program
    {
        public static void Main()
        {
            int i = 0;
            double prod = 1;
            for (i = 1; i <= 15; i++)
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    prod *= i;
                }
            Console.WriteLine();
            Console.WriteLine("the product of the odd numbers between 1 and 15 are: " + prod);

        }
    }
}