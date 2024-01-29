
namespace Ex18
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input
            Console.WriteLine("Enter the number (m): ");
            // m
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number (n): ");
            // n
            int n = int.Parse(Console.ReadLine());

            if ((m%n) == 0)
                Console.WriteLine(m + " is multiple of " + n);
            else 
                Console.WriteLine("m is not multiple of n");
        }
    }
}