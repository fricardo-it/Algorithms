namespace Ex25
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(" enter the first triplets day of birth ");
            float firstDay = float.Parse(Console.ReadLine());

            Console.WriteLine(" enter the first triplets mounth of birth ");
            Double firstMonth = Double.Parse(Console.ReadLine());

            Console.WriteLine(" enter the first triplets year of birth ");
            float firstYear = float.Parse(Console.ReadLine());

            Console.WriteLine(" enter the second triplets day of birth ");
            float secondDay = float.Parse(Console.ReadLine());

            Console.WriteLine(" enter the second triplets month of birth ");
            float secondMonth = float.Parse(Console.ReadLine());

            Console.WriteLine(" enter the second triplets year of birth ");
            float secondYear = float.Parse(Console.ReadLine());

            float firstYearInDays = firstYear * 365;
            Double firstMonthInDays = firstMonth * 30.4167;
            Double firstT = firstYearInDays + firstMonthInDays + firstDay;

            float secondYearInDays = secondYear * 365;
            Double secondMonthInDays = secondMonth * 30.4167;
            Double secondT = secondYearInDays + secondMonthInDays + secondDay;

            if (secondT < firstT)
            {
                Console.WriteLine(" the second triplets came first ");
            }
            else
            {
                Console.WriteLine(" the first triplets came first ");
            }

        }
    }
}

