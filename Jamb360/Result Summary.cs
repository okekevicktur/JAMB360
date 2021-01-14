using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace Jamb360
{
    public partial class Result_Summary : Form
    {
        public Result_Summary()
        {
            InitializeComponent();
        }
        int left = 100; int spacing = 0;
        private void Result_Summary_Load(object sender, EventArgs e)
        {
            int countMe = 0;
            if (Subject_Combo.Scorecard.Count != 0 )
            {
                
                for (int i = 0; i < Subject_Combo.Scorecard.Count; i++)
                {
                    countMe++;
                    BunifuCircleProgress bunprog = new BunifuCircleProgress();
                    bunprog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    bunprog.Location = new Point((countMe * left) + spacing, 60);
                    //Left     |||||||     Top
                    spacing += 200;
                    bunprog.Value = Subject_Combo.Scorecard[i];
                    bunprog.ProgressColor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77))))); bunprog.Anchor = AnchorStyles.Top;
                    bunprog.SuperScriptText = Subject_Combo.percentage[i] + "%";
                    bunprog.Size = new System.Drawing.Size(250, 250);
                    bunprog.Text = Subject_Combo.results[i] + ": " + Subject_Combo.Scorecard[i] + "/" + Subject_Combo.TotalQuest[i];
                    panel1.Controls.Add(bunprog);
                }

                Subject_Combo.Scorecard.Clear();
            }
            else
            {
              
                countMe++;
                BunifuCircleProgress bunprog2 = new BunifuCircleProgress();
                bunprog2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                spacing += 420;
                bunprog2.Location = new Point((countMe * left) + spacing, 60);
                //Left     |||||||     Top
               // spacing += 200;
                bunprog2.Value = CBT_By_Topic.Scorecard;
                bunprog2.ProgressColor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77))))); 
                bunprog2.Anchor = AnchorStyles.Top;
                bunprog2.SuperScriptText = CBT_By_Topic.percentage + "%";
                bunprog2.Size = new System.Drawing.Size(353, 253);
                bunprog2.Text = CBT_By_Topic.subName + " " + CBT_By_Topic.yearQuest + ": " + CBT_By_Topic.Scorecard + "/" + CBT_By_Topic.TotalQuest;
                panel1.Controls.Add(bunprog2);
           }
          
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

        private void btnProceed_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Subject_Combo sbj = new Subject_Combo();
            //sbj.Show();
        }
    }
}
