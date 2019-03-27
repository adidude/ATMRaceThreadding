using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//TODO: Check if necessary
using System.Timers;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class MainScreen : Form
    {
        //TODO: Check if necessary
        private static System.Timers.Timer timer = new System.Timers.Timer();

        Program thisProgram = new Program();
        public MainScreen()
        {
            InitializeComponent();
            //Hides all elements of the form.
            withdrawATMBtn.Visible = false;
            withdrawATMBtn2.Visible = false;
            accountBalanceBtn.Visible = false;
            accountBalanceBtn2.Visible = false;
            btnExit.Visible = false;
            btnExit2.Visible = false;
            btn10.Visible = false;
            btn10_2.Visible = false;
            btn20.Visible = false;
            btn20_2.Visible = false;
            btn40.Visible = false;
            btn40_2.Visible = false;
            btn100.Visible = false;
            btn100_2.Visible = false;
            btn500.Visible = false;
            btn500_2.Visible = false;
            customBtn.Visible = false;
            customBtn_2.Visible = false;
            btnBack.Visible = false;
            btnBack_2.Visible = false;
            accountNumberLbl.Visible = false;
            accountNumberTxtbox.Visible = false;
            pinNumberTxtbox.Visible = false;
            pinNumberLbl.Visible = false;
            mainLbl.Visible = false;
            submitBtn.Visible = false;
            gifRenderer.Visible = false;
        }

        /**
         * Will check if the account and pin are correct.
         **/
        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //If the login is successful.
                if (thisProgram.isLoginSuccessful(Int32.Parse(accountNumberTxtbox.Text), Int32.Parse(pinNumberTxtbox.Text)))
                {
                    updateForm();
                }
                else
                {
                    MessageBox.Show("Please enter the correct account number or PIN", "Login Failed!", MessageBoxButtons.OK);

                }
            }
            catch (System.FormatException o)
            {
                MessageBox.Show("Please enter the correct account number or PIN", "Login Failed!", MessageBoxButtons.OK);
            }
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

        private void withdrawATMBtn_Click(object sender, EventArgs e)
        {
            btn10.Visible = true;
            btn20.Visible = true;
            btn40.Visible = true;
            btn100.Visible = true;
            btn500.Visible = true;
            customBtn.Visible = true;
            btnBack.Visible = true;

            withdrawATMBtn.Visible = false;
            accountBalanceBtn.Visible = false;
            btnExit.Visible = false;
        }

        private void withdrawATMBtn2_Click(object sender, EventArgs e)
        {
            btn10_2.Visible = true;
            btn20_2.Visible = true;
            btn40_2.Visible = true;
            btn100_2.Visible = true;
            btn500_2.Visible = true;
            customBtn_2.Visible = true;
            btnBack_2.Visible = true;

            withdrawATMBtn2.Visible = false;
            accountBalanceBtn2.Visible = false;
            btnExit2.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            withdrawATMBtn.Visible = true;
            accountBalanceBtn.Visible = true;
            btnExit.Visible = true;

            btn10.Visible = false;
            btn20.Visible = false;
            btn40.Visible = false;
            btn100.Visible = false;
            btn500.Visible = false;
            customBtn.Visible = false;
            btnBack.Visible = false;
        }

        private void btnBack_2_Click(object sender, EventArgs e)
        {
            withdrawATMBtn2.Visible = true;
            accountBalanceBtn2.Visible = true;
            btnExit2.Visible = true;

            btn10_2.Visible = false;
            btn20_2.Visible = false;
            btn40_2.Visible = false;
            btn100_2.Visible = false;
            btn500_2.Visible = false;
            customBtn_2.Visible = false;
            btnBack_2.Visible = false;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(10);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(20);
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(40);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(100);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(500);
        }

        private void accountBalanceBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your balance is £" + thisProgram.GetATM().getActiveAccount().getBalance(), "Account Balance");
        }

        private void btn10_2_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(10);
        }

        private void btn20_2_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(20);
        }

        private void btn40_2_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(40);
        }

        private void btn100_2_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(100);
        }

        private void btn500_2_Click(object sender, EventArgs e)
        {
            Account tempAccount = thisProgram.GetATM().getActiveAccount();
            tempAccount.decrementBalance(500);
        }

        private void accountBalanceBtn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your balance is £" + thisProgram.GetATM().getActiveAccount().getBalance(), "Account Balance");
        }

        private void InsertCardBtn_Click(object sender, EventArgs e)
        {
            InsertCardBtn.Visible = false;
            gifRenderer.Visible = true;
            //SetTimer(1960);
            while (gifRenderer.Visible)
            {
                gifRenderer.Refresh();
                if (!timer.Enabled)
                {
                    accountNumberLbl.Visible = true;
                    accountNumberTxtbox.Visible = true;
                    pinNumberTxtbox.Visible = true;
                    pinNumberLbl.Visible = true;
                    mainLbl.Visible = true;
                    submitBtn.Visible = true;
                    gifRenderer.Visible = false;
                }
            }
        }

        private void SetTimer(int time)

        {
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            timer.Interval = time;

            timer.Enabled = true;

        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)

        {
            timer.Enabled = false;
        }

        //resizes an image
        public static Bitmap ResizeImage(Image image, int X,int y)
        {
            var destRect = new Rectangle(0, 0, x, siyze); var destImage = new Bitmap(x, y); destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy; graphics.CompositingQuality = CompositingQuality.HighQuality; graphics.InterpolationMode = InterpolationMode.HighQualityBicubic; graphics.SmoothingMode = SmoothingMode.HighQuality; graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY); graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}