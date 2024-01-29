//void 36 –	Create four algorithms, each displaying the corresponding one of the following sequences:
//a)		5   10  15  20  25  30  35  40
//b)		3   5   7   9   11  13  15
//c)		80  70  60  50  40  30  20
//d)		1   2   6   24  120 720

namespace Ex36
{
    public class Program
    {
        public static void Main()
        {
            int i = 0;
            int j = 0;

            Console.WriteLine("-----FOR------ \n");

            Console.Write("\n Algol a) ");
            j = 5;
            for (i = 0; i <= 7; i++)
            {
                Console.Write(j + " ");
                j = j + 5;
            }

            Console.Write("\n Algol b) ");
            j = 3;
            for (i = 0; i <= 6; i++)
            {
                Console.Write(j + " ");
                j = j + 2;
            }

            Console.Write("\n Algol c) ");
            j = 80;
            for (i = 0; i <= 6; i++)
            {
                Console.Write(j + " ");
                j = j - 10;
            }

            Console.Write("\n Algol d) ");
            j = 1;
            for (i = 1; i < 7; i++)
            {
                j = j * i;
                Console.Write(j + " ");

            }

            //-------------------------------------------------


            Console.WriteLine("\n\n-----WHILE------ \n");

            Console.Write("\n Algol a) ");
            j = 5;
            i = 0;
            while (i <= 7)
            {
                Console.Write(j + " ");
                j = j + 5;
                i++;
            }

            Console.Write("\n Algol b) ");
            j = 3;
            i = 0;
            while (i <= 6)
            {
                Console.Write(j + " ");
                j = j + 2;
                i++;
            }

            Console.Write("\n Algol c) ");
            j = 80;
            i = 0;
            while (i <= 6)
            {
                Console.Write(j + " ");
                j = j - 10;
                i++;
            }

            Console.Write("\n Algol d) ");
            j = 1;
            i = 1;
            while (i < 7)
            {
                j = j * i;
                Console.Write(j + " ");
                i++;
            }
        }
    }
}