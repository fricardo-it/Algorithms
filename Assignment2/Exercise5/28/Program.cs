//28 –	In a competition where scores are given by 6 judges, a competitor’s final score is calculated as follows:
//- first the highest and the lowest of the initial scores are eliminated,
// and then one takes the average of the other 4 scores.
// You are asked to create a program that reads 6 scores and determines the final score according to this method.


namespace Ex28
{
    public class Program
    {
        public static void Main()
        {
            //float judge1, judge2, judge3, judge4, judge5, judge6;
            float average=0;

            int[] scores = new int[6];

            Console.WriteLine("Enter the scores: \n");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Judge"+(i+1) +" :");
                scores[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(scores);

            Console.WriteLine("\nThe valid scores are: ");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(scores[i]);
                average = average + scores[i];
            }
            average = average / 4;
            Console.WriteLine("\nThe final score is: "+ average);

            Console.WriteLine("\nThe discard scores are: \n Lowest: "+ scores[0] +" \n Highest: "+ scores[5]);
        }

    }
}