namespace Ex5
{
    public class Program
    {
        public static void Main()
        {
            //Step 1 - getting the user input            
            Console.WriteLine("Please enter with the amount of your first paycheque of the month (CAD): ");
            float payCheq1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter with the amount of your second paycheque of the month (CAD): ");
            float payCheq2 = float.Parse(Console.ReadLine());
            Console.WriteLine("-----");
            float totalPay = payCheq1 + payCheq2;
            Console.WriteLine("Your total income in 1 month is: CAD " + totalPay);
            Console.WriteLine("----- \n");

            //projections for weekly expenses            
            Console.WriteLine("Enter with your predictions of weekly expenses: \n");
            Console.WriteLine("Food expenses and household expenses for 1 week: ");
            float weekFood = float.Parse(Console.ReadLine());
            Console.WriteLine("Common expenses for 1 week: ");
            float weekCommon = float.Parse(Console.ReadLine());

            Console.WriteLine("----- \n");
            float monthFood = 4 * weekFood;
            Console.WriteLine("Your expenses with food and household in 1 month are: CAD " + monthFood);
            float monthCommon = 4 * weekCommon;
            Console.WriteLine("Your common expenses in 1 month are: CAD " + monthCommon);
            Console.WriteLine("----- \n");
            //projections for monthly expenses            
            Console.WriteLine("Enter with your predictions of monthly expenses: \n");
            Console.WriteLine("Public Transit pass for 1 month: ");
            float transPass = float.Parse(Console.ReadLine());
            Console.WriteLine("Rent for 1 month: ");
            float rent = float.Parse(Console.ReadLine());
            Console.WriteLine("Monthly bills: ");
            float bills = float.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("In conclusion: ");
            Console.WriteLine("Cheq1 : CAD " + payCheq1);
            Console.WriteLine("Cheq2 : CAD " + payCheq2);
            Console.WriteLine("Total monthly income: CAD " + totalPay);
            Console.WriteLine("----- \n");
            float totalExpenses = monthFood + monthCommon + transPass + rent + bills;
            Console.WriteLine("Food   : CAD " + monthFood);
            Console.WriteLine("Common : CAD " + monthCommon);
            Console.WriteLine("PASS   : CAD " + transPass);
            Console.WriteLine("Rent   : CAD " + rent);
            Console.WriteLine("Bills  : CAD " + bills);
            Console.WriteLine("Total monthly expenses: CAD " + totalExpenses);
            Console.WriteLine("----- \n");
            float balance = totalPay - totalExpenses;
            Console.WriteLine("Your financial balance is: CAD " + balance);
            if (balance >= 0)
                Console.WriteLine("You have CAD " + balance + " to leisure activities and non-essential spending");
            else
                Console.WriteLine("You are spend more money that you can afford, try to spend less and save money");
        }

    }
}