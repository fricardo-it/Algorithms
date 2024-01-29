namespace Ex25
{
    public class Program
    {
        public static void Main()
        {
            //step 1 - getting the user input
            Console.WriteLine("Enter with three different numbers:");
            Console.WriteLine();
            Console.WriteLine("Insert the first value:");
            int value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert the second value:");
            int value2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert the third value:");
            int value3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //step 2 - comparison
            if ((value1 != value2) && (value1 != value3) && (value2 != value3))
            {
                if (value1 > value2 && value1 > value3)
                    Console.WriteLine("The biggest value is " + value1);
                if (value2 > value3 && value3 > value1)
                    Console.WriteLine("The biggest value is " + value2);
                if (value3 > value2 && value3 > value1)
                    Console.WriteLine("The biggest value is " + value3);
            }

            if ((value1 == value2) || (value1 == value3) || (value2 == value3))
            {
                if (value1 == value2 && value1 > value3)
                    Console.WriteLine("The biggest value is " + value1);
                if (value1 == value2 && value1 < value3)
                    Console.WriteLine("The biggest value is " + value3);

                if (value1 == value3 && value1 > value2)
                    Console.WriteLine("The biggest value are " + value1);
                if (value1 == value2 && value1 < value2)
                    Console.WriteLine("The biggest value is " + value2);

                if (value2 == value3 && value2 > value1)
                    Console.WriteLine("The biggest value are " + value2);
                if (value2 == value3 && value2 < value1)
                    Console.WriteLine("The biggest value are " + value1);
            }

            if ((value1 == value2) && (value1 == value3) && (value2 == value3))
                Console.WriteLine("Your inputs were all the same, enter with different values for comparison");

        }
    }
}