
namespace Ex16
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input
            Console.WriteLine("Enter the number of days: ");
            // number
            int numberDays = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of kWh: ");
            // number
            int numberKWH = int.Parse(Console.ReadLine());

            double billDay = numberDays * 0.50;

            double billKWH = 0;

            if (numberKWH > 200)
                billKWH = numberKWH * 0.20;
            else
                billKWH = numberKWH * 0.30;

            double totalBill = billDay + billKWH;

            Console.WriteLine("The total amount for the bill is: CAD " + totalBill);
        }
    }
}