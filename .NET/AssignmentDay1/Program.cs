namespace AssignmentDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create account based bank management system 

            
            Console.WriteLine("1. Create a New Bank Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Display account details");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Please enter your option");
            int option=Convert.ToInt32(Console.ReadLine());
            int acc_no=0;
            string acc_name="NA";
            int balance=0;
            int deposit;
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

                    Console.WriteLine("1. Create a New Bank Account");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Display account details");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("Please enter your option");
                    option = Convert.ToInt32(Console.ReadLine());
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter deposit amount ");
                    deposit = Convert.ToInt32(Console.ReadLine());
                    if (deposit < 0)
                    {
                        Console.WriteLine("Invalid Amount");
                        while (deposit < 0)
                        {
                            Console.WriteLine("please enter valid deposit amount ");
                            deposit = Convert.ToInt32(Console.ReadLine());
                        }
                        //return;
                    }

                    balance = balance + deposit;
                    Console.WriteLine("Account Created Successfully \n");

                    Console.WriteLine("1. Create a New Bank Account");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Display account details");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("Please enter your option");
                    option = Convert.ToInt32(Console.ReadLine());
                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter amount to be withdrawed ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    if (withdraw < 0)
                    {
                        Console.WriteLine("Invalid Amount");
                        while (withdraw < 0)
                        {
                            Console.WriteLine("please enter valid withdraw amount ");
                            withdraw = Convert.ToInt32(Console.ReadLine());
                        }
                        //return;
                    }
                    if (withdraw <= balance)
                        balance = balance - withdraw;
                    else
                    {
                        Console.WriteLine("Insufficient Balance");
                        while (withdraw >= balance)
                        {
                            Console.WriteLine("please enter valid withdraw amount ");
                            withdraw = Convert.ToInt32(Console.ReadLine());
                        }
                        balance = balance - withdraw;
                    }
                    Console.WriteLine("Amount Withdrawed Successfully\n");

                    Console.WriteLine("1. Create a New Bank Account");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Display account details");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("Please enter your option");
                    option = Convert.ToInt32(Console.ReadLine());
                }
                else if (option == 4)
                {
                    Console.WriteLine("the account details are :");
                    Console.WriteLine("Account Number : " + acc_no);
                    Console.WriteLine("Account Holder Name : " + acc_name);
                    Console.WriteLine("Available Balance : " + balance);

                    Console.WriteLine("1. Create a New Bank Account");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Display account details");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("Please enter your option");
                    option = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("You have exited");
  

        }
    }
}
