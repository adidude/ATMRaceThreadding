﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace ATMProject
{
    public class Program
    {
        private Account[] ac = new Account[3];
        private ATM atm;
        public static bool threadDelay = false;
        public static bool raceCond = false;
        public static ManualResetEvent mre = new ManualResetEvent(false);
        public static Semaphore semaphore = new Semaphore(1, 1);
        public Program()
        {
            ac[0] = new Account(300, 1111, 111111, false, 3);
            ac[1] = new Account(750, 2222, 222222, false, 3);
            ac[2] = new Account(3000, 3333, 333333, false, 3);
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
        /*
         Will test to see if the details are correct for the relevant account.
             */
        public Boolean isLoginSuccessful(int accNo, int pin)
        {
            //For the number of accounts in the bank.
            for (int i = 0; i < ac.Length; i++)
            {
                this.GetATM().setActiveAccount(ac[i]);
                //If the current account is the one being searched for.
                if (ac[i].getAccountNum() == accNo)
                {
                    //Checks if the pin is correct and returns the value.
                    return ac[i].checkPin(pin);
                }
            }
            return false;
        }
        public static void CallToATMThread()
        {
            Console.WriteLine("ATM Thead starting");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreenLogin());

        }
        public static void startThreading() //called when the threaded forms should start
        {
            ThreadStart ATM1Thread = new ThreadStart(CallToATMThread);
            Thread ATM1 = new Thread(ATM1Thread);
            ThreadStart ATM2Thread = new ThreadStart(CallToATMThread);
            Thread ATM2 = new Thread(ATM2Thread);
            Console.WriteLine("In Main: Creating the ATM threads");
            ATM1.Start();
            ATM2.Start();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ModePicker());
        }


    }

    /**
     * Is a timer for carrying out events after an interval.
     **/
    public class GifTimer
    {
        private static System.Timers.Timer clock = new System.Timers.Timer();

        public void setTimer(int time)
        {
            clock.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            clock.Interval = time;

            clock.Enabled = true;

        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            clock.Enabled = false;
        }

        public System.Timers.Timer getClock()
        {
            return clock;
        }
    }
}