
namespace Ex19
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input
            Console.WriteLine("Enter the first number (a): ");
            // a
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number (b): ");
            // b
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number (c): ");
            // c
            int c = int.Parse(Console.ReadLine());
            if ((a == 0) && (b == 0) && (c == 0))
               Console.WriteLine("'a' or 'b' or 'c' is equal the sum of the other two");
            else if (a == (b + c))
                Console.WriteLine("'a' is equal 'b' + 'c'");
            else if (b == (a + c))
                Console.WriteLine("'b' is equal 'a' + 'c'");
            else if (c == (a + b))
                Console.WriteLine("'c' is equal 'a' + 'b'");
            else 
                Console.WriteLine("No Solution");
        }
    }
}