namespace Q2
{
    public class Program
    {
        public static void Main()
        {
            const int max = 10;
            int[] arr = new int[max];
            int aux;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter for tab[" + i + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nArray before sorting ascendent: [ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("]\n");

            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }

            Console.Write("Array after sorting ascendent: [ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("]");
        }
    }
}