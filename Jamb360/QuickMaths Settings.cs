using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace Jamb360
{
    public partial class QuickMaths_Settings : Form
    {
        public QuickMaths_Settings()
        {
            InitializeComponent();
            if (English_Freebies.settingSensor == true)
            {
                freebiesNoOfQuestn.Enabled = true;
                btnDiffLevel.Enabled= false;
                btnTimeLimit.Enabled= false;
                English_Freebies.settingSensor = false;
            }
            else
            {
                freebiesNoOfQuestn.Enabled = false;
                btnDiffLevel.Enabled = true;
                btnTimeLimit.Enabled = true;
               
            }

        }
        public void saveLimit( string L)
        {
            Properties.Settings.Default.TimeLimit = L;      
            Properties.Settings.Default.Save();
        }
        public void saveDiff(string diff)
        {        
            Properties.Settings.Default.Difficulty = diff;
            Properties.Settings.Default.Save();
        }
        public void saveQuestionNo(int QuestNo)
        {
            Properties.Settings.Default.freebiesQuestCount = QuestNo;
            Properties.Settings.Default.Save();
        }
      
        public void getlimit()
        {
            string limit = Properties.Settings.Default.TimeLimit;
         

            switch (limit)
            {
                case "30":
                    // menu item1 clicked .. do something 
                    //MessageBox.Show("CRK is Clicked");
                    radbut1.Checked = true;
                    break;

                case "40":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Mathematics is Clicked");
                    radbut2.Checked = true;
                    break;
                case "60":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Mathematics is Clicked");
                    radbut3.Checked = true;
                    break;
                

            }

            
        }
        public void getDiff()
        {
            string difficult = Properties.Settings.Default.Difficulty;
            switch (difficult)
            {
                case "Easy":
                    // menu item1 clicked .. do something 
                    //MessageBox.Show("CRK is Clicked");
                    radbut1.Checked = true;
                    break;

                case "Medium":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Mathematics is Clicked");
                    radbut2.Checked = true;
                    break;
                case "Hard":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Mathematics is Clicked");
                    radbut3.Checked = true;
                    break;
            }
        }
        public void getNoOfQuestion()
        {
            string questionsNo = (Properties.Settings.Default.freebiesQuestCount).ToString();
            switch (questionsNo)
            {
                case "5":
                    // menu item1 clicked .. do something 
                    //MessageBox.Show("CRK is Clicked");
                    radio5.Checked = true;
                    break;

                case "10":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Mathematics is Clicked");
                    rad10.Checked = true;
                    break;
                case "20":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Mathematics is Clicked");
                    rad20.Checked = true;
                    break;
            }
        }
         
        private void btnTimeLimit_Click(object sender, EventArgs e)
        {

            radbut1.Text = "30";
            radbut2.Text= "40";
            radbut3.Text = "60";
            panel3.Visible = true;
            getlimit();
            
           
        }

        //private void RadioItemClick(object sender, EventArgs e)
        //{
        //    var menuItem = sender as RadioButtonAdv; 
        //     var menuText = menuItem.Text;

        //        switch (menuText)
        //        {
        //            case "30":
        //                // menu item1 clicked .. do something 
        //                //MessageBox.Show("CRK is Clicked");
        //                MessageBox.Show("30");
        //                break;

        //            case "40":
        //                // menu item2 clicked .. do something 
        //                // MessageBox.Show("Mathematics is Clicked");
        //               // last50InVisible();
        //                break;
        //            case "60":
        //                // menu item2 clicked .. do something 
        //                MessageBox.Show("60");
        //               // last50InVisible();
        //                break;
                    
        //        }
        //}

        private void btnDiffLevel_Click(object sender, EventArgs e) 
        {
            
            radbut1.Text = "Easy";
            radbut2.Text = "Medium";
            radbut3.Text = "Hard";
            panel3.Visible = true;
            getDiff();
        }

        private void radbut1_CheckChanged(object sender, EventArgs e)
        {
            string menuText = radbut1.Text;
            if (radbut1.Checked== true && menuText== "30")
            {
                saveLimit(menuText);
            }
            else if (radbut1.Checked == true && menuText == "Easy")
            {
                saveDiff(menuText);
            }
            //switch (menuText)
            //{
            //    case "30":
            //        // menu item1 clicked .. do something 
            //        //MessageBox.Show("CRK is Clicked");
            //        //radbut1.Checked = true;
            //        saveLimit(menuText);
            //        break;

            //    case "Easy":
            //        // menu item2 clicked .. do something 
            //        // MessageBox.Show("Mathematics is Clicked");
            //        radbut1.Checked = true;
            //        saveDiff(menuText);
            //        break;
            //}
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void radbut2_CheckChanged(object sender, EventArgs e)
        {
            string menuText = radbut2.Text;
            if (radbut2.Checked == true && menuText == "40")
            {
                saveLimit(menuText);
            }
            else if (radbut2.Checked == true && menuText == "Medium")
            {
                saveDiff(menuText);
            }
            //var menuText = radbut2.Text;

            //switch (menuText)
            //{
            //    case "40":
            //        // menu item1 clicked .. do something 
            //        //MessageBox.Show("CRK is Clicked");
            //        radbut2.Checked = true;
            //        saveLimit(menuText);
            //        break;

            //    case "Easy":
            //        // menu item2 clicked .. do something 
            //        // MessageBox.Show("Mathematics is Clicked");
            //        radbut2.Checked = true;
            //        saveDiff(menuText);
            //        break;
            //}
        }

        private void radbut3_CheckChanged(object sender, EventArgs e)
        {
            string menuText = radbut3.Text;
            if (radbut3.Checked == true && menuText == "60")
            {
                saveLimit(menuText);
            }
            else if (radbut3.Checked == true && menuText == "Hard")
            {
                saveDiff(menuText);
            }
            //var menuText = radbut3.Text;

            //switch (menuText)
            //{
            //    case "60":
            //        // menu item1 clicked .. do something 
            //        //MessageBox.Show("CRK is Clicked");
            //        radbut3.Checked = true;
            //        saveLimit(menuText);
            //        break;

            //    case "Hard":
            //        // menu item2 clicked .. do something 
            //        // MessageBox.Show("Mathematics is Clicked");
            //        radbut3.Checked = true;
            //        saveDiff(menuText);
            //        break;
            //}
        }

        private void freebiesNoOfQuestn_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
            panel4.BringToFront();
            getNoOfQuestion();
        }

        private void radio5_CheckChanged(object sender, EventArgs e)
        {
            string menuText = radio5.Text;
            saveQuestionNo(Convert.ToInt32( menuText));
             
        }

        private void rad10_CheckChanged(object sender, EventArgs e)
        {
            string menuText = rad10.Text;
            saveQuestionNo(Convert.ToInt32(menuText));
             
        }

        private void rad20_CheckChanged(object sender, EventArgs e)
        {
            string menuText = rad20.Text;
            saveQuestionNo(Convert.ToInt32(menuText));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
