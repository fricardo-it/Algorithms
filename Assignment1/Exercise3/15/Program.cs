namespace Ex15
{ 
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input
            Console.WriteLine("Enter the amount current balance: ");
            // number
            float currentBalance = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount withdrawal: ");
            // number
            float withdrawal = float.Parse(Console.ReadLine());

            if (withdrawal > currentBalance)
                Console.WriteLine("You have no enough money. Try again with a lower value.");
            else
            {
                float newBalance = currentBalance - withdrawal;
                Console.WriteLine("Take your money. Your new balance is: CAD " + newBalance);
            }
        }
    }
}