using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
 
    class ThreadCreationProgram
    {
        public static void CallToATMThread()
        {
            Console.WriteLine("ATM Thead starting");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());

        }
        static class Program
        {


            static void Main()
            {
                
                ThreadStart ATM1Thread = new ThreadStart(CallToATMThread);
                Thread ATM1 = new Thread(ATM1Thread);
                ThreadStart ATM2Thread = new ThreadStart(CallToATMThread);
                Thread ATM2 = new Thread(ATM2Thread);
                Console.WriteLine("In Main: Creating the ATM1 thread");
                ATM1.Start();
                ATM2.Start();
                
                
                
                /*Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginScreen());
                */

            }
        }
    }
}
