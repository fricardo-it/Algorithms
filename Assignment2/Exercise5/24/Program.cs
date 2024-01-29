namespace Ex24
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(" enter you grade in percentage ");
            float grade = float.Parse(Console.ReadLine());
            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine(" you got an A ");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine(" you got an B ");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine(" you got an C ");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine(" you got an D ");
            }
            else if (grade <= 60)
            {
                Console.WriteLine(" you got an F ");
            }
        }
    }
}