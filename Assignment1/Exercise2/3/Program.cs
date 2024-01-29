namespace Ex3
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input
            Console.WriteLine("Please enter with the atmospheric pressure in (kPa): ");
            double pressKpa = double.Parse(Console.ReadLine());
            Console.WriteLine("Atmospheric Pressure: " + pressKpa + " kPa");
            //calculation of the atmospheric pressure in atm            
            double press_atm = pressKpa / 101.325F;
            //Round the number to 3 decimals            
            press_atm = Math.Round(press_atm,3);
            Console.WriteLine("the atmospheric pressure in (atm) is: " + press_atm + " atm.");
        }
    }
}

