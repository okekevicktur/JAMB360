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
using System.Data.SQLite;
using System.IO;
using System.Collections;
using System.Collections.Specialized;
using Bunifu.UI.WinForms.BunifuButton;
using System.Text.RegularExpressions;

namespace Jamb360
{
    public partial class Subject_Combo : Form
    {
         
        public Subject_Combo()
        {
            InitializeComponent();
        }

        public int seconds =0; public int minutes= 0; public int hours=2; public bool paused;
        int counterMaths=0; int counterCRK = 0; int counterBio = 0; int counterChem = 0; int counterEco = 0;
        int counterGovt = 0; int counterLit = 0; int counterPhy = 0; int counterEng = 0;
        string nameT; string firstsub; string v; string storeSub; string realSub; int loop;
        WaitFormFunct waitform = new WaitFormFunct();
      
        SQLiteConnection con = new SQLiteConnection(@"Data Source=.\Jamb_360.db; Version= 3;");
        
       
        public static List<String> results = new List<String>(9);
        List<String> Optnscrk = new List<String>(50);
        public static List<Int32> Scorecard = new List<Int32>(4);
        public static List<String> TotalQuest = new List<String>(4);
        public static List<String> percentage =  new List<String>(4);
        private void btnMaths_Click(object sender, EventArgs e)
        {
            if (panel4.Visible != true )
            {
                sidePanel.Height = btnMaths.Height;
                sidePanel.Top = btnMaths.Top;
                sidePanel.Visible = true;
                if (btnMaths.IconRightVisible != true)
                {
                    btnMaths.IconRightVisible = true;
                    // to add a specific value to your array
                    results.Add(btnMaths.Text);
                    //currentIndex++;

                }
                else
                {
                    btnMaths.IconRightVisible = false;
                    // to remove a specific value from your array
                    results.Remove(btnMaths.Text);
                }
            }

           
        }

        private void btnCrk_Click(object sender, EventArgs e)
        {
            if (panel4.Visible != true)
            {

                sidePanel.Height = btnCrk.Height;
                sidePanel.Top = btnCrk.Top;
                sidePanel.Visible = true;
                if (btnCrk.IconRightVisible != true)
                {
                    btnCrk.IconRightVisible = true;
                    // to add a specific value to your array
                    results.Add(btnCrk.Text);
                    //currentIndex++;
                }
                else
                {
                    btnCrk.IconRightVisible = false;
                    //currentIndex--;
                    results.Remove(btnCrk.Text);
                }
            }
        }

        private void btnLitinEng_Click(object sender, EventArgs e)
        {
            if (panel4.Visible != true)
            {

                sidePanel.Height = btnLitinEng.Height;
                sidePanel.Top = btnLitinEng.Top;
                sidePanel.Visible = true;
                if (btnLitinEng.IconRightVisible != true)
                {
                    btnLitinEng.IconRightVisible = true;
                    // to add a specific value to your array
                    results.Add(btnLitinEng.Text);
                }
                else
                {
                    btnLitinEng.IconRightVisible = false;
                    results.Remove(btnCrk.Text);
                }
            }
        }

        private void btnBio_Click(object sender, EventArgs e)
        {
            if (panel4.Visible != true)
            {

                sidePanel.Height = btnBio.Height;
                sidePanel.Top = btnBio.Top;
                sidePanel.Visible = true;
                if (btnBio.IconRightVisible != true)
                {
                    btnBio.IconRightVisible = true;
                    // to add a specific value to your array
                    results.Add(btnBio.Text);
                }
                else
                {
                    btnBio.IconRightVisible = false;
                    results.Remove(btnBio.Text);
                }
            }
        }

        private void btnPhy_Click(object sender, EventArgs e)
        {
            if (panel4.Visible != true)
            {

                sidePanel.Height = btnPhy.Height;
                sidePanel.Top = btnPhy.Top;
                sidePanel.Visible = true;
                if (btnPhy.IconRightVisible != true)
                {
                    btnPhy.IconRightVisible = true;
                    // to add a specific value to your array
                    results.Add(btnPhy.Text);
                }
                else
                {
                    btnPhy.IconRightVisible = false;
                    results.Remove(btnPhy.Text);
                }
            }
        }

        private void btnChem_Click(object sender, EventArgs e)
        {
            if (panel4.Visible != true)
            {

                sidePanel.Height = btnChem.Height;
                sidePanel.Top = btnChem.Top;
                sidePanel.Visible = true;
                if (btnChem.IconRightVisible != true)
                {
                    btnChem.IconRightVisible = true;
                    // to add a specific value to your array
                    results.Add(btnChem.Text);
                }
                else
                {
                    btnChem.IconRightVisible = false;
                    results.Remove(btnChem.Text);
                }
            }
        }

        private void btnEcons_Click(object sender, EventArgs e)
        {
            if (panel4.Visible != true)
            {

                sidePanel.Height = btnEcons.Height;
                sidePanel.Top = btnEcons.Top;
                sidePanel.Visible = true;
                if (btnEcons.IconRightVisible != true)
                {
                    btnEcons.IconRightVisible = true;
                    // to add a specific value to your array
                    results.Add(btnEcons.Text);
                }
                else
                {
                    btnEcons.IconRightVisible = false;
                    results.Remove(btnEcons.Text);
                }
            }
        }

        private void btnEngl_Click(object sender, EventArgs e)
        {
            if (panel4.Visible != true)
            {

                sidePanel.Height = btnEngl.Height;
                sidePanel.Top = btnEngl.Top;
                sidePanel.Visible = true;
                if (btnEngl.IconRightVisible != true)
                {
                    btnEngl.IconRightVisible = true;
                    // to add a specific value to your array
                    results.Add(btnEngl.Text);
                }
                else
                {
                    btnEngl.IconRightVisible = false;
                    results.Remove(btnEngl.Text);
                }
            }
        }

        private void btnGovt_Click(object sender, EventArgs e)
        {
            if (panel4.Visible != true)
            {

                sidePanel.Height = btnGovt.Height;
                sidePanel.Top = btnGovt.Top;
                sidePanel.Visible = true;
                if (btnGovt.IconRightVisible != true)
                {
                    btnGovt.IconRightVisible = true;
                    // to add a specific value to your array
                    results.Add(btnGovt.Text);
                }
                else
                {
                    btnGovt.IconRightVisible = false;
                    results.Remove(btnGovt.Text);
                }
            }
        }

       
        //This function activates the dynamic creation of MenuStrip and loads the first subject from the m,enu strip for the user
        private void ProceedFunct()
        {
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            panel4.Visible = true;
            panel1.Visible = true;
            qstions.Visible = true;
            firstsub = results.First();
            // string toDisplay = string.Join(Environment.NewLine, results);
            menuStrip1.Items.Clear();
            foreach (string name in results)
            {
                ToolStripItem subItem = new ToolStripMenuItem(name);
                subItem.Click += new EventHandler(subItemClick);
                menuStrip1.Items.Add(subItem);
            }
            timer1.Enabled = true;

            int i = 0;
            v = capitalizeSub(firstsub) + drpYear.Text;
            nameT = capitalizeSub(firstsub);

            string selectQuery = string.Format("Select * from {0} where ID='" + 1 + "' ", v);
            SQLiteDataAdapter sda = new SQLiteDataAdapter(selectQuery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            // int i = dt.Rows.Count;
            string selectQuery1 = string.Format("Select * from {0}", v);// where id='" + counterMaths + "' ", v);
            SQLiteDataAdapter sda1 = new SQLiteDataAdapter(selectQuery1, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            i = dt1.Rows.Count;
            firstSubject();
            extractAnswerScore();
            //results.Clear();
            iconInv();
            v = string.Empty;
        }

        //this function converts byte images to stream
        public Image byteArrayToImage(byte[] byt)
        {
            try
            {
                System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                Image img = (Image)converter.ConvertFrom(byt);

                return img;
          
                //using (MemoryStream mstream = new MemoryStream(byt))
                //{
                //    return Image.FromStream(mstream);
                //}
            }
            catch (Exception )
            {
               // MessageBox.Show(ex.Message);
                throw;
            }
         
        }

        private string regexOpx(string txthere)
        {
            string patternSup = "<sup>(.*?)</sup>";
            string patternSub = "<sub>(.*?)</sub>";
            string patternbr = "(?<=>)(.*)(?=<)";
            //var b = Regex.Match(a, "(?<=>)(.*)(?=<)");
            //Console.WriteLine(b.Value);
            string matched = "";
            var match = Regex.Match(txthere, patternSup, RegexOptions.IgnoreCase);
            if (match.Value == "0")
            {
                MessageBox.Show("na zeroooo");
            }
            string enc = "\xB" + matched;
            if (match.Value == "<sup>0</sup>" || match.Value == "<SUP>0</SUP>")
            {
                var waito = Regex.Replace(txthere, patternSup, "\u2070", RegexOptions.IgnoreCase);
                var result = HtmlTransformer.ConvertHtml(waito);
                return result;
            }
            else
            {
                var result = HtmlTransformer.ConvertHtml(txthere);
                return result;
            }
           
           
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (panel4.Visible != true)
            {

                if (drpYear.SelectedIndex != -1 && results.Count != 0)
                {
                    if (results.Count > 4)
                    {
                        MessageBox.Show("Please Make sure you select Four (4) subject combination of Choice?", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (results.Count <= 4 && btnEngl.IconRightVisible == true)
                    {
                        if (results.Count == 4)
                        {
                            hours = 2; minutes = 10; seconds = 0;
                        }
                        else if (results.Count == 3)
                        {
                            hours = 1; minutes = 40; seconds = 0;
                        }
                        else if (results.Count == 2)
                        {
                            hours = 1; minutes = 10; seconds = 0;
                        }
                        else if (results.Count == 1)
                        {
                            hours = 0; minutes = 40; seconds = 0;
                        }


                    }
                    else if (results.Count <= 4 && btnEngl.IconRightVisible == false)
                    {
                        if (results.Count == 4)
                        {
                            hours = 2; minutes = 0; seconds = 0;
                        }

                        else if (results.Count == 3)
                        {
                            hours = 1; minutes = 30; seconds = 0;
                        }
                        else if (results.Count == 2)
                        {
                            hours = 1; minutes = 0; seconds = 0;
                        }
                        else if (results.Count == 1)
                        {
                            hours = 0; minutes = 30; seconds = 0;
                        }

                    }
                    //btnProceed.Enabled = false;   
                    waitform.Show(this);
                    ProceedFunct();
                    drpYear.Enabled = false;
                    waitform.Close();
                    
                }
                else
                {
                    if (drpYear.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please Make sure you select the Year of Choice?", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (results.Count == 0)
                    {
                        MessageBox.Show("Please Make sure you select the Subject of Choice?", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        //Turns the last 50 buttons to visible in asmuch as its English Language
        private void last50Visible()
        {
           // Bunifu.UI.WinForms.BunifuButton.BunifuButton
            //Panel pn = find
            foreach ( Control c in panel1.Controls)
            {
                if (c is  Button)
                {
                   
                    Button bun = c as Button;
                    for (int i = 51; i <= 100; i++)
                    {
                        if (bun.Text == i.ToString())
                        {
                            bun.Visible = true;
                        }
                    }
                }
            }
        }
       
        //Turns the last 50 buttons to invisible in asmuch as its not English Language
        private void last50InVisible()
        {
            // Bunifu.UI.WinForms.BunifuButton.BunifuButton
            //Panel pn = find
            foreach (Control c in panel1.Controls)
            {
                if (c is Button)
                {
                    Button bun = c as Button;
                    for (int i = 51; i <= 100; i++)
                    {
                        if (bun.Text == i.ToString())
                        {
                            bun.Visible = false;
                        }
                    }
                }
            }
        }
              
        //This Capitalizes each Subject Name
        private string capitalizeSub( string sub)
        {

            switch (sub)
            {
                case "CRK":
                    // menu item1 clicked .. do something 
                    //MessageBox.Show("CRK is Clicked");
                    realSub = "CRK".ToUpper();
                   
                    break;

                case "Mathematics":
                    // menu item2 clicked .. do something 
                    
                    realSub = "Mathematics".ToUpper();
                    break;
                case "Literature in English":
                    // menu item2 clicked .. do something 
                    realSub = "Literature_in_English".ToUpper();
                    break;
                case "Physics":
                    // menu item2 clicked .. do something 
                   
                    realSub = "Physics".ToUpper();
                    break;
                case "Chemistry":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Chemistry is Clicked");
                    realSub = "Chemistry".ToUpper();
                    break;
                case "Biology":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Biology is Clicked");
                    realSub = "Biology".ToUpper();
                    break;
                case "Economics":
                    // menu item2 clicked .. do something 
                    //MessageBox.Show("Economics is Clicked");
                    realSub = "Economics".ToUpper();
                    break;
                case "Government":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Government is Clicked");
                    realSub = "Government".ToUpper();
                    break;
                case "Use of English":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Use of English is Clicked");
                    realSub = "Use_of_English".ToUpper();
                    break;

            } return realSub;
        }


        //This checks the particular counter based on the clicked subject
        //then retrieves the question for the user
        private void getQuestBasedOnCounter (int counter)
        {
           
              //  #region
                string selectQuery = string.Format("Select * from {0} where ID='" + counter + "' ", v);
               // MessageBox.Show(counter.ToString());
                SQLiteDataAdapter sda = new SQLiteDataAdapter(selectQuery, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                // int i = dt.Rows.Count;
                string selectQuery1 = string.Format("Select * from {0}", v);// where id='" + counterMaths + "' ", v);
                SQLiteDataAdapter sda1 = new SQLiteDataAdapter(selectQuery1, con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                int i = dt1.Rows.Count;
                qstNo.Text = string.Format("Questions {0} of {1}", counter, i);
                if (counter <= i)
                {
                    qstNo.Text = string.Format("Questions {0} of {1}", counter, i);
                    byte[] image = new byte[0];
                    //  string instruct = item["EXAM_INSTRUCTION"].ToString();
                    string instruct = dt.Rows[0]["EXAM_INSTRUCTION"].ToString();
                    string comprehense = dt.Rows[0]["COMPREHENSION_QUESTION"].ToString();

                    if (instruct == string.Empty)
                    {
                        //panel5.Controls.Remove(QuestionsInstr);
                        //panel5.Controls.Remove(QuestionsInstr);
                        QuestionsInstr.Visible = false;
                    }
                    else
                    {
                        QuestionsInstr.DocumentText = instruct;
                        QuestionsInstr.Visible = true;
                    }
                    txtComprehension.DocumentText = comprehense;
                    //coverts the blob field to object, So I can compare if the field is empty
                    object chk = (dt.Rows[0]["QUESTION_IMAGE"]);
                    if (chk is System.DBNull)
                    {
                        pictureBox1.Visible = false;
                    }
                    else if (chk.ToString() == string.Empty)
                    {
                        pictureBox1.Visible = false;
                    }
                    else if (chk.ToString() == null)
                    {
                        pictureBox1.Visible = false;
                    }
                    else
                    {
                        Type datatype = (dt.Rows[0]["QUESTION_IMAGE"]).GetType();
                        if (datatype == typeof(string))
                        {
                            //image = (byte[])(dt.Rows[0]["QUESTION_IMAGE"]);
                            //if (!DBNull.Value.Equals((dt.Rows[0]["QUESTION_IMAGE"])))
                            //{
                            //    Image img = byteArrayToImage(image);
                            //    pictureBox1.Image = img;
                            //    pictureBox1.Visible = true;
                            //    //not null
                            //}
                        }
                        else if (datatype == typeof(byte[]))
                        {
                            image = (byte[])(dt.Rows[0]["QUESTION_IMAGE"]);
                            if (!DBNull.Value.Equals((dt.Rows[0]["QUESTION_IMAGE"])))
                            {
                                  Image img = byteArrayToImage(image);
                                pictureBox1.Image = img;
                                pictureBox1.Visible = true;
                                //not null
                            }
                            else
                            {
                              
                                //column has data
                                //null
                            }
                
                        }


                    }

                    qstions.DocumentText = dt.Rows[0]["QUESTION"].ToString();
                    string optA = dt.Rows[0]["OPTION_A"].ToString();
                    string optB = dt.Rows[0]["OPTION_B"].ToString();
                    string optC = dt.Rows[0]["OPTION_C"].ToString();
                    string optD = dt.Rows[0]["OPTION_D"].ToString();

                    optn1.Text = "A. " + regexOpx(optA);
                    optn2.Text = "B. " + regexOpx(optB);
                    optn3.Text = "C. " + regexOpx(optC);
                    optn4.Text = "D. " + regexOpx(optD);
                    CorrectAns.Text = "Correct answer: "+ dt.Rows[0]["CORRECT_OPTION"].ToString();
                    ExplanationPanel.DocumentText = dt.Rows[0]["CORRECT_ANS"].ToString();
                }
        }
        int countSub;
        //This checks the particular counter based on the clicked subject
        //then increases the particular counter
        private int increaseCounterBasedOnSubjectName()
        {
           
            if (nameT == "CRK")
            {
                counterCRK += 1;
                countSub = counterCRK;
                getQuestBasedOnCounter(counterCRK);
              
            }
            else if (nameT == "MATHEMATICS")
            {
                counterMaths += 1;
                countSub = counterMaths;
                getQuestBasedOnCounter(counterMaths);
            }
            else if (nameT == "BIOLOGY")
            {
                counterBio += 1;
                countSub = counterBio;
                getQuestBasedOnCounter(counterBio);
            }
            else if (nameT == "CHEMISTRY")
            {
                counterChem += 1;
                countSub = counterChem;
                getQuestBasedOnCounter(counterChem);
            }
            else if (nameT == "ECONOMICS")
            {
                counterEco += 1;
                countSub = counterEco;
                getQuestBasedOnCounter(counterEco);
            }
            else if (nameT == "GOVERNMENT")
            {
                counterGovt += 1;
                countSub = counterGovt;
                getQuestBasedOnCounter(counterGovt);
            }
            else if (nameT == "PHYSICS")
            {
                counterPhy += 1;
                countSub = counterPhy;
                getQuestBasedOnCounter(counterPhy);
            }
            else if (nameT == "LITERATURE_IN_ENGLISH")
            {
                counterLit += 1;
                countSub = counterLit;
                getQuestBasedOnCounter(counterLit);
            }
            else if (nameT == "USE_OF_ENGLISH")
            {
                counterEng += 1;
                countSub = counterEng;
                getQuestBasedOnCounter(counterEng);
            }
            loop = countSub;
            return countSub;
   
        }

        //This checks the particular counter based on the clicked subject
        //then decreases the particular counter when the prev buttion is clicked
        private void decreaseCounterBasedOnSubjectName()
        {
            if (nameT == "CRK")
            {
                if (counterCRK == 0)
                {
                    getQuestBasedOnCounter(1);
                }
                else
                {
                    counterCRK -= 1;
                    getQuestBasedOnCounter(counterCRK);
         
                }
               
            }
            else if (nameT == "MATHEMATICS")
            {
                if (counterMaths == 0)
                {
                    getQuestBasedOnCounter(1);
                }
                else
                {
                    counterMaths -= 1;
                    getQuestBasedOnCounter(counterMaths);

                }
               
            }
            else if (nameT == "BIOLOGY")
            {
                if (counterBio == 0)
                {
                    getQuestBasedOnCounter(1);
                }
                else
                {
                    counterBio -= 1;
                    getQuestBasedOnCounter(counterBio);
                }
            }
            else if (nameT == "CHEMISTRY")
            {
                if (counterChem == 0)
                {
                    getQuestBasedOnCounter(1);
                }
                else
                {
                    counterChem -= 1;
                    getQuestBasedOnCounter(counterChem);
                }
            }
            else if (nameT == "ECONOMICS")
            {
                if (counterEco == 0)
                {
                    getQuestBasedOnCounter(1);
                }
                else
                {
                    counterEco -= 1;
                    getQuestBasedOnCounter(counterEco);
                }
            }
            else if (nameT == "GOVERNMENT")
            {
                if (counterGovt == 0)
                {
                    getQuestBasedOnCounter(1);
                }
                else
                {
                    counterGovt -= 1;
                    getQuestBasedOnCounter(counterGovt);
                }
            }
            else if (nameT == "PHYSICS")
            {
                if (counterPhy == 0)
                {
                    getQuestBasedOnCounter(1);
                }
                else
                {
                    counterPhy -= 1;
                    getQuestBasedOnCounter(counterPhy);
                }
            }
            else if (nameT == "LITERATURE_IN_ENGLISH")
            {
                if (counterLit == 0)
                {
                    getQuestBasedOnCounter(1);
                }
                else
                {
                    counterLit -= 1;
                    getQuestBasedOnCounter(counterLit);
                }
            }
            else if (nameT == "USE_OF_ENGLISH")
            {
                if (counterEng == 0)
                {
                    getQuestBasedOnCounter(1);
                }
                else
                {
                    counterEng -= 1;
                    getQuestBasedOnCounter(counterEng);
                }
            }
           
           
        }

        private void RestoreAllCounter()
        {
            counterCRK = 1;      counterMaths = 1;           
           counterBio = 1;       counterChem = 1;
           counterEco = 1;       counterGovt = 1;  counterPhy = 1;
           counterLit = 1;       counterEng = 1;
        }
        //This checks the first subject selected when the proceed button is clicked
        //then retrieves the first question for the user
        private void getQuestBasedOnSubjectSelected()
        {
            if (nameT == "CRK")
            {
               // counterCRK += 1;
                getQuestBasedOnCounter(counterCRK);
              
            }
            else if (nameT == "MATHEMATICS")
            {
                //counterMaths += 1;
                getQuestBasedOnCounter(counterMaths);
            }
            else if (nameT == "BIOLOGY")
            {
                //counterBio += 1;
                getQuestBasedOnCounter(counterBio);
            }
            else if (nameT == "CHEMISTRY")
            {
               // counterChem += 1;
                getQuestBasedOnCounter(counterChem);
            }
            else if (nameT == "ECONOMICS")
            {
                //counterEco += 1;
                getQuestBasedOnCounter(counterEco);
            }
            else if (nameT == "GOVERNMENT")
            {
               // counterGovt += 1;
                getQuestBasedOnCounter(counterGovt);
            }
            else if (nameT == "PHYSICS")
            {
                //counterPhy += 1;
                getQuestBasedOnCounter(counterPhy);
            }
            else if (nameT == "LITERATURE_IN_ENGLISH")
            {
               // counterLit += 1;
                getQuestBasedOnCounter(counterLit);
            }
            else if (nameT == "USE_OF_ENGLISH")
            {
                //counterEng += 1;
                getQuestBasedOnCounter(counterEng);
            }
          
        }

        private void getQuestBasedOnFirstSubjectSelected()
        {
            if (nameT == "CRK")
            {
                // counterCRK += 1;
                getQuestBasedOnCounter(1);

            }
            else if (nameT == "MATHEMATICS")
            {
                //counterMaths += 1;
                getQuestBasedOnCounter(1);
            }
            else if (nameT == "BIOLOGY")
            {
                //counterBio += 1;
                getQuestBasedOnCounter(1);
            }
            else if (nameT == "CHEMISTRY")
            {
                // counterChem += 1;
                getQuestBasedOnCounter(1);
            }
            else if (nameT == "ECONOMICS")
            {
                //counterEco += 1;
                getQuestBasedOnCounter(1);
            }
            else if (nameT == "GOVERNMENT")
            {
                // counterGovt += 1;
                getQuestBasedOnCounter(1);
            }
            else if (nameT == "PHYSICS")
            {
                //counterPhy += 1;
                getQuestBasedOnCounter(1);
            }
            else if (nameT == "LITERATURE_IN_ENGLISH")
            {
                // counterLit += 1;
                getQuestBasedOnCounter(1);
            }
            else if (nameT == "USE_OF_ENGLISH")
            {
                //counterEng += 1;
                getQuestBasedOnCounter(1);
            }

        }
        //this retrieves the first question of the first subject 
        //and increase the counter by One
        private string firstSubject()
        {
            switch (firstsub)
            {
                case "CRK":
                    // menu item1 clicked .. do something 
                   
                    last50InVisible();
                    storeSub= "counterCRK";
                    if (counterCRK == 0)
                    {
                        counterCRK += 1;
                        countSub = counterCRK;
                    }

                    getQuestBasedOnFirstSubjectSelected();
                    break;

                case "Mathematics":
                   
                    last50InVisible();
                    storeSub= "counterMaths";
                    if (counterMaths == 0)
                    {
                        counterMaths += 1;
                        countSub = counterMaths;
                    }
                    //counterMaths += 1;
                    getQuestBasedOnFirstSubjectSelected();
                    break;
                case "Literature in English":
                   
                    last50InVisible();
                    storeSub = "counterLit";
                     if (counterLit == 0)
                    {
                        counterLit += 1;
                         countSub = counterLit;
                    }
                     getQuestBasedOnFirstSubjectSelected();
                    break;
                case "Physics":
                    // menu item2 clicked .. do something 
                    //MessageBox.Show("Physics is Clicked");
                    last50InVisible();
                    storeSub = "counterPhy";
                     if (counterPhy == 0)
                    {
                        counterPhy += 1;
                         countSub = counterPhy;
                    }
                   // v = nameofSub2(menuText) + drpYear.Text;
                     getQuestBasedOnFirstSubjectSelected();
                    break;
                case "Chemistry":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Chemistry is Clicked");
                    last50InVisible();
                     storeSub = "counterChem";
                     if (counterChem == 0)
                    {
                        counterChem += 1;
                         countSub = counterChem;
                    }
                   // v = nameofSub2(menuText) + drpYear.Text;
                     getQuestBasedOnFirstSubjectSelected();
                    break;
                case "Biology":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Biology is Clicked");
                    last50InVisible();
                    if (counterBio == 0)
                    {
                        counterBio += 1;
                        countSub =counterBio;
                    }
                   // v = nameofSub2(menuText) + drpYear.Text;
                    getQuestBasedOnFirstSubjectSelected();
                    break;
                case "Economics":
                    // menu item2 clicked .. do something 
                    //MessageBox.Show("Economics is Clicked");
                    last50InVisible();
                      if (counterEco == 0)
                    {
                        counterEco += 1;
                          countSub =counterEco;
                    }
                   // v = nameofSub2(menuText) + drpYear.Text;
                      getQuestBasedOnFirstSubjectSelected();
                    break;
                case "Government":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Government is Clicked");
                    last50InVisible();
                    if (counterGovt == 0)
                    {
                        counterGovt += 1;
                        countSub =counterGovt;
                    }
                   // v = nameofSub2(menuText) + drpYear.Text;
                    getQuestBasedOnFirstSubjectSelected();
                    break;
                case "Use of English":
                    // menu item2 clicked .. do something 
                    // MessageBox.Show("Use of English is Clicked");
                    last50Visible();
                    if (counterEng == 0)
                    {
                        counterEng += 1;
                        countSub =counterEng;
                    }
                   // v = nameofSub2(menuText) + drpYear.Text;
                    getQuestBasedOnFirstSubjectSelected();
                    break;
            }
            return storeSub;
        }

        // the dynamic event as of MenuStrip click below
         private void subItemClick(object sender, EventArgs e)
         {
                var menuItem = sender as ToolStripMenuItem; 
                var menuText = menuItem.Text;
            
                switch(menuText)
                {
                    case "CRK":
                       // menu item1 clicked .. do something 
                        //MessageBox.Show("CRK is Clicked");
                        last50InVisible();
                        nameT = capitalizeSub(menuText);
                         v = capitalizeSub(menuText) + drpYear.Text;
                        // counterCRK = counterCRK;
                         if (counterCRK == 0)
                         {
                             counterCRK += 1;
                             countSub = counterCRK;
                         }
                         getQuestBasedOnSubjectSelected();//getQuestBasedOnCounter(  counterCRK);
                         gettheAlphabet();clearColoredButton();retrieveArrayButtonNo(arrCRK); 
                         extractAnswerScore();
                       break;

                    case "Mathematics":
                      // menu item2 clicked .. do something 
                      // MessageBox.Show("Mathematics is Clicked");
                       last50InVisible();
                       nameT = capitalizeSub(menuText);
                         v = capitalizeSub(menuText) + drpYear.Text;
                         if (counterMaths == 0)
                         {
                             counterMaths += 1;
                             countSub = counterMaths;
                         }
                         //counterMaths += 1;
                         getQuestBasedOnSubjectSelected();
                         gettheAlphabet(); clearColoredButton();retrieveArrayButtonNo(arrMath);
                         extractAnswerScore();
                      break;
                    case "Literature in English":
                      // menu item2 clicked .. do something 
                     // MessageBox.Show("Literature in English is Clicked");
                      last50InVisible();
                      nameT = capitalizeSub(menuText);

                         v = capitalizeSub(menuText) + drpYear.Text;
                         if (counterLit == 0)
                         {
                             counterLit += 1;
                             countSub = counterLit;
                         }
                         getQuestBasedOnSubjectSelected();
                         gettheAlphabet(); clearColoredButton();retrieveArrayButtonNo(arrLit);
                         extractAnswerScore();
                      break;
                    case "Physics":
                      // menu item2 clicked .. do something 
                      //MessageBox.Show("Physics is Clicked");
                      last50InVisible();
                      nameT = capitalizeSub(menuText);
                         v = capitalizeSub(menuText) + drpYear.Text;
                         if (counterPhy == 0)
                         {
                             counterPhy += 1;
                             countSub = counterPhy;
                         }
                         getQuestBasedOnSubjectSelected();
                         gettheAlphabet(); clearColoredButton();retrieveArrayButtonNo(arrPhy);
                         extractAnswerScore();
                      break;
                    case "Chemistry":
                      // menu item2 clicked .. do something 
                     // MessageBox.Show("Chemistry is Clicked");
                      last50InVisible();
                         v = capitalizeSub(menuText) + drpYear.Text;
                         nameT = capitalizeSub(menuText);
                         if (counterChem == 0)
                         {
                             counterChem += 1; countSub = counterChem;
                         }
                         getQuestBasedOnSubjectSelected();
                         gettheAlphabet(); clearColoredButton();retrieveArrayButtonNo(arrChem);
                         extractAnswerScore();
                      break;
                    case "Biology":
                      // menu item2 clicked .. do something 
                     // MessageBox.Show("Biology is Clicked");
                      last50InVisible();
                         v = capitalizeSub(menuText) + drpYear.Text;
                         nameT = capitalizeSub(menuText);
                         if (counterBio == 0)
                         {
                             counterBio += 1; countSub = counterBio;
                         }
                         getQuestBasedOnSubjectSelected();
                         gettheAlphabet();clearColoredButton();retrieveArrayButtonNo(arrBio);
                         extractAnswerScore();
                      break;
                    case "Economics":
                      // menu item2 clicked .. do something 
                      //MessageBox.Show("Economics is Clicked");
                      last50InVisible();
                         v = capitalizeSub(menuText) + drpYear.Text;
                         nameT = capitalizeSub(menuText);
                         if (counterEco == 0)
                         {
                             counterEco += 1; countSub = counterEco;
                         }
                         getQuestBasedOnSubjectSelected();
                         gettheAlphabet();clearColoredButton();retrieveArrayButtonNo(arrEco);
                         extractAnswerScore();
                      break;
                    case "Government":
                      // menu item2 clicked .. do something 
                     // MessageBox.Show("Government is Clicked");
                      last50InVisible();
                         v = capitalizeSub(menuText) + drpYear.Text;
                         nameT = capitalizeSub(menuText);
                         if (counterGovt == 0)
                         {
                             counterGovt += 1; countSub = counterGovt;
                         }
                         getQuestBasedOnSubjectSelected();
                         gettheAlphabet();clearColoredButton();retrieveArrayButtonNo(arrGovt);
                         extractAnswerScore();
                      break;
                    case "Use of English":
                      // menu item2 clicked .. do something 
                     // MessageBox.Show("Use of English is Clicked");
                      last50Visible();
                         v = capitalizeSub(menuText) + drpYear.Text;
                         nameT = capitalizeSub(menuText);
                         if (counterEng == 0)
                         {
                             counterEng += 1; countSub = counterEng;
                         }
                         getQuestBasedOnSubjectSelected();
                         gettheAlphabet();clearColoredButton();retrieveArrayButtonNo(arrEng);
                         extractAnswerScore();
                      break;
                }
         }             
         private void bunifuFlatButton1_Click(object sender, EventArgs e)
         {

             CalculatorControl calcCont = new CalculatorControl();
             calcCont.Size = new Size(248, 258);
             panel6.Controls.Add(calcCont);
             calcCont.Location = new Point(407, 6);
             calcCont.EnableTouchMode = true;
             calcCont.Name = "MyCalculator";
             calcCont.LayoutType = CalculatorLayoutTypes.Financial;
             calcCont.BorderStyle = Border3DStyle.Raised;
             calcCont.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
             calcCont.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             calcCont.ForeColor = System.Drawing.Color.Green;
             btnCalc.Visible = false;
             bunifuFlatButton1.Visible = true;
             bunifuFlatButton1.BringToFront();
             calcCont.BringToFront();
            
         }

         private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
         {            
             panel6.Controls.Remove(panel6.Controls.Find("MyCalculator", true)[0]);
             btnCalc.Visible = true;
             bunifuFlatButton1.Visible = false;
             btnCalc.BringToFront();
         }
       
        //This function loops through the buttons to know helps display
        private void iconInv()
         {
             foreach (Control c in panel8.Controls)
             {
                 if (c is Bunifu.Framework.UI.BunifuFlatButton)
                 {

                     Bunifu.Framework.UI.BunifuFlatButton bun = c as Bunifu.Framework.UI.BunifuFlatButton;
                     for (int i = 1; i <= 10; i++)
                     {
                         if (bun.IconRightVisible == true)
                         {
                             bun.IconRightVisible = false;
                         }
                     }
                 }
             }
         }
      
        //Time decrease function 
         private void timeFunct()
         {
             timeLimit.ForeColor = Color.Red;
             //// minutes -= 1;
             if (seconds < 1)
             {
                 seconds = 59;

                 if (minutes == 0)
                 {


                 }
                 else
                 {

                     minutes -= 1;


                 }
             }
             else
             {

                 seconds -= 1;

             }

             timeLimit.Text = "Time Limit: " + hours.ToString() + " : " + minutes.ToString() + " : " + seconds.ToString();
            // lblMin.Text = minutes.ToString();
             //lblSec.Text = seconds.ToString();
         }
         private void timer1_Tick(object sender, EventArgs e)
         {
             // Verify if the time didn't pass.
             if ((minutes == 0) && (hours == 0) && (seconds == 0))
             {
                 // If the time is over, clear all settings and fields.
                 // Also, show the message, notifying that the time is over.
                 timer1.Enabled = false;
                

                 // MessageBox.Show(textBox4.Text);
                 timeLimit.Text = "Time Limit: 00hr : 00min : 00sec ";
               
                 extractAnswers();
                 panelCorrections.Visible = true;
                 extractAnswerScoreJustAfterSubmit();
                 firstSubject();
                 RestoreAllCounter();
               
                 Result_Summary frm = new Result_Summary();
                 frm.Show();
                 this.Close();
             }
             else if ((minutes <= 5) && (hours == 0) && (seconds <= 60))
             {
                 //timer2.Enabled = true;
                 //flashText(); fuc
                 timeFunct();
             }
             else
             {
                 // Else continue counting.
                 if (seconds < 1)
                 {
                     seconds = 59;

                     if (minutes == 0)
                     {

                         minutes = 59;
                         if (hours != 0)
                             hours -= 1;

                     }
                     else
                     {

                         minutes -= 1;

                     }
                 }
                 else
                     seconds -= 1;
                 // Display the current values of hours, minutes and seconds in
                 // the corresponding fields.
                 timeLimit.Text = "Time Limit: " + hours.ToString() + "hr" + " : " + minutes.ToString() + "min" + " : " + seconds.ToString() + "sec";

                



             }

         }

         private void btnBack_Click(object sender, EventArgs e)
         {
             if (MessageBox.Show("Do you want to exit the exam?", " Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 Form1 frm = new Form1();
                 frm.Show();
                 this.Close();
                 results.Clear();
             }
             else
             {
                
                 return;
             }
         }

         private void Subject_Combo_Load(object sender, EventArgs e)
         {
             if (con.State == ConnectionState.Open)
             {
                 con.Close();
             }
             con.Open();
         }
         
         private void btnPrev_Click(object sender, EventArgs e)
         {
             if (qstNo.Text == "Questions 1 of 50" || qstNo.Text == "Questions 1 of 100")
             {
                 MessageBox.Show("You are on the first question", " Alert!", MessageBoxButtons.OK, MessageBoxIcon.Question);

             }
             else
             {
                 if (v == string.Empty)
                 {
                     v = capitalizeSub(firstsub) + drpYear.Text;
                     nameT = capitalizeSub(firstsub);
                     decreaseCounterBasedOnSubjectName();
                     gettheAlphabet();
                 }
                 else
                 {
                     decreaseCounterBasedOnSubjectName();
                     gettheAlphabet();
                 }

                 
             }
         }
        string chkTrue;
        private int loo;
        void removeCheck()
        {
            optn1.Checked = false;
            optn2.Checked = false;
            optn3.Checked = false;
            optn4.Checked = false;
        }
        private  string checkRad()
        {
            chkTrue = "";
             if (optn1.Checked == true)
             {
                 chkTrue = "A";
                 UserAnswer.Text = "Your answer:  A";
                // MessageBox.Show("A");
             }
             else if (optn2.Checked == true)
             {
                 chkTrue="B";
                 UserAnswer.Text = "Your answer:  B";
               // MessageBox.Show("B");

             }
             else if (optn3.Checked == true)
             {
                 chkTrue="C";
                 UserAnswer.Text = "Your answer:  C";
                  //MessageBox.Show("C");
             }
             else if (optn4.Checked == true)
             {
                 chkTrue="D";
                 UserAnswer.Text = "Your answer:  D";
                 // MessageBox.Show("D");

             }
             else
             {
                 chkTrue = "";
             }
             return chkTrue;
         }
        
         private void btnNext_Click(object sender, EventArgs e)
         {
             if (qstNo.Text == "Questions 50 of 50" || qstNo.Text == "Questions 100 of 100")
             {
                  MessageBox.Show("You are on the last question", " Alert!", MessageBoxButtons.OK, MessageBoxIcon.Question);
             
             } 
             else
             {
                 //if (panelCorrections.Visible != true)
                 //{

                     #region
               
                   
                     if (v == string.Empty)
                     {
                         v = capitalizeSub(firstsub) + drpYear.Text;
                         nameT = capitalizeSub(firstsub);
                         //knowDSubjThenStoreAns();
                         increaseCounterBasedOnSubjectName();
                         removeCheck();
                         gettheAlphabet();

                         //knowDSubjThenStoreAns();
                         //if (bun.ButtonText == (increaseCounterBasedOnSubjectName() - 1).ToString())
                         //{
                         //    bun.BackColor = Color.Green;
                         //}
                     }
                     else
                     {
                         // knowDSubjThenStoreAns();
                         increaseCounterBasedOnSubjectName();
                         removeCheck();
                         gettheAlphabet();
                         //if (bun.ButtonText == (increaseCounterBasedOnSubjectName() - 1).ToString())
                         //{
                         //    bun.BackColor = Color.Green;
                         //}
                     }
                     #endregion

                 //}
                 //else
                 //{

                 //}      
                        
             }

         }
        
         private void optns_Click(object sender, EventArgs e)
         {
             checkRad(); knowDSubjThenStoreAns();

             foreach (Control c in panel1.Controls)
             {
                 if (c is Button)
                 {
                    Button bun = c as Button;
                     var btnText = bun.Text;
                     for (int i = 1; i <= 100; i++)
                     {
                         if (btnText == i.ToString() && btnText == countSub.ToString())
                         {
                             //MessageBox.Show(btnText);
                             //if (v == string.Empty)
                             //{ }
                             bun.BackColor = Color.Green;
                             break;
                         }

                     }
                 }
             }    



             
         }
         
         string[] arrCRK = new string[50]; string[] arrMath = new string[50]; string[] arrBio = new string[50];
         string[] arrChem = new string[50]; string[] arrEco = new string[50]; string[] arrGovt = new string[50];
         string[] arrPhy= new string[50]; string[] arrLit = new string[50]; string[] arrEng = new string[100];
         
         // OrderedDictionary od = new OrderedDictionary();
         private void knowDSubjThenStoreAns()
         {

             if (nameT == "CRK")
             {
                
                 arrCRK[counterCRK - 1] = checkRad();
             }
             else if (nameT == "MATHEMATICS")
             {
                 arrMath[counterMaths - 1] = checkRad();
               
             }
             else if (nameT == "BIOLOGY")
             {
                 arrBio[counterBio - 1] = checkRad();
             }
             else if (nameT == "CHEMISTRY")
             {
                 arrChem[counterChem - 1] = checkRad();
             }
             else if (nameT == "ECONOMICS")
             {
                 arrEco[counterEco - 1] = checkRad();
             }
             else if (nameT == "GOVERNMENT")
             {
                 
                 arrGovt[counterGovt - 1] = checkRad();
             }
             else if (nameT == "PHYSICS")
             {
                // counterPhy += 1;
                 arrPhy[counterPhy - 1] = checkRad();
             }
             else if (nameT == "LITERATURE_IN_ENGLISH")
             {
               //  counterLit += 1;
                 arrLit[counterLit - 1] = checkRad();
             }
             else if (nameT == "USE_OF_ENGLISH")
             {
                 //counterEng += 1;
                 arrEng[counterEng - 1] = checkRad();
             }
            
         }

         private void gettheAlphabet()
         {

             if (nameT == "CRK")
             {
                 getAlphaFunct(arrCRK, counterCRK);

             }
             else if (nameT == "MATHEMATICS")
             {
                 getAlphaFunct(arrMath, counterMaths);
             }
             else if (nameT == "BIOLOGY")
             {
                 getAlphaFunct(arrBio, counterBio);
             }
             else if (nameT == "CHEMISTRY")
             {
                 getAlphaFunct(arrChem, counterChem);
             }
             else if (nameT == "ECONOMICS")
             {
                 getAlphaFunct(arrEco, counterEco);
             }
             else if (nameT == "GOVERNMENT")
             {
                 getAlphaFunct(arrGovt, counterGovt);
             }
             else if (nameT == "PHYSICS")
             {
                 getAlphaFunct(arrPhy, counterPhy);
             }
             else if (nameT == "LITERATURE_IN_ENGLISH")
             {               
                 getAlphaFunct(arrLit, counterLit);
             }
             else if (nameT == "USE_OF_ENGLISH")
             {
                 getAlphaFunct(arrEng, counterEng);
             }
         }

         private void getAlphaFunct(string[] ary, int SubCounter)
         {
             
           //  var valv = arrCRK[counterCRK - 1]; //= checkRad();
             // MessageBox.Show(valv + (counterCRK-1));
             if (ary[SubCounter - 1] == null)
             {
                 removeCheck();
                 UserAnswer.Text = "Your answer: No answer selected";
             }
             else
             {
                 string val = ary[SubCounter - 1].ToString();
                 // var valv = Optnscrk[counterCRK];
                 //MessageBox.Show(val);

                 switch (val)
                 {
                     case ("A"):
                         optn1.Checked = true;
                         UserAnswer.Text = "Your answer:  A";
                         break;
                     case ("B"):
                         optn2.Checked = true;
                         UserAnswer.Text = "Your answer:  B";
                         break;
                     case ("C"):
                         optn3.Checked = true;
                         UserAnswer.Text = "Your answer:  C";
                         break;
                     case ("D"):
                         optn4.Checked = true;
                         UserAnswer.Text = "Your answer:  D";
                         break;
                     case (""):
                         removeCheck();
                         break;
                     case (null):
                         removeCheck();
                         UserAnswer.Text = "Your answer: No answer selected";
                         break;

                 }
             }
                
              
         }

         private void subNumClick(object sender, EventArgs e)
         {
             var butn = sender as Button;
             var btnText = butn.Text;
             for (int i = 1; i <= 100; i++)
             {

                 if (btnText == i.ToString() )
                 {
                     //MessageBox.Show(btnText);
                     if (v == string.Empty)
                     {
                         v = capitalizeSub(firstsub) + drpYear.Text;
                         nameT = capitalizeSub(firstsub);
                         CounterBasedOnSubjectName(btnText);
                         //removeCheck();
                         gettheAlphabet();
                         butn.Focus();

                     }
                     else
                     {
                         CounterBasedOnSubjectName(btnText);
                        // removeCheck();
                         gettheAlphabet();
                         butn.Focus();

                     }

                     break;
                 }
                 
             }
         }
         private void CounterBasedOnSubjectName( string txt)
         {

             if (nameT == "CRK")
             {
                 counterCRK =Convert.ToInt32( txt);
                 countSub = counterCRK;
                 getQuestBasedOnCounter(counterCRK);

             }
             else if (nameT == "MATHEMATICS")
             {
                 counterMaths = Convert.ToInt32(txt); 
                 
                 countSub = counterMaths;
                 getQuestBasedOnCounter(counterMaths);
             }
             else if (nameT == "BIOLOGY")
             {
                 counterBio = Convert.ToInt32(txt);
                 countSub = counterBio;
                 getQuestBasedOnCounter(counterBio);
             }
             else if (nameT == "CHEMISTRY")
             {
                 counterChem = Convert.ToInt32(txt);
                 countSub = counterChem;
                 getQuestBasedOnCounter(counterChem);
             }
             else if (nameT == "ECONOMICS")
             {
                 counterEco = Convert.ToInt32(txt);
                 countSub = counterEco;
                 getQuestBasedOnCounter(counterEco);
             }
             else if (nameT == "GOVERNMENT")
             {
                 counterGovt = Convert.ToInt32(txt);
                 countSub = counterGovt;
                 getQuestBasedOnCounter(counterGovt);
             }
             else if (nameT == "PHYSICS")
             {
                 counterPhy = Convert.ToInt32(txt);
                 countSub = counterPhy;
                 getQuestBasedOnCounter(counterPhy);
             }
             else if (nameT == "LITERATURE_IN_ENGLISH")
             {
                 counterLit = Convert.ToInt32(txt);
                 countSub = counterLit;
                 getQuestBasedOnCounter(counterLit);
             }
             else if (nameT == "USE_OF_ENGLISH")
             {
                 counterEng = Convert.ToInt32(txt);
                 countSub = counterEng;
                 getQuestBasedOnCounter(counterEng);
             }
             loop = countSub;
            // return countSub;

         }
         private void clearColoredButton()
         {
             foreach (Control c in panel1.Controls)
             {
                 if (c is Button)
                 {
                     Button bun = c as Button;
                     var btnText = bun.Text;
                     for (int i = 1; i <= 100; i++)
                     {
                         if (btnText == i.ToString())
                         {
                             
                             bun.BackColor = Color.White;
                             //for (int index = 0; index < length; index++)
                             //{
                                 
                             //}
                         }

                     }
                 }
             }    
         }

         private void retrieveArrayButtonNo(string[] arrayInd)
         {


             for (int index = 0; index < arrayInd.Length; index++)
             {
                 if (arrayInd[index] == null)
                 {
                     
                 }
                 else
                 {
                     foreach (Control c in panel1.Controls)
                     {
                         if (c is Button)
                         {
                             Button bun = c as Button;
                             var btnText = bun.Text;
                             if (btnText == (index + 1).ToString())
                             {

                                 bun.BackColor = Color.Green;
                             }
                     

                         }
                     }
                 }
             }


         }
         int counts = 0;
         private void extractAnswers()
         {
             //this loops through selected subject
             foreach (string name in results)
             {
                 //converts each subject to database right format
                 v = capitalizeSub(name) + drpYear.Text;
                 nameT = capitalizeSub(name);
                 //picks the convert fromat and querries the database
                 string selectQuery = string.Format("Select * from {0} ", v);
                 SQLiteDataAdapter sda = new SQLiteDataAdapter(selectQuery, con);
                 DataTable dt = new DataTable();
                 sda.Fill(dt); string[] DbAns = new string[dt.Rows.Count];
              
                 for (int a = 0; a < dt.Rows.Count; a++)
                 {

                     DbAns[a] = dt.Rows[a]["CORRECT_OPTION"].ToString();
                 }

                 counts = DbAns.Intersect(knowDSubjforCompare()).Count();

                 int percent = (int)Math.Round((double)(counts * 100) / DbAns.Length);
                 percentage.Add(percent.ToString());
                 //MessageBox.Show(counts.ToString());
                 //MessageBox.Show(percentage.ToString()+ "%");
                 Scorecard.Add(counts);
                 TotalQuest.Add(dt.Rows.Count.ToString());
                 
             }
            
             panel6.Enabled = false;
                    
         }

         private void extractAnswerScoreJustAfterSubmit()
         {
             //this loops through selected subject
        

         //converts each subject to database right format
                 v = capitalizeSub(results.First()) + drpYear.Text;
                 nameT = capitalizeSub(results.First());
                 //picks the convert fromat and querries the database
                 string selectQuery = string.Format("Select * from {0} ", v);
                 SQLiteDataAdapter sda = new SQLiteDataAdapter(selectQuery, con);
                 DataTable dt = new DataTable();
                 sda.Fill(dt); string[] DbAns = new string[dt.Rows.Count];

                 for (int a = 0; a < dt.Rows.Count; a++)
                 {

                     DbAns[a] = dt.Rows[a]["CORRECT_OPTION"].ToString();
                 }

                int countAns = DbAns.Intersect(knowDSubjforCompare()).Count();
                 string totqst = dt.Rows.Count.ToString();
                 UserScore.Text = string.Format("Score: {0}/{1}", countAns,totqst);

          

            // panel6.Enabled = false;

         }

         private void extractAnswerScore()
         {
             //this loops through selected subject


             //converts each subject to database right format
             //v = capitalizeSub(results.First()) + drpYear.Text;
             //nameT = capitalizeSub(results.First());
             //picks the convert fromat and querries the database
             string selectQuery = string.Format("Select * from {0} ", v);
             SQLiteDataAdapter sda = new SQLiteDataAdapter(selectQuery, con);
             DataTable dt = new DataTable();
             sda.Fill(dt); string[] DbAns = new string[dt.Rows.Count];

             for (int a = 0; a < dt.Rows.Count; a++)
             {

                 DbAns[a] = dt.Rows[a]["CORRECT_OPTION"].ToString();
             }

             int countAns = DbAns.Intersect(knowDSubjforCompare()).Count();
             string totqst = dt.Rows.Count.ToString();
             UserScore.Text = string.Format("Score: {0}/{1}", countAns, totqst);



             // panel6.Enabled = false;

         }
         private void btnSubmit_Click(object sender, EventArgs e)
         {
             if (panel4.Visible == true && panel1.Visible == true)
             {
                 if (panelCorrections.Visible != true)
                 {
                     if (MessageBox.Show("Do you want to Submit?", " Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                     {
                         timer1.Enabled = false;    
                        // if (timer1.Stop()== true)
                        // timer1.Stop();
                         extractAnswers();
                         panelCorrections.Visible = true;
                         extractAnswerScoreJustAfterSubmit();
                         firstSubject();
                         RestoreAllCounter();
                         // panelCorrections.BringToFront();
                         //panel1.Visible = false;
                         //
                        
                     }
                     else
                     {

                         return;
                     }

                 }
                 else{

                 }
             }
                 else
                 {
                     MessageBox.Show("Please Make sure you select the Subject of Choice and Click Proceed?", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 }
      
           
            
            //knowDSubjforCompare();

         }
         string[] userOptions;

         private string[] knowDSubjforCompare( )
         {
             //= new string[];
             if (nameT == "CRK")
             {
                 //Creating and initializing the peculiar array to userOptions array
                 userOptions = new string [arrCRK.Length];
                 Array.Copy(arrCRK, userOptions, arrCRK.Length);
             }
             else if (nameT == "MATHEMATICS")
             {
                 
                 userOptions = new string[arrMath.Length];
                 Array.Copy(arrMath, userOptions, arrMath.Length);

             }
             else if (nameT == "BIOLOGY")
             {
               //  arrBio[counterBio - 1] = checkRad();
                 userOptions = new string[arrBio.Length];
                 Array.Copy(arrBio, userOptions, arrBio.Length);
             }
             else if (nameT == "CHEMISTRY")
             {
                // arrChem[counterChem - 1] = checkRad(); 
                 userOptions = new string[arrChem.Length];
                 Array.Copy(arrChem, userOptions, arrChem.Length);
             }
             else if (nameT == "ECONOMICS")
             {
                // arrEco[counterEco - 1] = checkRad();
                 userOptions = new string[arrEco.Length];
                 Array.Copy(arrEco, userOptions, arrEco.Length);
             }
             else if (nameT == "GOVERNMENT")
             {

             //    arrGovt[counterGovt - 1] = checkRad();
                 userOptions = new string[arrGovt.Length];
                 Array.Copy(arrGovt, userOptions, arrGovt.Length);
             }
             else if (nameT == "PHYSICS")
             {
                 // counterPhy += 1;
               //  arrPhy[counterPhy - 1] = checkRad();
                 userOptions = new string[arrPhy.Length];
                 Array.Copy(arrPhy, userOptions, arrPhy.Length);
             }
             else if (nameT == "LITERATURE_IN_ENGLISH")
             {
                 //  counterLit += 1;
                // arrLit[counterLit - 1] = checkRad();
                 userOptions = new string[arrLit.Length];
                 Array.Copy(arrLit, userOptions, arrLit.Length);
             }
             else if (nameT == "USE_OF_ENGLISH")
             {
                 //counterEng += 1;
                // arrEng[counterEng - 1] = checkRad();
                 userOptions = new string[arrEng.Length];
                 Array.Copy(arrEng, userOptions, arrEng.Length);
             }
             return userOptions;
         }

         private void pictureBox1_DoubleClick(object sender, EventArgs e)
         {
             pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
         }

         private void pictureBox1_Click(object sender, EventArgs e)
         {
             pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
         }

         private void BtnResultSummary_Click(object sender, EventArgs e)
         {
           // this.
             Result_Summary frm = new Result_Summary();
             frm.Show();
             this.Hide();
         }

      

         
    }
}
