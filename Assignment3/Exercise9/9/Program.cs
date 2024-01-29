namespace Ex9
{
    public class Program
    {
        public static void Main()
        {
            //getting the user input
            Console.WriteLine("Please, inform the binary number (number in base 2): ");
            int bin_number = int.Parse(Console.ReadLine());
            int decimal_value = 0;
            //expoents starts at 1, considering 2^0=1
            int exp = 1;

            while (bin_number > 0)
            {
                int modulus = (bin_number % 10);
                bin_number = (bin_number / 10);
                decimal_value += modulus * exp;
                exp = exp * 2;
            }
            Console.WriteLine("The equivalent decimal value is: " + decimal_value);
        }
    }
}