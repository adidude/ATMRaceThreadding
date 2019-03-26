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
    public partial class ModePicker : Form
    {
        public ModePicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "This Will Simulate A Race Condition";
            string info = "Information";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, info, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //close the form and open the race condition windows

                //Application.Run(new MainScreenLogin());
                this.Hide();
                MainScreenLogin mainScreenLogin = new MainScreenLogin();
                mainScreenLogin.Show();
                
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "***yet to be implemented";
            string info = "Information";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, info, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //close the form and open the race condition windows
                this.Close();
            }
        }
    }
}
