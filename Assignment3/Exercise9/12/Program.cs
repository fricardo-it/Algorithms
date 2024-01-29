namespace Ex12
{
    public class Program
    {
        public static void Main()
        {
            //getting the user input
            Console.WriteLine("Insert the data (integer with 4 digits):");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The number encrypted is:");
            int n_encr = Encrypt(number);
            Console.WriteLine(n_encr);
            Console.WriteLine("After the function to decrypt the number the result is:");
            int n_decr = Dencrypt(n_encr);
            Console.WriteLine(n_decr);
        }

        //function to do the encryption
        public static int Encrypt(int data1)
        {
            //the digits separately
            int a = data1 / 1000;
            int b = (data1 % 1000) / 100;
            int c = (data1 % 100) / 10;
            int d = data1 % 10;

            //creating the encrypted array
            //step1
            a = (a + 7) % 10;
            b = (b + 7) % 10;
            c = (c + 7) % 10;
            d = (d + 7) % 10;
            //step2, replacing a with c and b with d
            int data2 = (c * 1000) + (d * 100) + (a * 10) + (b * 1);
            return data2;
        }

        //function to do the dencryption
        public static int Dencrypt(int data2)
        {
            //the digits separately
            int a = data2 / 1000;
            int b = (data2 % 1000) / 100;
            int c = (data2 % 100) / 10;
            int d = data2 % 10;

            //creating the dencrypted array
            //step1
            a = (a + 3) % 10;
            b = (b + 3) % 10;
            c = (c + 3) % 10;
            d = (d + 3) % 10;
            //step2, replacing a with c and b with d
            int data1 = (c * 1000) + (d * 100) + (a * 10) + (b * 1);
            return data1;
        }
    }
}