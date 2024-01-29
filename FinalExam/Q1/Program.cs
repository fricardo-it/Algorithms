namespace Q1
{
    public class Program                                        
    {
        public static void Main()
        {
            Console.Write("Enter an integer x for sqrt((x-1)*(2-x)): ");
            int valueX = int.Parse(Console.ReadLine());

            bool ok;
            double ans;

            int y = (valueX - 1) * (2 - valueX);

            if (y >= 0)
            {
                ok = true;
                ans = f(y, ok);
                Console.Write("\nThe square root works since (" + valueX + "-1)*(2-" + valueX + "): " + ans);
            }
            else
            {
                ok = false;
                ans = f(y, ok);
                Console.Write("\nSorry, the square root does not work since (" + valueX + "-1)*(2-" + valueX + "): " + y);
            }

            Console.Write("\n\tBye, Bye");
            Console.ReadKey();
        }

        public static double f(double x, bool ok)
        {
            double rslt = 0;

            if (ok == true)
            {
                rslt = Math.Sqrt(x);
            }
            else if (ok == false)
            {
                rslt = x;
            }
            return rslt;
        }
    }
}