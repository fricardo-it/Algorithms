namespace Ex2
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input            
            Console.WriteLine("Please enter the item name: ");
            //item name            
            string itemName = Console.ReadLine();

            Console.WriteLine("Please enter the unit price: ");
            //unit price            
            float unitPrice = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the quantity: ");
            //qty Purchased            
            float qtyPurchased = float.Parse(Console.ReadLine());

            //step 2: calculate taxes
            //Purchased            
            float valueNoTaxes = unitPrice * qtyPurchased;

            //GST            
            float gst = valueNoTaxes * 0.07F;

            //QST            
            float qst = (valueNoTaxes + gst) * 0.075F;

            Console.WriteLine("From Item : " + itemName);
            Console.WriteLine("---------------------- ");
            Console.WriteLine("Unit price is : " + unitPrice);
            Console.WriteLine("For " + qtyPurchased + " items, the price without Taxes is: " + valueNoTaxes);
            Console.WriteLine("And the taxes are: "); Console.WriteLine("GST(7%): " + gst); Console.WriteLine("QST(7.5%): " + qst);
            //total           
            Console.WriteLine("---------------------- ");
            Console.WriteLine("Total: CAD " + Math.Round((valueNoTaxes + gst + qst), 2));

        }
    }
}

