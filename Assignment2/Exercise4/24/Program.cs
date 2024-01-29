namespace Ex24
{
    public class Program
    {
        public static void Main()
        {
            //two coins game
            Console.WriteLine("Enter with the result of the first coin (head or tail)");
            string coin1 = Console.ReadLine();

            Console.WriteLine();//line space

            Console.WriteLine("Enter with the result of the second coin (head or tail)");
            string coin2 = Console.ReadLine();

            Console.WriteLine();//line space

            if (((coin1 == "head") || (coin1 == "tail")) && ((coin2 == "head") || (coin2 == "tail")))
            {
                if (coin1 == "head" && coin2 == "head")
                    Console.WriteLine("the player wins $10!");
                else
                    if (coin1 == "head" && coin2 == "tail")
                        Console.WriteLine("the player wins $5!");
                    else
                        if (coin1 == "tail")
                            Console.WriteLine("The player lose! Try another time");
            }
            else
                Console.WriteLine("incorrect input! restart the game and enter with head or tail");
        }
    }
}