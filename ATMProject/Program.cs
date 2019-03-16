using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    class Program
    {
        private Account[] ac = new Account[3];

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());

            new Program();

        }

        /*
         * This function initilises 3 accounts
         * 
         */
        public Program()
        {
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
        }

        /*
         Will test to see if the details are correct for the relevant account.
             */
        public Boolean isLoginSuccesfull(int accNo,int pin)
        {
            //For the number of accounts in the bank.
            for (int i=0;i < ac.Length;i++)
            {
                //If the current account is the one being searched for.
                if (ac[i].getAccountNum() == accNo)
                {
                    //Checks if the pin is correct and returns the value.
                    return ac[i].checkPin(pin);
                }
            }
            return false;
        }
    }

    /*
     *   The Account class encapusulates all features of a simple bank account
     */
    class Account
    {
        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        /*
         *   This funciton allows us to decrement the balance of an account
         *   it perfomes a simple check to ensure the balance is greater tha
         *   the amount being debeted
         *   
         *   reurns:
         *   true if the transactions if possible
         *   false if there are insufficent funds in the account
         */
        public Boolean decrementBalance(int amount)
        {
            if (this.balance > amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * This funciton check the account pin against the argument passed to it
         *
         * returns:
         * true if they match
         * false if they do not
         */
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getAccountNum()
        {
            return accountNum;
        }

    }

    /* 
     *      This is out main ATM class that preforms the actions outlined in the assigment hand out
     *      
     *      the constutor contains the main funcitonality.
     */
    class ATM
    {
        //local referance to the array of accounts
        private Account[] ac;

        //this is a referance to the account that is being used
        private Account activeAccount = null;

        // the atm constructor takes an array of account objects as a referance
        public ATM(Account[] ac)
        {
            this.ac = ac;

            //ask for account number and store result in acctiveAccount (null if no match found)
            //activeAccount = this.findAccount();

            if (activeAccount != null)
            {
                //if the account is found check the pin 
                /*if (activeAccount.checkPin(this.promptForPin()))
                {
                    //if the pin is a match give the options to do stuff to the account (take money out, view balance, exit)
                    //dispOptions();
                }*/
            }
            else
            {   //if the account number entered is not found let the user know!
                Console.WriteLine("no matching account found.");
            }

            //wipes all text from the console
            Console.Clear();



        }
    }
}