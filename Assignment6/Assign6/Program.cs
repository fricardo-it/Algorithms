using System;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

namespace Assignment6
{
    public class Program
    {
        public static void Main()
        {
            //List<char> shots = new List<char> { 'a', 'b', 'c', 'a' };
            Console.WriteLine("Type the list of characters representing the sequence of shots");
            List<char> shots = new List<char>(Console.ReadLine());
            List<char> shotsNoSpaces = new List<char>(shots);
            //char[] separators = { ' ', ',', ';' };

            for (int i = 0; i < shotsNoSpaces.Count; i++)
            {
                //shotsNoSpaces = shotsNoSpaces.TrimEnd(separators);
                shotsNoSpaces.Remove(' ');
                shotsNoSpaces.Remove(',');
                shotsNoSpaces.Remove(';');
            }

            shots = shotsNoSpaces;

            Console.WriteLine();
            Console.WriteLine("The sequence of shots are:");
            for (int i = 0; i < shots.Count; i++)
            {
                Console.Write("{0} ", shots[i]);
            }

            Console.WriteLine();

            Scenes(shots);
        }   

        public static List<int> Scenes(List<char> input)
        {
            int i;
            Dictionary<char, int> hash = new Dictionary<char, int>();
            //creating a list of max position where the letter is repeated
            for (i = 0; i < input.Count; i++)
            {
                hash[input[i]] = i;
            }
            //creating the list of scenes
            List<int> scene = new List<int>();
            int maxi = 0;
            int prev = -1;

            for (i = 0; i < input.Count; i++)
            {
                maxi = Math.Max(maxi, hash[input[i]]);
                if (maxi == i)
                {
                    scene.Add(maxi - prev);
                    prev = maxi;
                }
            }

            Console.Write("The list of the lenght of each scene is: ");
            for (i = 0; i < scene.Count; i++)
            {

                Console.Write("{0} ", scene[i]);
            }

            return scene;
        }
    }



}