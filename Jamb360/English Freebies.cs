using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jamb360
{
    public partial class English_Freebies : Form
    {
        public static int TotalQuest; public static bool settingSensor= false;
        public English_Freebies()
        {
            InitializeComponent();


            

        }
       private void generalcruise()
        {
            timeleft = 10;
            digitalGauge1.Value = timeleft.ToString();
            // labelTime.Text = s;
            
            TotalQuest = Properties.Settings.Default.freebiesQuestCount;
            //OptnA.ForeColor = Color.Black; OptnB.IdleForecolor = Color.White; OptnC.IdleForecolor = Color.White; OptnD.IdleForecolor = Color.White;
            //first set
            randomMainStartUpFunct();
            //start the timer
            timer1.Enabled = true;
            timer1.Start();
            //timeleft = 10;
            //digitalGauge1.Value = timeleft.ToString();
            //randomMainStartUpFunct();
            //timer1.Start();
        }
        int timeleft; public static string sty="10";
        SQLiteConnection con = new SQLiteConnection(@"Data Source=.\Jamb_360.db; Version= 3;");

        Random rd = new Random();
        List<Int32> IdiomsCache = new List<Int32>(4); int RandOptn1;
        int RandOptn2; int RandOptn3; int RandOptn4;
        List<Int32> AntonymCache = new List<Int32>(4);
        List<Int32> SynonymCache = new List<Int32>(4);
        public static int counter = 0;
        public static int points = 0;
        List<Int32> randMain = new List<Int32>(5); 
        string ans = string.Empty, second = string.Empty, third = string.Empty, fourth = string.Empty;
        private void randomMainStartUpFunct()
        {

            // Create a random number between 1 to 3 which signifies antonym, Idioms and Synonyms respectively
            randMain.Clear();
            randMain.Add(rd.Next(1, 3));
          
            if (counter < TotalQuest) 
            {
                OptnA.IdleFillColor = Color.White;
                OptnB.IdleFillColor = Color.White;
                OptnC.IdleFillColor = Color.White;
                OptnD.IdleFillColor = Color.White;
                switch (randMain[0])
                {
                    case 1:

                        NewSetofRandomWords("ANTONYMS");

                        break;
                    case 2:
                        NewSetofRandomWords("IDIOMS");
                        break;
                    case 3:
                        NewSetofRandomWords("SYNONYM");
                        break;
                }
                counter++; labCount.Text = counter + "/" + TotalQuest;
            }
          
        }
        private void NewSetofRandomWords( string figureOfSpeech )
        {
            if (figureOfSpeech == "ANTONYMS")
            {
                AntonymCache.Clear();
                for (int i = 0; i < 4; i++)
                {
                    AntonymCache.Add(rd.Next(1, 263));

                }
              
                    dbQuery(figureOfSpeech, AntonymCache, txtNewQuest, NewWord, "ANTONYM");                    


            }
            else if (figureOfSpeech == "IDIOMS")
            {
                IdiomsCache.Clear();
                for (int i = 0; i < 4; i++)
                {
                    IdiomsCache.Add(rd.Next(1, 81));

                }
              
                dbQuery("IDIOMS", IdiomsCache, txtNewQuest, NewWord, "IDIOMS");
            }
            else
            {
                SynonymCache.Clear();
                for (int i = 0; i < 4; i++)
                {
                    SynonymCache.Add(rd.Next(1, 149));
                }
                dbQuery("SYNONYM", SynonymCache, txtNewQuest, NewWord, "SYNONYM");
            }
                          
        }

        private void optnRand(string figureOfSpeech, string optnMain, string optn2, string optn3, string optn4)
        {
           int optnRandCache;// = new List<int>(4);

         
              
                    optnRandCache= rd.Next(0, 3);

             
                switch (optnRandCache)
                {
                    case 0:
                        //string optnMain = "ANTONYMS";
                        OptnA.ButtonText = optnMain;
                        OptnB.ButtonText = optn2;
                        OptnC.ButtonText = optn3;
                        OptnD.ButtonText = optn4;
                       // NewSetofRandomWords("ANTONYMS");

                        break;
                    case 1:
                        OptnA.ButtonText = optn2;
                        OptnC.ButtonText = optn3;
                        OptnD.ButtonText = optn4;
                        OptnB.ButtonText = optnMain;
                        //NewSetofRandomWords("IDIOMS");
                        break;
                    case 2:
                         OptnA.ButtonText = optn2;
                         OptnC.ButtonText = optnMain;
                        OptnD.ButtonText = optn4;
                        OptnB.ButtonText = optn3;
                       // NewSetofRandomWords("SYNONYM");
                        break;
                    case 3:
                        OptnA.ButtonText = optn2;
                        OptnC.ButtonText = optn4;
                        OptnD.ButtonText = optnMain;
                        OptnB.ButtonText = optn3;
                        NewSetofRandomWords("SYNONYM");
                        break;
                }
                //foreach (int item in AntonymCache)
                //{
                //    dbQuery(figureOfSpeech, AntonymCache, txtNewQuest, NewWord, "ANTONYM");
                //}

            
        }
        private void dbQuery(string tableName, List<int> IndexMe, Label Questn, Label newWord, string colAns)
        {
            //return;

            string selectQuery = string.Format("Select * from {0} ", tableName);
            //  string selectQuery = string.Format("Select * from {0} Where ID = {1}", tableName, IndexMe);//Where ID= {1}", tableName, Index);
            SQLiteDataAdapter sda = new SQLiteDataAdapter(selectQuery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

           
   
            foreach (DataRow Item in dt.Rows)
            {
                int getId =Convert.ToInt32( Item["ID"]);
                //    int desiredID = Convert.ToInt32(getIdInNewTable);
                if (getId == IndexMe[0])
                {
                    Questn.Text = "Choose the correct " + tableName.ToLower() + " for the word:";
                    newWord.Text = Item["WORD"].ToString();
                     ans=Item[colAns].ToString();
                   
                }
                else  if (getId == IndexMe[1])
                {
                     second=Item[colAns].ToString();
                }
                else if (getId == IndexMe[2])
                {
                     third=Item[colAns].ToString();
                }else if (getId == IndexMe[3])
                {
                     fourth=Item[colAns].ToString();
                }
            }
             optnRand(tableName, ans, second, third, fourth);
            
          
                //dt.Rows[0][colAns].ToString();

        }
        int CountSyn = 1; int CountAnt = 1; int CountIdiom = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                digitalGauge1.Value = timeleft.ToString();// +" " + "secs";
            }
            else
            {
                timer1.Stop();
               
                if (counter < TotalQuest)
                {
                    status.Visible = false;
                    bringBkIdleForeCol();
                    generalcruise();
                }
                else
                {
                    PopupWindow pop = new PopupWindow();
                    DialogResult dialog = pop.ShowDialog();
                    if (dialog == DialogResult.Retry)
                    {
                       TotalQuest  = Properties.Settings.Default.freebiesQuestCount;
                       
                       
                        counter = 0;
                        points=0;
                        labPoints.Text = points.ToString();
                        status.Visible = false;
                        bringBkIdleForeCol();
                        generalcruise();
                      
                    }
                }
                
               // btnPlay.Enabled = true;
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

        
        private void Optns_Click(object sender, EventArgs e)
        {

            var butn = sender as BunifuThinButton2;
            var btnText = butn.ButtonText;
            for (int i = 1; i <= 4; i++)
            {
                 if (OptnA.IdleFillColor == Color.Red ||  OptnB.IdleFillColor== Color.Red || OptnC.IdleFillColor ==Color.Red || OptnD.IdleFillColor== Color.Red )
                    {
                       break;
                    }
                    else if ((OptnA.IdleFillColor == Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77))))) ||  OptnB.IdleFillColor== Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77))))) || OptnC.IdleFillColor ==Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77))))) || OptnD.IdleFillColor== Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))))))
                    {
                        
                        break;
                    }
                 else
                 {
                     if (btnText == ans)
                     {
                         //MessageBox.Show(btnText);
                         butn.IdleFillColor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));

                         butn.IdleForecolor = Color.White;

                         status.Visible = true;
                         status.ForeColor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
                         status.Text = "Correct";
                         status.Visible = true;
                         if (counter < TotalQuest)
                         {
                             points++;
                             labPoints.Text = points.ToString();
                         }
                         //randomMainStartUpFunct();
                        // butn.Focus();



                         break;
                     }
                     else
                     {

                         status.Visible = true;
                         status.ForeColor = Color.Red;
                         status.Text = "Wrong";
                         status.Visible = true;
                         butn.IdleFillColor = Color.Red;
                         butn.IdleForecolor = Color.White;
                         if (OptnA.ButtonText == ans)
                         {
                             OptnA.IdleFillColor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
                             OptnA.IdleForecolor = Color.White;
                             break;
                         }
                         else if (OptnB.ButtonText == ans)
                         {
                             OptnB.IdleFillColor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
                             OptnB.IdleForecolor = Color.White;
                             break;
                         }
                         else if (OptnC.ButtonText == ans)
                         {
                             OptnC.IdleFillColor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
                             OptnC.IdleForecolor = Color.White;
                             break;
                         }
                         else if (OptnD.ButtonText == ans)
                         {
                             OptnD.IdleFillColor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
                             OptnD.IdleForecolor = Color.White;
                             break;
                         }

                         // randomMainStartUpFunct();

                     }
                 }
               

            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            settingSensor = true;
            
            QuickMaths_Settings QMSet = new QuickMaths_Settings();
            QMSet.ShowDialog();
            counter = 0;
            points= 0;
            labPoints.Text = points.ToString();
            bringBkIdleForeCol();
            generalcruise();
        }
        private void bringBkIdleForeCol()
        {
            OptnA.IdleForecolor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            OptnB.IdleForecolor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            OptnC.IdleForecolor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            OptnD.IdleForecolor = Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77))))); 
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            digitalGauge1.Visible = true;
            generalcruise();
            panel3.Visible = true;
        }


    }
}
