//Ex40

namespace Ex40
{
    public class Program
    {
        public static void Main()
        {
            //variables and constant
            const int numberInputs = 1000;
            int smallestNumber = 0;
            int biggestNumber = 0;
            Console.WriteLine("-----FOR------ \n");

            Console.WriteLine("Choose the option: \n 1) Input number by number \n 2) Input a list of number \n Option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        /*option A
                            Input number by number
                        */
                        int numberRead;

                        Console.WriteLine("Enter " + numberInputs + " : ");

                        for (int i = 1; i <= numberInputs; i++)
                        {
                            Console.WriteLine("Input " + i + " : ");
                            numberRead = int.Parse(Console.ReadLine());

                            if (i == 1) //if 1st i, the number is small and big 
                                smallestNumber = biggestNumber = numberRead;
                            else
                                if (numberRead < smallestNumber)
                                smallestNumber = numberRead;
                            else
                                    if (numberRead > biggestNumber)
                                biggestNumber = numberRead;
                        }
                        Console.WriteLine("Smallest number: " + smallestNumber);
                        Console.WriteLine("Biggest number: " + biggestNumber);

                        break;
                    }
                case 2:
                    {
                        /*option B
                            Input a list of number
                        */

                        Console.WriteLine("Enter a list of number (use 'space' between the numbers): ");
                        string line = Console.ReadLine();
                        string[] data = line.Split(' ');

                        for (int i = 0; i < numberInputs; i++)
                        {
                            if (i == 0) //if 1st i, the number is small and big 
                                smallestNumber = biggestNumber = int.Parse(data[i]);
                            else
                                if (int.Parse(data[i]) > biggestNumber)
                                biggestNumber = int.Parse(data[i]);
                            else
                                    if (int.Parse(data[i]) < smallestNumber)
                                smallestNumber = int.Parse(data[i]);

                            Console.WriteLine("Smallest number: " + smallestNumber);
                            Console.WriteLine("Biggest number: " + biggestNumber);
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Option " + option + " is not avaiable. Ending the ");
                    break;
            }

            Console.WriteLine("\n-----WHILE------ \n");

            Console.WriteLine("Choose the option: \n 1) Input number by number \n 2) Input a list of number \n Option: ");
            option = int.Parse(Console.ReadLine());
            int j;

            switch (option)
            {
                case 1:
                    {
                        /*option A
                            Input number by number
                        */
                        int numberRead;

                        Console.WriteLine("Enter " + numberInputs + " : ");
                        j = 1;
                        while (j <= numberInputs)
                        {
                            Console.WriteLine("Input " + j + " : ");
                            numberRead = int.Parse(Console.ReadLine());

                            if (j == 1) //if 1st i, the number is small and big 
                                smallestNumber = biggestNumber = numberRead;
                            else
                                if (numberRead < smallestNumber)
                                smallestNumber = numberRead;
                            else
                                    if (numberRead > biggestNumber)
                                biggestNumber = numberRead;

                            j++;
                        }
                        Console.WriteLine("Smallest number: " + smallestNumber);
                        Console.WriteLine("Biggest number: " + biggestNumber);

                        break;
                    }
                case 2:
                    {
                        /*option B
                            Input a list of number
                        */
                        Console.WriteLine("Enter a list of number (use 'space' between the numbers): ");
                        string line = Console.ReadLine();
                        string[] data = line.Split(' ');

                        j = 0;
                        while (j < numberInputs)
                        {
                            if (j == 0) //if 1st i, the number is small and big 
                                smallestNumber = biggestNumber = int.Parse(data[j]);
                            else
                                if (int.Parse(data[j]) > biggestNumber)
                                biggestNumber = int.Parse(data[j]);
                            else
                                    if (int.Parse(data[j]) < smallestNumber)
                                smallestNumber = int.Parse(data[j]);
                            j++;
                        }

                        Console.WriteLine("Smallest number: " + smallestNumber);
                        Console.WriteLine("Biggest number: " + biggestNumber);

                        break;
                    }
                default:
                    Console.WriteLine("Option " + option + " is not avaiable. Ending the ");
                    break;
            }

        }
    }
}