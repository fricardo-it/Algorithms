namespace Ex1
{
    public class Program
    {
        public static void Main()
        {
            // LIST
            List<int> mainList = new List<int>();  //main list
            string option;

            do
            {
                // MENU
                Console.Clear();   // clean the console
                Console.Write("\nChoose from menu \n");
                Console.Write("P - Print numbers\nA - Add a number\nM - Display mean of the numbers\nS - Display the smallest number\nL - Display the largest number\nQ - Quit\n");
                Console.Write("Option: ");

                option = Console.ReadLine();
                option = option.ToUpper();

                switch (option)
                {
                    case "P":
                        if (mainList.Count == 0) { 
                            Console.WriteLine("[] - the list is empty. Press ENTER to continue");
                            Console.ReadKey();
                        }
                        else
                            printer(mainList);
                        break;
                    case "A":
                        {
                            Console.Write("Enter the number to add: ");
                            int addNumber = int.Parse(Console.ReadLine());
                            mainList = add(mainList,addNumber);
                            break;
                        }
                    case "M":

                        if (mainList.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data. Press ENTER to continue");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("(");
                            float average = mean(mainList);
                            Console.WriteLine("Average: " + average + ". Press ENTER to continue.");
                            Console.ReadKey();
                        }
                        break;
                    case "S":
                        if (mainList.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty. Press ENTER to continue");
                            Console.ReadKey();
                        }
                        else
                        {
                            int small = smallest(mainList);
                            Console.WriteLine("Smallest: " + small + ". Press ENTER to continue.");
                            Console.ReadKey();
                        }
                        break;
                    case "L":
                        if (mainList.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty. Press ENTER to continue");
                            Console.ReadKey();
                        }
                        else
                        {
                            int large = largest(mainList);
                            Console.WriteLine("Largest: " + large + ". Press ENTER to continue.");
                            Console.ReadKey();
                        }
                        break;
                    case "Q":
                        Console.WriteLine("Goodbye. Press ENTER to finish/closed.");
                        Console.ReadKey();
                        break;
                    default:
                        {
                            Console.WriteLine("Unknown selection. Press ENTER and please try again");
                            Console.ReadKey();
                            break;
                        }
                }
            } while (option != "Q");
        }

        // PRINTER
        public static void printer(List<int> lst)
        {
            List<int> list = new List<int>();

            list = lst;

            Console.Write("[ ");

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.Write("]");
            Console.Write(", press ENTER to continue.");
            Console.ReadKey();

            return;
        }

        // ADD
        public static List<int> add(List<int> lst, int number)
        {
            List<int> list = new List<int>();
            list = lst;
            list.Add(number);
            Console.WriteLine(number + " added, press ENTER to continue.");
            Console.ReadKey();

            return list;
        }

        // MEAN/AVERAGE
        public static float mean(List<int> lst)
        {
            float average = 0;
            List<int> list = new List<int>();
            list = lst;

            for (int i = 0; i < list.Count; i++)
            {
                average = average + list[i];
                if (i<(list.Count-1))
                    Console.Write(list[i] + " + ");
                else
                    Console.Write(list[i] + ") / " + list.Count + " = ");
            }
            average = average / list.Count;

            return average;
        }

        // SMALLEST
        public static int smallest(List<int> lst)
        {
            int small;
            List<int> list = new List<int>();

            list = lst;
            small = list.Min();

            return small;
        }

        // LARGEST
        public static int largest(List<int> lst)
        {
            int large;
            List<int> list = new List<int>();

            list = lst;
            large = list.Max();

            return large;
        }
    }
}