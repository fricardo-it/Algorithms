//Ex5 - Volume - Retangular Prisma

namespace Ex5
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input            
            Console.WriteLine("Please enter the dimensions of prisma");
            Console.WriteLine("Lenght: ");
            float lenght = float.Parse(Console.ReadLine());
            Console.WriteLine("Width: ");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Height: ");
            float height = float.Parse(Console.ReadLine());

            //step 2: calculate
            //volume            
            float volume = lenght * width * height;

            Console.WriteLine("The volume is: " + volume);
        }
    }
}

