// Ex.6 - Vehicles Sales
//----

namespace Ex6
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input            
            Console.WriteLine("Please enter the name of salesperson: ");
            string salesperson = Console.ReadLine();
            Console.WriteLine("Please enter the number of vehicles sale: ");
            int numberVehiclesSale = int.Parse(Console.ReadLine());

            //step 2: calculate
            //salary with bonus and comission

            // base salary            
            int baseSalary = 400;
            // comission            
            int comission = 200;
            // bonus            
            float bonusIndex = 0.05F;
            // bonus per sale             
            float totalSale = comission * numberVehiclesSale;
            // bonus total sale            
            float bonusSale = totalSale * bonusIndex;
            // total Salary            
            float totalSalary = baseSalary + totalSale + bonusSale;

            Console.WriteLine("The total Salary is: " + totalSalary);
            Console.WriteLine("(Base Salary: " + baseSalary + " + total Commission: " + totalSale + " (" + comission + " * " + numberVehiclesSale + ") + Bonus: " + bonusSale + ")");
        }
    }
}

