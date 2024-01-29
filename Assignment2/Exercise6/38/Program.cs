namespace Ex38
{
    public class Program
    {
        public static void Main()
        {
            int tempC = 0;
            int tempF = 0;

            Console.WriteLine("----FOR----");

            for (tempC = -45; tempC <= 40; tempC = tempC + 5)
            {
                tempF = ((9 / 5) * tempC) + 32;

                Console.WriteLine("in Fahrenheit: " + tempF + " | in Celsius: " + tempC);
            }
            // --------------------

            Console.WriteLine("----WHILE----");

            tempC = -45;
            while (tempC <= 40)
            {
                tempF = ((9 / 5) * tempC) + 32;
                Console.WriteLine("in Fahrenheit: " + tempF + " | in Celsius: " + tempC);
                tempC = tempC + 5;
            }

        }
    }
}