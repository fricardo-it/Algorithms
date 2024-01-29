namespace Ex34
{
    public class program
    {
        public static void Main()
        {
            Console.WriteLine(" Enter a year ");
            int year = int.Parse(Console.ReadLine());
            {
                // If a year is multiple of 400,
                // then it is a leap year
                if (year % 400 == 0)
                    Console.WriteLine(year + " is a Leap Year ");
                else
                if (year % 100 == 0)
                    Console.WriteLine(year + " is not a Leap year ");

                // Else If a year is multiple of 4,
                // then it is a leap year

                if (year % 4 == 0)
                    Console.WriteLine(year + " is a Leap Year ");
                else
                    Console.WriteLine(year + " is not a Leap Year");
            }
        }
    }
}