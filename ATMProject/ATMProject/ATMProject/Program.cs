﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    class Program
    {
        private Account[] ac = new Account[3];
        private ATM atm;

        public Program()
        {
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
            atm = new ATM(ac);
        }
        public Account[] GetAccounts()
        {
            return ac;
        }
        public ATM GetATM()
        {
            return atm;
        }
        public Boolean isLoginSuccessful(int accNo, int pin)
        {
            //For the number of accounts in the bank.
            for (int i = 0; i < ac.Length; i++)
            {
                //If the current account is the one being searched for.
                if (ac[i].getAccountNum() == accNo)
                {
                    this.GetATM().setActiveAccount(ac[i]);
                    //Checks if the pin is correct and returns the value.
                    return ac[i].checkPin(pin);
                }
            }
            return false;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }


    }
}
