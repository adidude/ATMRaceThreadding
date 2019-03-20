using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
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
            //Console.WriteLine("hello from ATM");

        }
        public Account getActiveAccount()
        {
            return activeAccount;
        }
        public void setActiveAccount(Account thisAccount)
        {
            activeAccount = thisAccount;
        }
        
    }
}

