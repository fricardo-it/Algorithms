namespace Ex12
{
    public class Program
    {
        public static void Main()
        {
            //Step 1 : get user input

            Console.WriteLine(" Enter bill value ");
            float billValue = float.Parse(Console.ReadLine());

            //Step 2 : Calculate
            float comission = 0.15F;
            float tipValue = 0;

            if (billValue >= 1)
                tipValue = billValue * comission;
            else
                tipValue = 0;

            float totalBill = tipValue + billValue;

            Console.WriteLine(" The tip is " + tipValue);
            Console.WriteLine(" The total bill + tip is " + totalBill);
        }
    }
}