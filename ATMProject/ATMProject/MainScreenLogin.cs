using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class MainScreenLogin : Form
    {
        Program thisProgram = new Program();
        public MainScreenLogin()
        {
            InitializeComponent();
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Account current = thisProgram.GetATM().getActiveAccount();
            if (thisProgram.isLoginSuccessful(Int32.Parse(accountNumberTxtbox.Text), Int32.Parse(pinNumberTxtbox.Text)) && thisProgram.GetATM().getActiveAccount().getBlocked() != true)
            {
                //TODO:Implement Success Condition
                thisProgram.GetATM().getActiveAccount().setAttemptsLeft(3);
                new MainScreenATM(thisProgram.GetATM().getActiveAccount()).Show();
                new MainScreenATM(thisProgram.GetATM().getActiveAccount()).Show();
                this.Hide();
            }
            else
            {
                //TODO:Implement Failure Condition
                thisProgram.GetATM().getActiveAccount().setAttemptsLeft(thisProgram.GetATM().getActiveAccount().getAttemptsLeft() - 1);
                if (thisProgram.GetATM().getActiveAccount().getAttemptsLeft() == 0)
                {
                    thisProgram.GetATM().getActiveAccount().setBlocked(true);
                    MessageBox.Show("The card associated with this account has been blocked because of too many failed attempts", "Card Blocked!", MessageBoxButtons.OK);
                }
                else if (thisProgram.GetATM().getActiveAccount().getBlocked() == true)
                {
                    MessageBox.Show("This card was previously blocked due to successive incorrect PIN entries", "Contact your bank branch!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Please enter the correct account number or PIN. Your account will be blocked after enough failed attempts", "Login Failed!", MessageBoxButtons.OK);
                }

            }
        }

    }
}

