namespace Ex27
{
    public class Program
    {
        public static void Main()
        {
            //inputs
            double taxrate1 = 0.1;
            double marrytax1 = 0.002;
            double childtax1 = 0.0005;
            double newly1 = 0.008;

            double taxrate2 = 0.2;
            double marrytax2 = 0.004;
            double childtax2 = 0.001;
            double newly2 = 0.016;

            double taxrate3 = 0.3;
            double marrytax3 = 0.006;
            double childtax3 = 0.0015;
            double newly3 = 0.024;

            double taxrate4 = 0.4;
            double marrytax4 = 0.008;
            double childtax4 = 0.002;
            double newly4 = 0.032;

            // Step 1 - Getting user input
            Console.WriteLine("Please inform your salary ");
            float salary = float.Parse(Console.ReadLine());

            Console.WriteLine("You are married? Please press 1 for yes and 2 for No ");
            float Marry = float.Parse(Console.ReadLine());

            Console.WriteLine("How many childs? ");
            float child = float.Parse(Console.ReadLine());

            Console.WriteLine("Are you newly arrived in the province? Please press 1 for yes and 2 for No ");
            float arrive = float.Parse(Console.ReadLine());

            //Tax rate 1
            {
                if ((salary >= 0) && (salary <= 18000) && (Marry == 1) && (arrive == 1))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate1 - (child * childtax1) - marrytax1 - newly1));
                else
                if ((salary >= 0) && (salary <= 18000) && (Marry == 2) && (arrive == 1))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate1 - (child * childtax1) - newly1));
                else
                    if ((salary >= 0) && (salary <= 18000) && (Marry == 2) && (arrive == 2))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate1 - (child * childtax1)));
                else
                if ((salary >= 0) && (salary <= 18000) && (Marry == 1) && (arrive == 2))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate1 - (child * childtax1) - newly1));
            }

            //Tax rate 2
            {
                if ((salary >= 18000.01) && (salary <= 32000) && (Marry == 1) && (arrive == 1))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate2 - (child * childtax2) - marrytax2 - newly2));
                else
                if ((salary >= 18000.01) && (salary <= 32000) && (Marry == 2) && (arrive == 1))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate2 - (child * childtax2) - newly2));
                else
                    if ((salary >= 18000.01) && (salary <= 32000) && (Marry == 2) && (arrive == 2))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate2 - (child * childtax2)));
                else
                if ((salary >= 18000.01) && (salary <= 32000) && (Marry == 1) && (arrive == 2))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate2 - (child * childtax2) - newly2));
            }

            //Tax Rate 3
            {
                if ((salary >= 32000.01) && (salary <= 60000) && (Marry == 1) && (arrive == 1))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate3 - (child * childtax3) - marrytax3 - newly3));
                else
                if ((salary >= 32000.01) && (salary <= 60000) && (Marry == 1) && (arrive == 1))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate3 - (child * childtax3) - newly3));
                else
                   if ((salary >= 32000.01) && (salary <= 60000) && (Marry == 1) && (arrive == 1))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate3 - (child * childtax3)));
                else
                if ((salary >= 32000.01) && (salary <= 60000) && (Marry == 1) && (arrive == 1))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate3 - (child * childtax3) - newly3));
            }

            //Tax rate 4
            {
                if ((salary >= 60000.01) && (Marry == 1) && (arrive == 1))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate4 - (child * childtax4) - marrytax4 - newly4));
                else
                if ((salary >= 60000.01) && (Marry == 1) && (arrive == 1))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate4 - (child * childtax4) - newly4));
                else
                   if ((salary >= 60000.01) && (Marry == 1) && (arrive == 1))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate4 - (child * childtax4)));
                else
                if ((salary >= 60000.01) && (Marry == 1) && (arrive == 1))
                    Console.WriteLine(" Your total tax to be paid is : " + salary * (taxrate4 - (child * childtax4) - newly4));
            }
        }
    }
}