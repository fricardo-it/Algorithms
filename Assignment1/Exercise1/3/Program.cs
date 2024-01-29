namespace Ex3
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input
            Console.WriteLine("Please enter the employee name: ");
            //item name
            string employeeName = Console.ReadLine();

            Console.WriteLine("Please enter the salary (by hour): ");
            //salary hour
            float salaryHour = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of hours worked (in the week): ");
            //hours worked
            float hoursWorked = float.Parse(Console.ReadLine());

            //step 2: calculate
            //salary Week
            float salaryWeek = salaryHour * hoursWorked;

            Console.WriteLine("The Employee: " + employeeName + " worked " + hoursWorked + " hours this week.");
            Console.WriteLine("His salary by hour is:  " + salaryHour);
            Console.WriteLine("and his salary this week is: " + salaryWeek);
        }
    }
}