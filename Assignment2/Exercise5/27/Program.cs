namespace Ex27
{
    public class Program
    {
        public static void Main()
        {
            //step 1 - getting the user input
            Console.WriteLine("Please enter with the old Premium value:");
            double Old_prem = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter with the number of accidents of the client:");
            int accidents = int.Parse(Console.ReadLine());
            double New_prem;
            //step2 - calculating the increase
            if (accidents == 0)
            {
                New_prem = Old_prem * 1.02;
                New_prem = Math.Round(New_prem, 2);
                Console.WriteLine("The new premium must be: CAD " + New_prem);
            }
            else if ((accidents == 1) || (accidents == 2))
            {
                New_prem = Old_prem * 1.05;
                New_prem = Math.Round(New_prem, 2);
                Console.WriteLine("The new premium must be: CAD " + New_prem);
            }
            else if (accidents == 3)
            {
                New_prem = Old_prem * 1.10;
                New_prem = Math.Round(New_prem, 2);
                Console.WriteLine("The new premium must be: CAD " + New_prem);
            }
            else if (accidents >= 4)
            {
                New_prem = Old_prem * 1.30;
                New_prem = Math.Round(New_prem, 2);
                Console.WriteLine("The new premium must be: CAD " + New_prem);
            }
        }
    }
}