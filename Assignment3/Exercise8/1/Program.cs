namespace Ex1
{
    public class program
    {
        public static void Main()
        {
            int X = 2;
            int Y = 3;
            int B = X + X;
            int D = X * X;
            int E1 = X * Y;
            int E2 = Y + X;
            int F = X * Y + Y + X;

            //Letter A     Write x
            Console.WriteLine(" Line A is = " + X);

            //Letter B  Write x + x
            Console.WriteLine(" Line B is 2 + 2 = " + B);

            // Letter C Write “x =”
            Console.WriteLine(" Line C is X = " + X);

            //Letter D Write “x* x”
            Console.WriteLine(" Line D is X * X = " + D);

            //Letter E     Write “x* y”, y + x
            Console.WriteLine(" Line E is X * Y = " + E1 + " and 3 + 2 = " + E2);

            // Letter F Write x * y + y + x
            Console.WriteLine(" Line F is (2 * 3) + 3 + 2 = " + F);

            //Letter G Write “x* y + y + x”
            Console.WriteLine(" Line G is (X * Y) + Y + X = " + F);
        }
    }
}