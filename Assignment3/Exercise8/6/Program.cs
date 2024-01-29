namespace Ex6
{
    public class Program
    {
        public static void Main()
        {
            double totalOfLiters = 0.0;
            double totalOfKm = 1.0; // must be != 0
            double average_t = 0.0;



            double used_litres = 0.0;
            double number_of_kilometers = 1.0;// must be != 0
            double average = 0.0;
            while (used_litres != -1)
            {//1est while



                Console.WriteLine("Enter the number of litres used (-1 to terminate): ");
                used_litres = Convert.ToDouble(Console.ReadLine());
                if (used_litres == -1.0)
                {
                    average_t = totalOfLiters / totalOfKm * 100;
                    string averageT_ch = average.ToString("0.0");
                    Console.WriteLine("The average of gas consumption is %" + averageT_ch);
                    break;
                }
                Console.WriteLine("Enter the number of kilometers traveled: ");
                number_of_kilometers = Convert.ToDouble(Console.ReadLine());



                average = (used_litres / number_of_kilometers) * 100;
                string average_ch = average.ToString("0.0");
                Console.WriteLine("The rate of gas consumption in litres per 100 kilometers for this gas refill is %" + average_ch);



                totalOfLiters = +used_litres;
                totalOfKm = +number_of_kilometers;



            }// End 1est while    



        }



    }
}