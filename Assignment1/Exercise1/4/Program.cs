namespace Ex4
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input
            Console.WriteLine("Please enter the temperature (F): ");
            //temperature
            float temperatureF = float.Parse(Console.ReadLine());

            //step 2: calculate
            //Celsius
            float temperatureC = ((temperatureF - 32) / 9) * 5;

            Console.WriteLine("The temperature Fahrenheit: " + Math.Round(temperatureF, 1));
            Console.WriteLine("The temperature Celsius: " + Math.Round(temperatureC, 1));
        }
    }
}