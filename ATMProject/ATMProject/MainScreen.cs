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
    public partial class MainScreen : Form
    {
        Program thisProgram = new Program();
        public MainScreen()
        {
            InitializeComponent();

            withdrawATMBtn.Visible = false;
            withdrawATMBtn2.Visible = false;
            accountBalanceBtn.Visible = false;
            accountBalanceBtn2.Visible = false;
            btnExit.Visible = false;
            btnExit2.Visible = false;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            updateForm();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void updateForm()
        {
            mainLbl.Text = "ATM Systems -Choose Option(s)";
            submitBtn.Visible = false;
            accountNumberTxtbox.Visible = false;
            pinNumberTxtbox.Visible = false;
            withdrawATMBtn.Visible = true;
            withdrawATMBtn2.Visible = true;
            accountBalanceBtn.Visible = true;
            accountBalanceBtn2.Visible = true;
            btnExit.Visible = true;
            btnExit2.Visible = true;
            accountNumberLbl.Visible = false;
            pinNumberLbl.Visible = false;
        }
      
          
        }
        

        
    }

