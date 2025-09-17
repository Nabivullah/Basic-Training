using System.Security.Principal;

namespace BANK_APP_USING_CLASS_FOR_SINGLE_ACCOUNT
{
    internal class Program
    {
        static public int option;
            
            int acc_no = 0;
            string acc_name = string.Empty;
            int balance = 0;
            int deposit;

            static void display_menu()
            {
                Console.WriteLine("1. Create a New Bank Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Display account details");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please enter your option");
                option = Convert.ToInt32(Console.ReadLine());
            }
            static void Main(string[] args)
            {
                //create account based bank management system for one account using classes


                display_menu();
                account new_account = new account();
                int acc_no = 0;
                string acc_name = string.Empty;
                int balance = 0;
                int deposit = 0;
                while (option > 5)
                {
                    Console.WriteLine("Invalid Option");
                    Console.WriteLine("Please enter valid option");
                    option = Convert.ToInt32(Console.ReadLine());

                }
                while (option != 5)
                {
                    if (option == 1)
                    {
                        Console.WriteLine("Enter Account Number ");
                        acc_no = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Account Holder Name ");
                        acc_name = Console.ReadLine();
                        new_account = new account(acc_no, acc_name, balance);


                        display_menu();
                    }
                    else if (option == 2)
                    {

                        new_account.Deposit();

                        display_menu();
                    }
                    else if (option == 3)
                    {
                        new_account.withdraw();

                        display_menu();
                    }
                    else if (option == 4)
                    {

                        new_account.get_details();

                        display_menu();
                    }
                }

                Console.WriteLine("You have exited");

            }
        }
    }
