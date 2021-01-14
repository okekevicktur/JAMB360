using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jamb360
{
    public partial class QuickMaths : Form
    {
        //Variables declaration and initialization
        Random random1 = new Random(); double result; int timeleft;
        public static string sty;
        public static string difficulty; public static int CorrectAns = 0;
        public static bool settingSensor = false; int Leftnum = 0; int RightNum = 0;

        public QuickMaths()
        {
            InitializeComponent();
            retrieveSettings();
        }

        #region fUNCTIONS DEFINITION
        /// <summary>
        /// fUNCTIONS DEFINITION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        //function to retrieve inbuilt variables saved into the app
        private void retrieveSettings()
        {
            sty = Properties.Settings.Default.TimeLimit;
            labelTime.Text = sty + " " + "secs";
            difficulty = Properties.Settings.Default.Difficulty;
        }
        private double RandExpress()
        {

            int mathOperator = random1.Next(1, 5);//gives value of one to 4
            //int Leftnum= random1.Next(1,60); int RightNum= random1.Next(1, 90);
            switch (mathOperator)
            {
                case 1:
                    difficultyCheck();
                    result = Leftnum + RightNum;
                    label1.Text = String.Format("{0} + {1} = ?", Leftnum, RightNum);
                    break;
                case 2:
                    difficultyCheck();
                    result = Leftnum - RightNum;
                    label1.Text = String.Format("{0} - {1} = ?", Leftnum, RightNum);
                    break;
                case 3:
                    difficultyCheck();
                    result = Leftnum * RightNum;
                    label1.Text = String.Format("{0} * {1} = ?", Leftnum, RightNum);
                    break;
                case 4:
                    difficultyCheck();
                    result = Leftnum / RightNum;
                    label1.Text = String.Format("{0} / {1} = ?", Leftnum, RightNum);
                    break;
                default:
                    break;
            }
            return result;
        }
        private void difficultyCheck()
        {
            switch (difficulty)
            {
                case "Easy":
                    Leftnum = random1.Next(1, 8); RightNum = random1.Next(1, 15);
                    break;
                case "Medium":
                    Leftnum = random1.Next(1, 30); RightNum = random1.Next(1, 45);
                    break;
                case "Hard":
                    Leftnum = random1.Next(1, 60); RightNum = random1.Next(1, 90);
                    break;
                default:
                    break;
            }
        }
        private void flashText()
        {

            int one = random1.Next(150, 255);
            //int two = rand.Next(0, 2);
            //int three = rand.Next(0, 2);
            //int f0ur = rand.Next(0, 2);

            btnPlay.BackColor = Color.FromArgb(50, one, 50);
            btnPlay.ForeColor = Color.FromArgb(34, one, 34);
            // lblSec.ForeColor = Color.FromArgb(one, 0, 0);
        }
        #endregion
        private void btnPlay_Click(object sender, EventArgs e)
        {
            CorrectAns = 0;
            questBox.Visible = true;
            retrieveSettings();
            timer2.Enabled = false;
            btnPlay.Enabled = false;
            labInstruct.Visible = true;
            timeleft = Convert.ToInt32(Properties.Settings.Default.TimeLimit);
            //start the timer
            timer1.Start();
            RandExpress();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            settingSensor = true;
            labelTime.Text = sty + " " + "secs";
            bunifuMaterialTextbox1.Text = string.Empty;
            QuickMaths_Settings QMSet = new QuickMaths_Settings();
            QMSet.ShowDialog();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                labelTime.Text = timeleft.ToString() + " " + "secs";
            }
            else
            {

                timer1.Stop();
                PopupWindow pop = new PopupWindow();
                DialogResult dialog = pop.ShowDialog();
                if (dialog == DialogResult.Retry)
                {
                    string s = Properties.Settings.Default.TimeLimit + " secs";
                    labelTime.Text = s;
                    timeleft = Convert.ToInt32(Properties.Settings.Default.TimeLimit);
                    //start the timer
                    timer1.Start();
                    btnPlay.Enabled = false;
                    RandExpress();
                }
                labelTime.Text = "00 secs";
                btnPlay.Enabled = true;
                bunifuMaterialTextbox1.Text = string.Empty;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            flashText();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == result.ToString())
            {
                bunifuMaterialTextbox1.Text = string.Empty;
                CorrectAns++;
                RandExpress();
            }
            else
            {

            }
        }

        private void QuickMaths_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the quiz?", " Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Close();
            }
            else
            {

                return;
            }
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChar = "-";
            if (!(allowedChar.Contains(e.KeyChar))&& !char.IsNumber(e.KeyChar) == true && (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
               
            }
            else
            {
                //updateBal();

            }
            
        }
    }
}
