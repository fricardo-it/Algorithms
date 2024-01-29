namespace Ex26
{
    public class Program
    {
        public static void Main()
        {
            //getting the user input
            Console.WriteLine("Enter with the lenghts of the triangule sides");
            Console.WriteLine("First side:");
            float First_side = float.Parse(Console.ReadLine());
            Console.WriteLine("Second side:");
            float Second_side = float.Parse(Console.ReadLine());
            Console.WriteLine("Third side:");
            float Third_side = float.Parse(Console.ReadLine());
            Console.WriteLine();
            //Comparisons
            if ((First_side != Second_side) && (First_side != Third_side) && (Second_side != Third_side))
                Console.WriteLine("It is a scalene triangle.");
            else if (((First_side == Second_side) && (First_side != Third_side)) || ((First_side == Third_side) && (First_side != Second_side)) || ((Second_side == Third_side) && (First_side != Second_side)))
                Console.WriteLine("It is a isosceles triangle.");
            else if ((First_side == Second_side) && (First_side == Third_side))
                Console.WriteLine("It is an equilateral triangule.");

        }
    }
}