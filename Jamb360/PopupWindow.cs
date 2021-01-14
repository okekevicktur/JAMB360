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
    public partial class PopupWindow : Form
    {
        public PopupWindow()
        {
            InitializeComponent();
            if (English_Freebies.TotalQuest !=0  )
            {
                appendFreebies();
                English_Freebies.TotalQuest = 0;
                English_Freebies.points = 0;
            }
            else
            {
                append();
            }
           
        }
        public void append()
        {
            quickmathsBox.Visible = true;
            freebiesBox.Visible = false;
            diffLevel.Text += " " + QuickMaths.difficulty;
            TotQuestAns.Text += " " + QuickMaths.CorrectAns.ToString();
            timeTaken.Text += " " + QuickMaths.sty + " secs";
            if (QuickMaths.CorrectAns == 0)
            {
                AvgresponsTime.Text += " Infinite Time";
            }
            else
            {
                AvgresponsTime.Text += " " + (Convert.ToInt32(QuickMaths.sty) / QuickMaths.CorrectAns).ToString() + ".00 secs";                
            }

        }
        public void appendFreebies()
        {
            quickmathsBox.Visible = false;
            freebiesBox.Visible = true;
            labTotQust.Text += " "+ (English_Freebies.TotalQuest).ToString();
            totPts.Text += (English_Freebies.points).ToString();
       }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();     
        } 
    }
}
