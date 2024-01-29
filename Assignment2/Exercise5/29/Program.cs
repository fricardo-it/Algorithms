//29 –	Write the algorithm of a program that reads a date (3 integers: day, month, year) and that displays the date of the next day (in numbers).
//Suppose that the year is not a leap year.

namespace Ex29
{
    public class Program
    {
        public static void Main()
        {
            int day = 0, month = 0, year = 0;
            int newDay = 0, newMonth = 0, newYear = 0;


            Console.WriteLine("Enter the date: \n");
            do
            {
                Console.WriteLine("Enter a valid day (1-31): \n");
                day = int.Parse(Console.ReadLine());
            } while ((day < 1) && (day > 31));

            do
            {
                Console.WriteLine("Enter a valid month (1-12): \n");
                month = int.Parse(Console.ReadLine());
            } while ((month < 1) && (month > 12));

            do
            {
                Console.WriteLine("Enter a valid year (1900-2022): \n");
                year = int.Parse(Console.ReadLine());
            } while ((year < 1900) && (year > 2022));

            //day after the day

            if ((month == 2) && (day == 28))
            {
                newDay = 1;
                newMonth = 3;
                newYear = year;
            }
            else
                if (day < 31)
                {
                    newDay = day + 1;
                    newMonth = month;
                    newYear = year;
                }
                else
                {
                    newDay = 1;
                    if (month < 12)
                        newMonth = month + 1;
                    else
                    {
                        newMonth = 1;
                        newYear = year + 1;
                    //Console.WriteLine("\n Happy new Year!! Welcome to the future... 2023 is now! \n");
                    }
                }   
                Console.WriteLine("tomorrow the date is (dd-mm-yyyy): " + newDay + "-" + newMonth + "-" + newYear);
        }
    }
}