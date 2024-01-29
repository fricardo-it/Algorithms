namespace Ex7
{
    public class Program
    {
        public static void Main()
        {
            float input = 0;
            float salary = 0;
            ;



            while (input != -1)
            {



                Console.WriteLine("Enter the representative’s sales in dollars (-1 to terminate): ");
                input = float.Parse(Console.ReadLine());
                if (input == -1.0)
                {
                    Console.WriteLine("End program");
                    break;
                }
                salary = ((input * 9) / 100) + 200;
                Console.WriteLine("The representative’s salary is $" + salary);



            } // end while





        }
    }
}