namespace EX5
{
    public class program
    {
        public static void Main()
        {
            double pi = 3.14159;
            Console.WriteLine("Entere the radius of the circle ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine(" The diameter of the circle is: " + (radius * 2));
            Console.WriteLine(" The circunferece is : " + (2 * pi * radius));
            Console.WriteLine(" The area is: " + (pi * radius * radius));

        }
    }
}