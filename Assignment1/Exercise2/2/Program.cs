namespace Ex2
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input
            Console.WriteLine("Please inform how many floors there are in the building, except the ground floor:");
            int numFloors = int.Parse(Console.ReadLine());

            //calculating the height of the building
            int totalHeight = 6 + (numFloors * 4);
            Console.WriteLine("The total height of the building is: " + totalHeight + " m.");
        }
    }
}