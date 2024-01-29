
namespace Ex17
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input
            Console.WriteLine("Enter the number: ");
            // number
            int number = int.Parse(Console.ReadLine());

            if ((number % 2) == 0)
                Console.WriteLine(number + " is even number");
            else
                Console.WriteLine(number + " is odd number");
        }
    }
}