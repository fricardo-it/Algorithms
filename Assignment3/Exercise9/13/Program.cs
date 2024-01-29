namespace Ex13
{
    public class Program
    {
        public static void Main()
        {
            // getting the user input
            Console.WriteLine("Enter with a positive number: ");
            int Num = int.Parse(Console.ReadLine());
            // garantee that the number is > 0
            if (Num < 0)
                Console.WriteLine("You entered with a negative number, try again.");
            else
            {
                if (Num == 0)
                    Console.WriteLine("The 0! = 1");
                else
                {
                    int i = 0;
                    int factorial = 1;
                    for (i = Num; i >= 1; --i)
                        factorial *= i;
                    Console.WriteLine("The " + Num + "! = " + factorial);
                }
            }
        }
    }
}