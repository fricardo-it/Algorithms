namespace ex11
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter two number the see which one is greater ");
            Console.WriteLine("1st: ");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("2nd: ");
            float secondNumber = float.Parse(Console.ReadLine());
            if (firstNumber == secondNumber)
                Console.WriteLine(firstNumber + " is equal than " + secondNumber);
            else
            if (firstNumber > secondNumber)
                Console.WriteLine(firstNumber + " is greater than " + secondNumber);
            else
                Console.WriteLine(secondNumber + " is greater than " + firstNumber);
        }
    }
}