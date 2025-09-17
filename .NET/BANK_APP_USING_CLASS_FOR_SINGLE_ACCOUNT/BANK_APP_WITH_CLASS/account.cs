using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_APP_USING_CLASS_FOR_SINGLE_ACCOUNT
{
    internal class account
    {
        int acc_no = 0;
        string acc_name = string.Empty;
        int balance = 0;
        int deposit;
        public account()
        {
        }

        public account(int acc_no, string acc_name, int balance)
        {
            this.acc_no = acc_no;
            this.acc_name = acc_name;
            this.balance = balance;
        }

        public void Deposit()
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
            }

            balance = balance + deposit;
            Console.WriteLine("Account Created Successfully \n");
        }

        public void withdraw()
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
        }

        public void get_details()
        {
            Console.WriteLine("the account details are :");
            Console.WriteLine("Account Number : " + acc_no);
            Console.WriteLine("Account Holder Name : " + acc_name);
            Console.WriteLine("Available Balance : " + balance);
        }

    }
}
