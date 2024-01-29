namespace Ex8
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("insert the number");
            int num = int.Parse(Console.ReadLine());
            int reverse = Inverse(num);
            Console.WriteLine("The number in the reverse order is " + reverse);

            if (num != reverse)
                Console.WriteLine("The number " + num + " is not a palindrome");
            else
                Console.WriteLine("The number " + num + " is a palindrome");
        }

        public static int Inverse(int num)
        {
            int rev_num = 0;
            while (num > 0)
            {
                rev_num = rev_num * 10 + num % 10;
                num = num / 10;
            }
            return rev_num;
        }
    }
}