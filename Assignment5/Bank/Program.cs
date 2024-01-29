using System;
using System.Net;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Xml.Linq;
using assign_5;
using Microsoft.VisualBasic.FileIO;
using static assign_5.Program;

namespace assign_5
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int option;
            int accountRange = 100; // Number of accounts
            //int pos = 0;            // initial position from array;
            int auxAccNum = 0;      // aux Account Number
            int posDeleted = 0;     // pos Deleted Acc

            Client[] clients = new Client[accountRange];   //array of structures
            Client[] clientDeleted = new Client[accountRange];   //array of structures for Deleted Accs

            int[] posAvailable = new int[accountRange];
            for (int i = 0; i < accountRange; i++)
            {
                posAvailable[i] = 0;
            }

            do
            {
                //Console.Clear();   // clean the console
                Console.Write("\nWelcome to Bank\nChoose an option from menu\n");
                Console.Write("1.Add a bank account.\n" +
                              "2.Remove a bank account.\n" +
                              "3.Display the information of a particular client’s account.\n" +
                              "4.Apply a deposit to a particular account.\n" +
                              "5.Apply a withdrawal from a particular account.\n" +
                              "6.Sort and display the list of clients according to their balance, given name in ascending order.\n" +
                              "7.Display the average balance value of the accounts.\n" +
                              "8.Display the total balance value of the accounts.\n" +
                              "9.Exit the application.\n");
                Console.Write("Option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1: //new account        
                        {
                            bool control = false;

                            Console.Write("\nDo you want to choose the position (press 1) or insert at next (press 2)?: \t");
                            option = int.Parse(Console.ReadLine());

                            control = AddClient(clients, accountRange, option);

                            if (control == true)
                            {
                                Console.WriteLine("\t\tAccount created successfully.");
                                //posAvailable[pos] = 999;
                            }
                            else
                            {
                                Console.WriteLine("\t\tSorry, account not created.");
                            }
                        }
                        break;

                case 2: //remove account
                    {
                            bool control = false;

                            Console.Write("\tEnter the account number to delete: ");
                            int accNum = int.Parse(Console.ReadLine());

                            control = Remove(clients, accountRange, accNum);

                            if (control == false)
                            {
                                Console.WriteLine("\t\tSorry, operation canceled.");
                            }
                            else
                            {
                                Console.WriteLine("\t\tAccount Removed Successfully.");
                            }

                        }
                    break;
                    
                    case 3: //display account
                        {
                            bool control = false;

                            Console.Write("\tEnter the account number to display (or 9999 to display all accounts): ");
                            int accNum = int.Parse(Console.ReadLine());

                            control = Display(clients, accountRange, accNum);

                            if (control == false)
                            {
                                Console.WriteLine("\t\tSorry, account not found.");
                            }
                            else
                            {
                                //Console.WriteLine("\t\tDeposit done.");
                            }
                        }
                        break;

                    case 4: //deposit
                        {
                            bool control = false;

                            Console.Write("\tEnter the account number to deposit: ");
                            int accNum = int.Parse(Console.ReadLine());

                            control = Deposit(clients, accountRange, accNum);

                            if (control == false)
                            {
                                Console.WriteLine("\t\tSorry, operation canceled.");
                            }
                            else
                            {
                                Console.WriteLine("\t\tDeposit done.");
                            }

                        }
                        break;

                    case 5: //withdrawal
                        {
                        
                                bool control = false;

                                Console.Write("\tEnter the account number to withdrawal: ");
                                int accNum = int.Parse(Console.ReadLine());

                                control = Withdrawal(clients, accountRange, accNum);

                                if (control == false)
                                {
                                    Console.WriteLine("\t\tSorry, operation canceled.");
                                }
                                else
                                {
                                    Console.WriteLine("\t\tWithdrawal done.");
                                }

                            }
                            break;

                    case 6: //sort all lists
                        {
                            Sorting(clients, accountRange);
                        }
                        break;

                    case 7: //average balance
                        {
                            AverageBalance(clients, accountRange);
                        }
                        break;

                    case 8: //total balance
                        {
                            TotalBalance(clients, accountRange);

                             }
                        break;

                    case 9:
                        {
                            Console.WriteLine("Goodbye.");
                            //Console.ReadKey();
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Unknown selection. Press ENTER and please try again");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (option != 9);
        }

        public static bool AddClient(Client[] clients, int accountRange, int option)
        {
            int opt = option;
            int qtyPosAvailabe = 0;
            string strPosAvailable = "";
            bool control = false;
            int p = 0;
            int i = 0;

            // all positions
            for (i = 0; i < accountRange; i++)
            {
                if (clients[i].Account == 0)
                {
                    qtyPosAvailabe++;
                    //posAvailable[i] = i;        //position available
                    strPosAvailable = strPosAvailable + " " + (i + 1);
                }
                else
                {
                    if (qtyPosAvailabe != 0)
                        qtyPosAvailabe--;
                    //    strPosAvailable = " 1 to " + posAvailable.Length;
                }
            }
     
            if (opt == 1)
            {
                Console.Write("\nPosition available are: [" + strPosAvailable + " ]");

                Console.Write("\nYour chosen position: \t");
                p = int.Parse(Console.ReadLine()) - 1;        // pos starts in 0

                if (clients[p].Account == 0)             // check if position choose is in arr available
                {
                    // add account
                    Console.WriteLine("Enter the new client details (including the initial deposit) :");
                    Console.Write("\tAccount : " + (10000 + p));
                    clients[p].Account = (10000 + p);
                    Console.Write("\n\tName    : ");
                    clients[p].Name = Console.ReadLine();
                    Console.Write("\tSurname : ");
                    clients[p].Surname = Console.ReadLine();

                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("\tDeposit : ");
                        decimal auxBalance = decimal.Parse(Console.ReadLine());

                        if (auxBalance <= 0)
                        {
                            Console.Write("\n\tIncorrect Value. Initial deposit must be greater than zero. You have more " + (2 - j) + " attempts.\n");
                        }
                        else
                        {
                            clients[p].Balance = auxBalance;
                            j = 3;
                            control = true;
                        }
                    }
                }
                else
                {
                    Console.Write("\n\tIncorrect value. The informed position is not available.\n");
                }
            }
            else
            if (opt == 2)
            {
                bool ok = false;

                for (i = 0; i < accountRange; i++)
                {
                    if ((clients[i].Account == 0) && (ok == false))             // check if position choose is in arr available
                    {
                        // add account
                        Console.WriteLine("Enter the new client details (including the initial deposit) :");
                        Console.Write("\tAccount : " + (10000 + i));
                        clients[i].Account = (10000 + i);
                        Console.Write("\n\tName    : ");
                        clients[i].Name = Console.ReadLine();
                        Console.Write("\tSurname : ");
                        clients[i].Surname = Console.ReadLine();

                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("\tDeposit : ");
                            decimal auxBalance = decimal.Parse(Console.ReadLine());

                            if (auxBalance <= 0)
                            {
                                Console.Write("\n\tIncorrect Value. Initial deposit must be greater than zero. You have more " + (2 - j) + " attempts.\n");
                            }
                            else
                            {
                                clients[i].Balance = auxBalance;
                                j = 3;
                                ok = true;
                                control = true;
                            }
                        }
                    }
                }
            }
            i = 0;
            return control;
        }

        public static bool Remove(Client[] clients, int accountRange, int account)
        {
            bool control = false;
            int aNum = account;

            int i = 0;
            while (i < accountRange)
            {
                if (clients[i].Account == aNum)
                {
                    Console.WriteLine("Client details:");
                    Console.WriteLine("\tAccount : " + clients[i].Account);
                    Console.WriteLine("\tName    : " + clients[i].Name);
                    Console.WriteLine("\tSurname : " + clients[i].Surname);
                    Console.WriteLine("\tBalance : " + clients[i].Balance);
                    Console.WriteLine("-----------------------");

                    if (clients[i].Balance != 0)
                    {
                        Console.Write("This account has amount of CAD " + clients[i].Balance + ". Confirm to delete? Y or N: \t");
                        char confirmDelete = char.Parse(Console.ReadLine());

                        if (confirmDelete == 'Y' || confirmDelete == 'y')
                        {
                            //clientDeleted[posDeleted] = clients[i];         // array save to deleted acc
                            clients[i].Account = 0;                         // array save to deleted acc
                            clients[i].Name = "";
                            clients[i].Surname = "";
                            clients[i].Balance = 0;

                            Console.WriteLine("-----------------------");
                            control = true;
                           // Console.WriteLine("\t\tAccount successfully deleted.");
                        }
                        else
                        {
                            Console.WriteLine("\tOperation cancelled. Account " + clients[i].Account + " is still active.");
                            control = false;
                            i = accountRange;
                        }
                    }
                    else
                    {
                        //clientDeleted[posDeleted] = clients[i];         // array save to deleted acc

                        //clients[i] = clients[i + 1];                    // array repos the array putting empty to final
                        Console.WriteLine("-----------------------");
                        control = true;
                    }
                }
                i++;
            }
            return control;

        }

        public static bool Display(Client[] clients, int accountRange, int account)
        {
            bool control = false;
            int i = 0;
            int j = 0;
            int aNum = account;
            if (aNum == 9999)
            {
                for (i = 0; i < accountRange; i++)
                {
                    if (clients[i].Account != 0)
                    {
                        Console.WriteLine("Client details:");
                        Console.WriteLine("\tAccount : " + clients[i].Account);
                        Console.WriteLine("\tName    : " + clients[i].Name);
                        Console.WriteLine("\tSurname : " + clients[i].Surname);
                        Console.WriteLine("\tBalance : " + clients[i].Balance);
                        Console.WriteLine("\t-----------------------");
                        j++;
                        control = true;

                    }
                    else
                        if (j == 0 && i == accountRange - 1)
                    {
                        control = false;
                        //Console.WriteLine("\t\tNo account found.");
                    }
                }
            }
            else
            {
                i = 0;
                while (i < accountRange)
                {
                    if (clients[i].Account == aNum)
                    {
                        Console.WriteLine("Client details:");
                        Console.WriteLine("\tAccount : " + clients[i].Account);
                        Console.WriteLine("\tName    : " + clients[i].Name);
                        Console.WriteLine("\tSurname : " + clients[i].Surname);
                        Console.WriteLine("\tBalance : " + clients[i].Balance);
                        Console.WriteLine("\t-----------------------");
                        i = accountRange;
                        control = true;
                    }
                    else
                        if (i == accountRange - 1)
                    {
                        control = false;
                        //Console.WriteLine("\t\tAccount not found.");
                    }
                    i++;
                }
            }
            return control;
        }

        public static bool Deposit(Client[] clients, int accountRange, int account)
        {
            int j = 0;
            int accNumber = account;
            bool control = false;
            bool foundAcc = false;

            for (int i = 0; i < accountRange; i++)
            {
                if (clients[i].Account == accNumber)
                {
                    Console.WriteLine("Client details:");
                    Console.WriteLine("\tAccount : " + clients[i].Account);
                    Console.WriteLine("\tName    : " + clients[i].Name);
                    Console.WriteLine("\tSurname : " + clients[i].Surname);
                    Console.WriteLine("\tBalance : " + clients[i].Balance);
                    Console.WriteLine("\t-----------------------");
                    j++;

                    int auxDeposit = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("\tEnter the value to deposit: ");
                        auxDeposit = int.Parse(Console.ReadLine());

                        if (auxDeposit <= 0)
                        {
                            Console.Write("\n\tIncorrect Value. Deposit must be greater than zero. You have more " + (3 - k) + " attempts.\n");
                        }
                        else
                        {
                            Console.Write("\t\tConfirm the deposit of CAD " + auxDeposit + "? Y or N: \t");
                            char confirmDeposit = char.Parse(Console.ReadLine());

                            if (confirmDeposit == 'Y' || confirmDeposit == 'y')
                            {
                                clients[i].Balance = clients[i].Balance + auxDeposit;
                                Console.WriteLine("\t\tOperation realized with success. Your new Balance is: CAD " + clients[i].Balance);
                                k = 3;
                                //i = accountRange;
                                foundAcc = true;
                                control = true;
                            }
                            else
                            {
                                Console.WriteLine("\t\tDeposit cancelled. Your Balance is: CAD " + clients[i].Balance);
                                control = false;
                                foundAcc = true;
                            }
                        }
                    }
                }
                else
                if (foundAcc == false) // never found account
                {
                    control = false;
                }
            }
            return control;
        }

        public static bool Withdrawal(Client[] clients, int accountRange, int account)
        {
            bool control = false;
            bool foundAcc = false;
            int j = 0;
            int aNum = account;

            for (int i = 0; i < accountRange; i++)
            {
                if (clients[i].Account == aNum)
                {
                    Console.WriteLine("Client details:");
                    Console.WriteLine("\tAccount : " + clients[i].Account);
                    Console.WriteLine("\tName    : " + clients[i].Name);
                    Console.WriteLine("\tSurname : " + clients[i].Surname);
                    Console.WriteLine("\tBalance : " + clients[i].Balance);
                    Console.WriteLine("\t-----------------------");
                    j++;

                    Console.Write("\tEnter the value to withdrawal: ");
                    int amountWithdrawal = int.Parse(Console.ReadLine());

                    if (amountWithdrawal > clients[i].Balance)
                    {
                        Console.Write("\tInsufficient funds. Actual Balance is: CAD " + clients[i].Balance);
                    }
                    else
                    {
                        Console.Write("Confirm the withdrawal of CAD " + amountWithdrawal + "? Y or N: ");
                        char confirmWithdrawal = char.Parse(Console.ReadLine());

                        if (confirmWithdrawal == 'Y' || confirmWithdrawal == 'y')
                        {
                            clients[i].Balance = clients[i].Balance - amountWithdrawal;
                            Console.WriteLine("\t\tYour new Balance is: CAD " + clients[i].Balance);
                            control = true;
                            foundAcc = true;
                        }
                        else
                        {
                            Console.WriteLine("\t\tWithdrawal cancelled. Your Balance is: CAD " + clients[i].Balance);
                            control = false;
                        }
                    }
                }
                else
                if (foundAcc == false) // never found account
                {
                    control = false;
                }
            }
            return control;
        }

        public static void Sorting(Client[] clients, int accountRange)
        {
            Console.WriteLine("Chose the option to order the list of clients:");
            Console.Write("1 - Ordered by Account Number\n" +
                          "2 - Ordered by Account Balance\n" +
                          "3 - Ordered by User Name\n" +
                          "Option: ");


            int sort_opt = int.Parse(Console.ReadLine());

            int i;
            int j;
            int y;
            decimal t;
            string k;
            string h;

            switch (sort_opt)
            {
                case 1: //Sorting by Account Number
                    {
                        Console.WriteLine("Client details ordered by their account number:");
                        for (i = 0; i < accountRange; i++)
                        {
                            for (j = i + 1; j < accountRange; j++)
                            {
                                if (clients[j].Account < clients[i].Account)
                                {
                                    //changing the order of the balances
                                    t = clients[i].Balance;
                                    clients[i].Balance = clients[j].Balance;
                                    clients[j].Balance = t;
                                    //changing the order of the accounts
                                    y = clients[i].Account;
                                    clients[i].Account = clients[j].Account;
                                    clients[j].Account = y;
                                    //changing the order of the names
                                    k = clients[i].Name;
                                    clients[i].Name = clients[j].Name;
                                    clients[j].Name = k;
                                    //changing the order of the surnames
                                    h = clients[i].Surname;
                                    clients[i].Surname = clients[j].Surname;
                                    clients[j].Surname = h;

                                }
                            }
                            if (clients[i].Account != 0)
                            {
                                Console.WriteLine("\t-----------------------");
                                Console.WriteLine("\tAccount   : " + clients[i].Account);
                                Console.WriteLine("\tFull Name : " + clients[i].Name + " " + clients[i].Surname);
                                Console.WriteLine("\tBalance   : " + clients[i].Balance);
                                Console.WriteLine("\t-----------------------");
                            }
                        }
                    }
                    break;

                case 2: //Sorting by Account Balance
                    {
                        Console.WriteLine("Client details ordered by their balance:");
                        for (i = 0; i < accountRange; i++)
                        {
                            for (j = i + 1; j < accountRange; j++)
                            {
                                if (clients[j].Balance < clients[i].Balance)
                                {
                                    //changing the order of the balances
                                    t = clients[i].Balance;
                                    clients[i].Balance = clients[j].Balance;
                                    clients[j].Balance = t;
                                    //changing the order of the accounts
                                    y = clients[i].Account;
                                    clients[i].Account = clients[j].Account;
                                    clients[j].Account = y;
                                    //changing the order of the names
                                    k = clients[i].Name;
                                    clients[i].Name = clients[j].Name;
                                    clients[j].Name = k;
                                    //changing the order of the surnames
                                    h = clients[i].Surname;
                                    clients[i].Surname = clients[j].Surname;
                                    clients[j].Surname = h;

                                }
                            }
                            if (clients[i].Account != 0)
                            {
                                Console.WriteLine("\t-----------------------");
                                Console.WriteLine("\tAccount   : " + clients[i].Account);
                                Console.WriteLine("\tFull Name : " + clients[i].Name + " " + clients[i].Surname);
                                Console.WriteLine("\tBalance   : " + clients[i].Balance);
                                Console.WriteLine("\t-----------------------");
                            }
                        }


                    }
                    break;

                case 3: //Sorting by User Name
                    {
                         Console.WriteLine("Client details ordered by Names:");
                
                        for (i = 0; i < accountRange; i++)
                        {
                            for (j = i + 1; j < accountRange; j++)
                            {
                                if (clients[i].Account != 0)
                                {
                                    int cmpVal = clients[i].Name.CompareTo(clients[j].Name);
                                    if (cmpVal > 0)
                                    {
                                        //changing the order of the balances
                                        t = clients[j].Balance;
                                        clients[j].Balance = clients[i].Balance;
                                        clients[i].Balance = t;
                                        //changing the order of the accounts
                                        y = clients[j].Account;
                                        clients[j].Account = clients[i].Account;
                                        clients[i].Account = y;
                                        //changing the order of the names
                                        k = clients[j].Name;
                                        clients[j].Name = clients[i].Name;
                                        clients[i].Name = k;
                                        //changing the order of the surnames
                                        h = clients[j].Surname;
                                        clients[j].Surname = clients[i].Surname;
                                        clients[i].Surname = h;
                                    }
                                }
                            }   
                        }

                        for (i = 0; i < accountRange; i++)
                        {
                            if (clients[i].Account != 0)
                            {
                                Console.WriteLine("\t-----------------------");
                                Console.WriteLine("\tAccount   : " + clients[i].Account);
                                Console.WriteLine("\tFull Name : " + clients[i].Name + " " + clients[i].Surname);
                                Console.WriteLine("\tBalance   : " + clients[i].Balance);
                                Console.WriteLine("\t-----------------------");
                            }
                        }
                    }
                    break;
            }
            return;
        }

        public static void AverageBalance(Client[] clients, int accountRange)
        {
            decimal averageBalance = 0;
            int j = 0;

            for (int i = 0; i < accountRange; i++)
            {
                if (clients[i].Account != 0)
                {
                    averageBalance = averageBalance + clients[i].Balance;
                    j++;
                }
                else
                if (j == 0 && i == accountRange - 1)
                {
                    Console.WriteLine("\t\tNo account found.");
                }
            }
            averageBalance = averageBalance / j;

            Console.Write("\n\t\tThe bank has " + j + " accounts and the average of balance is CAD " + averageBalance + "\n");
        }

        public static void TotalBalance(Client[] clients, int accountRange)
        {
            decimal totalBalance = 0;
            int j = 0;
            for (int i = 0; i < accountRange; i++)
            {
                if (clients[i].Account != 0)
                {
                    totalBalance = totalBalance + clients[i].Balance;
                    j++;
                }
                else
                if (j == 0 && i == accountRange - 1)
                {
                    Console.WriteLine("\t\tNo account found.");
                }
            }
            Console.Write("\n\t\tThe bank has " + j + " accounts and the total of balance is CAD " + totalBalance + "\n");
        }


        public struct Client
        {
            public int Account;
            public string Name;
            public string Surname;
            public decimal Balance;
        }
    }
}