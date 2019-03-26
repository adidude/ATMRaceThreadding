using System;
using System.Threading;
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
        

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            new MainScreen().Show();
            new MainScreen().Show();
            this.Hide();
        }

        private void loginLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
