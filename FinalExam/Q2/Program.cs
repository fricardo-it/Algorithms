namespace Q2
{
    public class Program
    {
        public static List<int> toFill(int[] a, int n) {
            int number;
            int[] arr = new int[n];

            arr = a;

            List<int> lst = new List<int>();

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                number = rand.Next(0, 10);
                arr[i] = number;
                lst.Add(arr[i]);
            }

            return lst;
        }

        public static void Main()
        {
            Console.Write("Enter the number of elements in the array: ");
            int max = int.Parse(Console.ReadLine());
            //int max = 10;

            int[] arr = new int[max];
            List<int> lst = new List<int>();

            lst = toFill(arr, max);

            Console.Write("The array elements are: ");
            Console.Write("\n[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("]");

            Console.Write("\n\nThe vector/list elements are: ");
            Console.Write("\n[ ");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i] + " ");
            }
            Console.Write("]");

            Console.Write("\n\tPress any key to continue...");
            Console.ReadKey();
        }
    }
}