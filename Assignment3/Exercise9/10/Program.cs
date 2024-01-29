namespace Ex10
{
    public class Program
    {
        public static void Main()
        {
            float cube;
            float square;
            for (int i = 1; i < 11; i++)
            {
                cube = i * i * i;
                square = i * i;
                Console.WriteLine("number: " + i+ " -->  cube: " + cube + " | square:  " + square);
            }
        }
    }
}