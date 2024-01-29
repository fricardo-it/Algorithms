//Input: the input to the function/method consists of a list of characters representing the sequence of shots.
//Output: Return a list of integers representing the length of each scene, in the order in which it appears in the given sequence of shots.

//example 1:  inputList = [a, b, a, b, c, b, a, c, a, d, e, f, e, g, d, e, h, i, j, h, k, l, i, j]
//            output: [9,7,8]

//example 2:  inputList = [a, b, c]
//            output: [1,1,1]

//example 3:  inputList =[a, b, c, a]
//            output: [4]

//Example 4:  inputList = [a, b, c, d, a, e, f, g, h, i, j, e]
//            output: [5 7]

//Example 5:  inputList = [z, w, c, b, z, c, h, f, i, h, i]
//            output: [6 5]

namespace Assign6
{
    public class Program
    {
        // PRINTER
        public static void printer(List<string> lst)
        {
            List<string> list = new List<string>();

            list = lst;

            Console.Write("[ ");

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.Write("]");
            Console.Write(", press ENTER to continue.");
            Console.ReadKey();

            return;
        }

        // ADD
        public static List<string> add(List<string> lst, string elmnt)
        {
            List<string> list = new List<string>();
            list = lst;
            list.Add(elmnt);
            Console.WriteLine(elmnt + " added, press ENTER to continue.");
            Console.ReadKey();

            return list;
        }
        public static void Main2()
        {
            // LIST
            List<string> shotList = new List<string>();       //shot-characthers list
            List<int> sceneLength = new List<int>();    //scene list

            //char lastElement = ' ';
            string element = "";
            int i = 0;

            int asciiCode = 97;             //letter 'a' in ascii
            int numElements = 26;           //num of letters
            char[] refElement = new char[numElements];

            Console.Write("[ ");
            for (int j = 0; j < numElements; j++)
            {
                refElement[j] = Convert.ToChar(asciiCode + j);
                Console.Write(refElement[j] + " ");
            }
            Console.Write("]");

            Console.Write("\nEnter the sequence of shots: \t");
            element = Console.ReadLine();

            shotList = add(shotList, element);


            shotList.Add(element);

            Console.Write("\n " + shotList[i]);

            //Console.ReadKey();

            /*

            do
            {
                // MENU
                Console.Clear();   // clean the console
                Console.Write("\nEntry the list of shots (use space between elements and ']' to finish ): Ex.[a b c]");
                Console.Write("\nList: \t");
                elements = Console.ReadLine();



                
                switch (option)
                {

                    case "P":
                        if (mainList.Count == 0)
                        {
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
                            mainList = add(mainList, addNumber);
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
                Console.Write(list[i] + " ");
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
                if (i < (list.Count - 1))
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
            */
        }
    }
}