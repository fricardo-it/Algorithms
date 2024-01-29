namespace Ex14
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input
            Console.WriteLine("Enter the number of copies: ");
            // number
            int numberCopies = int.Parse(Console.ReadLine());

            double price = 0;

            if (numberCopies <= 100)
                price = numberCopies * 0.05;
            else
            {
                int extendCopies = numberCopies - 100;
                double priceExtended = extendCopies * 0.03;
                price = (100 * 0.05) + priceExtended;
            }

            Console.WriteLine("The final price is: CAD "+ price);
        }
    }
}