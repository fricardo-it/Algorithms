//Ex39 - average Grades
namespace Ex39
{
    public class Program
    {
        public static void Main()
        {
            //variables and constant
            const int numberInputs = 1000;
            float average = 0.00F;
            int i = 0;

            Console.WriteLine("-----FOR------ \n");

            //  Input number by number

            Console.WriteLine("Enter with " + numberInputs + " numbers (one line, number separated by 'space'): ");
            string line = Console.ReadLine();
            string[] data = line.Split(' ');

            for (i = 0; i < numberInputs; i++)
            {
                if (i == 0)
                    average = float.Parse(data[i]);
                else
                    average = average + float.Parse(data[i]);
            }
            average = average / numberInputs;
            Console.WriteLine("Average is: " + average);

            //-------------------------------------------------

            Console.WriteLine("\n-----WHILE------ \n");

            Console.WriteLine("Enter with " + numberInputs + " numbers (one line, number separated by 'space'): ");
            string line2 = Console.ReadLine();
            string[] data2 = line.Split(' ');

            i = 0;
            while (i < numberInputs)
            {
                if (i == 0)
                    average = float.Parse(data[i]);
                else
                    average = average + float.Parse(data[i]);
                i++;
            }
            average = average / numberInputs;
            Console.WriteLine("Average is: " + average);
        }
    }
}
