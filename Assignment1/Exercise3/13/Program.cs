namespace Ex13
{
    public class Program {
        public static void Main() {
            Console.WriteLine(" how many diskette are you going to buy ");
            int quantity = int.Parse(Console.ReadLine());
            float price;
            if (quantity <= 25)
                price = 1;
            else
                price = 0.7F;

            float priceBeforeDiscount = (price * quantity);
            Console.WriteLine(" Are you a member (yes or no)");
            string answer = (Console.ReadLine());

            if (answer == "yes")
            {
                float priceAfterDiscount = (priceBeforeDiscount * ((priceBeforeDiscount * 2)/100));
                Console.WriteLine("your total is " + (priceAfterDiscount));
            }
            else
                Console.WriteLine("your total is " + priceBeforeDiscount);
        }
    }
}

