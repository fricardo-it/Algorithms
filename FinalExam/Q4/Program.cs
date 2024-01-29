using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Q4
{
    public class Program
    {
        public static int add(int n)
        {
            //Console.WriteLine("Enter the number to sum: ");
            // int aux = int.ParseConsole.ReadLine();

            int aux = 1; 
            return (n + aux);
        }
        public static int mult(int n)
        {
            //Console.WriteLine("Enter the number to mult: ");
            // int aux = int.ParseConsole.ReadLine();

            int aux = 2;
            return (n * aux);
        }
        public static int sub(int n)
        {
            //Console.WriteLine("Enter the number to sub: ");
            // int aux = int.ParseConsole.ReadLine();

            int aux = 4;
            return (n - aux);
        }

        public static void Main()
        {
            int option = 0;
            int number = 0;

            //Console.WriteLine("Enter the value of the integer at the very beginning is : ");
            //number = int.Parse(Console.ReadLine());

            Console.WriteLine("The value of the integer at the very beginning is : " + number);
            Console.WriteLine("--------------------------------------------------------------");

            do
            {
                Console.WriteLine("\nChoose One of the following operations : ");
                Console.Write("\n1.Addition\n2.Multiplication\n3.Substraction\n4.Exit");
                Console.Write("\nOption: ");
                option = int.Parse(Console.ReadLine());

                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("\nYou Chose Option "+ option);
                Console.WriteLine("------------------------------------------------------------");

                switch (option)
                {
                    case 1:
                        {
                            number = add(number);
                            break;
                        }
                    case 2:
                        {
                            number = mult(number);
                            break;
                        }
                    case 3:
                        {
                            number = sub(number);
                            break;
                        }
                    case 4:
                        { 
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Unknown selection. Press any key and try again");
                            //Console.ReadKey();
                            break;
                        }
                }

                Console.WriteLine("\nThe Value of the integer is : " + number);

            } while (option != 4);
        }
    }
}