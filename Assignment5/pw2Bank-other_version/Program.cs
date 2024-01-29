/*
Create a prototype of a program that simulates a bank. More precisely, the program should be able to store the family name and given name of a client,
their unique account number (a number between 10000 and 10099), and the balance of their account.
The program should display a menu with the following options:
1.	Add a bank account.
2.	Remove a bank account. 
3.	Display the information of a particular client’s account. (by account number)
4.	Apply a deposit to a particular account. (by account number)
5.	Apply a withdrawal from a particular account. (by account number)
6.	Sort and display the list of clients according to their balance, family name and given name, in ascending or descending order.
7.	Display the average balance value of the accounts.
8.	Display the total balance value of the accounts.
9.	Exit the application.
You must implement each of these functionalities 
*/

namespace pw2BankBrunoFranciscoVictorYasser
{

    public class clientBank
    {
        int accountNum;
        string firstName;
        string lastName;
        double balance;

        public clientBank(int accountNum, string firstName, string lastName, double balance)
        {
            this.accountNum = accountNum;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public int getAccountNum()
        {
            return accountNum;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setNum(int newAccountNum)
        {
            accountNum = newAccountNum;
        }

        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName(string newFirstName)
        {
            lastName = newFirstName;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }

        public static void Main(string[] args)
        {
            List<clientBank> clientBanks = new List<clientBank>();

            void menuOptions()
            {
                Console.Write("\nWelcome to Bank\nChoose an option from menu\n");
                Console.Write("1.Add a bank account.\n" +
                              "2.Remove a bank account.\n" +
                              "3.Display the information of a particular client’s account.\n" +
                              "4.Apply a deposit to a particular account.\n" +
                              "5.Apply a withdrawal from a particular account.\n" +
                              "6.Sort and display the list of clients according to their balance, family name and given name, in ascending or descending order.\n" +
                              "7.Display the average balance value of the accounts.\n" +
                              "8.Display the total balance value of the accounts.\n" +
                              "9.Exit the application.\n");
            }

            void deposit(clientBank currentUser)
            {
                Console.WriteLine("How much money would you like to deposit?");
                double deposit = double.Parse(Console.ReadLine());
                currentUser.setBalance(deposit);
                Console.WriteLine("Thank you, deposit done, your new balance is CAD " + currentUser.getBalance);
            }

            void withdrawal(clientBank currentUser)
            {
                Console.WriteLine("How much money would you like to withdraw?");
                double withdrawal = double.Parse(Console.ReadLine());
                currentUser.getBalance();
                if (currentUser.getBalance() > withdrawal)
                {
                    Console.WriteLine("Insufficient balance, your new balance is CAD " + currentUser.getBalance);
                }
                else
                {
                    currentUser.setBalance(currentUser.getBalance() - withdrawal);
                    Console.WriteLine("Success! Welcome soon...");
                }
            }

            void balance(clientBank currentUser)
            {
                Console.WriteLine("Current balance: CAD " + currentUser.getBalance());
            }

            void addClient(clientBank currentUser)
            {
                int accountNum = currentUser.getAccountNum() + 1;
                string firstName = "";
                string lastName = "";
                double balance;

                if (accountNum >= 10000 && accountNum < 10100)
                {
                    Console.Write("Fill out the form below:\n");
                    Console.Write("Name: ");
                    firstName = Console.ReadLine();
                    Console.Write("Surname: ");
                    lastName = Console.ReadLine();

                    Console.Write("Your balance is 0. How much money for your initial deposit?\nCAD ");
                    balance = double.Parse(Console.ReadLine());

                    clientBanks.Add(new clientBank(accountNum, firstName, lastName, balance));
                }
                else
                {
                    Console.Write("Exceeded the number of accounts. Please waiting our contact to continue this open process..");
                }
            }

            Console.WriteLine("Welcome to pw2BankBFVY");
            Console.WriteLine("Please input your account number: ");
            int userAccountNumber;
            clientBank currentUser;

            while (true)
            {
                try
                {
                    userAccountNumber = int.Parse(Console.ReadLine());
                    currentUser = clientBanks.FirstOrDefault(a => a.accountNum == userAccountNumber);
                    if (currentUser != null) {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Account number not recognized. Can you try again? 1-YES or 2-NO (to add an account)");
                        int tryAgain = int.Parse(Console.ReadLine()); ;
                        if (tryAgain == 2)
                        {
                            addClient(currentUser);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Account number not recognized. Please, Try again.");
                }
            }

            Console.WriteLine("Welcome " + currentUser.getFirstName());
            int option = 0;

            do
            {
                menuOptions();
                switch (option)
                {
                    case 1: //new account
                        {
                            addClient(currentUser);
                            break;
                        }

                    case 2: //remove account
                        {
                            //displayClient();
                            break;
                        }
                    case 3: //display account
                        {
                            // displayClient();
                            break;
                        }

                    case 4: //deposit
                        {
                            deposit(currentUser);
                            break;
                        }

                    case 5:
                        {
                            withdrawal(currentUser);
                            break;
                        }

                    case 6: // sort and list all
                        {
                            //withdrawal(currentUser);
                            break;
                        }

                    case 7: // avarage balance
                        {
                            //withdrawal(currentUser);
                            break;
                        }

                    case 8: // total balance
                        {
                            //withdrawal(currentUser);
                            break;
                        }

                    case 9: // quit
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Unknown selection. Press ENTER and please try again");
                            break;
                        }
                }
            } while (option != 9);
            Console.WriteLine("Thank you! Come back soon! =)");

        }
    }
}






   