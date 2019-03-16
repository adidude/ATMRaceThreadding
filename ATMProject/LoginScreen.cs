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
    public partial class LoginScreen : Form
    {
        Program logic;

        public LoginScreen()
        {
            InitializeComponent();
            logic = new Program();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Converts and stores the account number as an integer.
            int intVal = 0;

            if (logic.isLoginSuccesfull(Int32.Parse(accountNumberTxtbox.Text), Int32.Parse(pinNumberTxtbox.Text)))
            {
                //TODO:Implement Success Condition
            }
            else
            {
                //TODO:Implement Failure Condition
            }
        }
    }
}
