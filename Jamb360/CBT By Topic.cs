using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Bunifu.UI.WinForms.BunifuButton;
using HtmlAgilityPack;
using System.Web;
using System.Text.RegularExpressions;
using Syncfusion.Windows.Forms.Tools;


namespace Jamb360
{
    public partial class CBT_By_Topic : Form
    {
        public CBT_By_Topic()
        {
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection(@"Data Source=.\Jamb_360.db; Version= 3;"); string realSub; string dbTableName;
        public DataTable FilteredTable = new DataTable();
        public DataTable dataTableForSingleYear = new DataTable();
        List<string> mathsGenTopicList = new List<string> { "Indices and Logarithm","Sets","Surds","Sets (Venn diagram)",
                "Subtraction","Compound Interest","Number Bases","Profit and Loss Percentage","Binary Operation","AP and GP","Venn diagram","Quadratic equation","Polynomials",
                "Differentiation and Integration","Inequalities","Mensuration","Plane geometry","Bearing","Loci and construction","Graph and identities","Statistics","Permutation and combination","Place values","L.C.M and H.C.F",
                "Probability","Significant Figures","Venn Diagram","Indices","Algebraic Graph","Angles (Scalene triangle)","Angle of Elevation and Depression",
                "Factorials","Trigonometry","Function","Variation","Change of subject","Division of numbers","Profit and Loss","BODMAS","Percentage","Simultaneous equation","Factorization",
                "Representation of Data","Fraction","Addition and Subtraction","Square root","Ratio","Multiplication and Division","Simple Interest","Trigonometric ratio","Matrix","Standard form","Percentage Error",
                "Multiplication of Numbers","Sequence and Progression","Prime factors","Decimals","Squares and Square root","Compound Interest","Partial fraction","Prime Numbers”,”Decimals"};
        int counting = 0;
        string chkTrue; string[] arrayUserOptions = new string[100]; string[] userOptions;
        int QuestCounterInListDbID = 0; public static String subName;
        public static String yearQuest; string topic; string combined; int counts = 0;
        List<string> yearCollection = new List<string>();
        public static int Scorecard;
        public static string TotalQuest;
        public static string percentage;
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the exam?", " Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        int questionNum = 1; 
        private void CBT_By_Topic_Load(object sender, EventArgs e)
        {

            SubjList.SelectedIndex = 0;
            checkedTopicList.Items.Clear();
            YearList.SelectedIndex = 0;
        }
        int hours = 0; int minutes = 0; int seconds = 0;
        private void timeCalc()
        {
            int eng = DbID.Count * 24;
            double otherSub = DbID.Count * 18;
               if ( SubjList.Text == "Use of English")
                 {
                     var timeSpan = TimeSpan.FromSeconds(eng);

                     hours = timeSpan.Hours; minutes = timeSpan.Minutes; seconds = timeSpan.Seconds;
                   
                     
                 }
                 else
                 {
                //     MessageBox.Show("othersubnhj");
                     var timeSpan = TimeSpan.FromSeconds(otherSub);

                     hours = timeSpan.Hours; minutes = timeSpan.Minutes; seconds = timeSpan.Seconds;

                   //  MessageBox.Show(hours.ToString()); MessageBox.Show(minutes.ToString()); MessageBox.Show(seconds.ToString());
                 }
             

        }
        WaitFormFunct waitform = new WaitFormFunct();
        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (panel4.Visible != true)
            {
                if (checkedTopicList.CheckedItems.Count != 0 && SubjList.SelectedIndex > 0 && YearList.SelectedIndex > 0)
                {
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    panel4.Visible = true;
                    panel1.Visible = true;
                    if (YearList.SelectedIndex == 1)
                    {
                        waitform.Show(this);
                        ProceedFunctForAllYear();
                        waitform.Close();
                       // extractAnswers();
                        timeCalc();
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        waitform.Show(this);
                        ProceedFunct();
                        waitform.Close();
                       // extractAnswers();
                        timeCalc();
                        timer1.Enabled = true;
                        timer1.Start();
                        //  
                    }
                    YearList.Enabled = false;

                    SubjList.Enabled = false;
                }
                else
                {
                    if (YearList.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please Make sure you select the Year of Choice?", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (checkedTopicList.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Please make sure you select topic of Choice?", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (SubjList.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please Make sure you select the Year of Choice?", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
         //   MessageBox.Show(dataTableForSingleYear.Rows.Count.ToString());
          //  MessageBox.Show(DbID.Count.ToString()); 
        }
        int countTops =0;
        private void subItemClick(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var menuText = menuItem.Text;

        }             
        private void ProceedFunct()
        {
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            
            subName = SubjList.Text;
            yearQuest = YearList.Text;
            for (int ri = 0; ri <= (checkedTopicList.Items.Count-1); ri++)
            {
                if (checkedTopicList.GetItemChecked(ri))
                {
                    chkTopic.Add(checkedTopicList.Items[ri].ToString());
                }   
            }
            combined = subName + "("+ yearQuest+")";
            //MessageBox.Show(chkTopic.Count.ToString());
            //return;
            foreach (var topicItem in chkTopic)
            {
                combined += string.Format(" - {0}", topicItem);                
            }
            //claers the strip of an old collection
            menuStrip1.Items.Clear();
            //Create toolstip dynamically and Add subject Name to toolstrip
            ToolStripItem subItem = new ToolStripMenuItem(combined);
            subItem.Click += new EventHandler(subItemClick);
            menuStrip1.Items.Add(subItem);

            //return;
            //Capitalizes and adds the year so it could point to a particular table
            dbTableName = capitalizeSub(subName) + YearList.Text;
            QuestCounterInListDbID = 0; questionNum = 1;

            loadCbtByTopic();
           
        }
        private void dataTableDisplay(int noOfQuestions)
        {
            //return;

            int i;
            i = FilteredTable.Rows.Count;
         //   MessageBox.Show(i.ToString() + " thats to check if it recollects the no of table ");

            foreach (DataRow Item in FilteredTable.Rows)
            {
                object getIdInNewTable = Item["ID"];
                int desiredID = Convert.ToInt32(getIdInNewTable);
                if (desiredID == questionNum)
                {
                    //MessageBox.Show(desiredID.ToString());

                        //this is no more needed
                        qstNo.Text = string.Format("Questions {0} of {1}", questionNum, noOfQuestions);
                        byte[] image = new byte[0];

                        string instruct = Item["EXAM_INSTRUCTION"].ToString();
                        string comprehense = Item["COMPREHENSION_QUESTION"].ToString();
                        //MessageBox.Show(instruct);
                        if (instruct == string.Empty)
                        {
                            QuestionsInstr.Visible = false;
                        }
                        else
                        {
                            QuestionsInstr.DocumentText = instruct;
                            QuestionsInstr.Visible = true;
                        }
                        txtComprehension.DocumentText = comprehense;

                        qstions.DocumentText = Item["QUESTION"].ToString();
                  
                        string optA = Item["OPTION_A"].ToString();
                        string optB = Item["OPTION_B"].ToString(); 
                        string optC = Item["OPTION_C"].ToString();
                        string optD = Item["OPTION_D"].ToString();
                        CorrectAns.Text = "Correct answer: " + Item["CORRECT_OPTION"].ToString();
                        ExplanationPanel.DocumentText = Item["CORRECT_ANS"].ToString();
                        optn1.Text = "A. " + regexOpx(optA);
                        optn2.Text = "B. " + regexOpx(optB);
                        optn3.Text = "C. " + regexOpx(optC);
                        optn4.Text = "D. " + regexOpx(optD);
                        //optn1.Text = "A. " + Item["OPTION_A"].ToString();
                        //optn2.Text = "B. " + Item["OPTION_B"].ToString();
                        //optn3.Text = "C. " + Item["OPTION_C"].ToString();
                        //optn4.Text = "D. " + Item["OPTION_D"].ToString();
                        // return;
                        //coverts the blob field to object, So I can compare if the field is empty
                        object chk = (Item["QUESTION_IMAGE"]);
                        if (chk is System.DBNull)
                        {
                            pictureBox1.Visible = false;
                        }
                        else if (chk.ToString() == string.Empty)
                        {
                            pictureBox1.Visible = false;
                        }
                        else
                        {
                            Type datatype = (Item["QUESTION_IMAGE"]).GetType();
                            if (datatype == typeof(string))
                            {
                                //This is a wrong datatype for storing images in database
                                //So do not cos it will produce error.
                                //MessageBox.Show("string");
                                //MemoryStream ms;
                                //byte[] bviewimg = (byte[])Item["QUESTION_IMAGE"];
                                //ms = new MemoryStream(bviewimg);
                                //ms.Write(bviewimg, 0, bviewimg.Length);
                                //ms.Position = 0;
                                //pictureBox1.Image = Image.FromStream(ms);
                                //pictureBox1.Visible = true;
                            }
                            else if (datatype == typeof(byte[]))
                            {
                                image = (byte[])(Item["QUESTION_IMAGE"]);
                                Image img = byteArrayToImage(image);
                                pictureBox1.Image = img;
                                pictureBox1.Visible = true;
                               // MessageBox.Show("blob");
                            }

                        }

                    }

                // qstNo.Text = string.Format("Questions {0} of {1}", counterMaths, i);



            }




        }

        private string regexOpx(string txthere)
        {
            string patternSup = "<sup>(.*?)</sup>";
            string patternSub = "<sub>(.*?)</sub>";
            string patternbr="(?<=>)(.*)(?=<)";
 //                var b = Regex.Match(a, "(?<=>)(.*)(?=<)");
 //Console.WriteLine(b.Value);
            string matched="";
      var match = Regex.Match(txthere, patternSup, RegexOptions.IgnoreCase);
            
            //if (matches.Count > 0)
            //{

            //    foreach (Match m in matches)
            //    {
            //        matched = m.Groups[1].ToString();
            //    }
            //}
    //  MessageBox.Show(match.Value);
            if ( match.Value == "0")
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

           
            //regexOpx(waito);//Regex.Match(waito, patternbr);
           
        }
        private void ProceedFunctForAllYear()
        {
            btnPrev.Enabled = true;
            btnNext.Enabled = true;

            subName = SubjList.Text;
            yearQuest = YearList.Text;
            for (int ri = 0; ri <= (checkedTopicList.Items.Count - 1); ri++)
            {
                if (checkedTopicList.GetItemChecked(ri))
                {
                    chkTopic.Add(checkedTopicList.Items[ri].ToString());
                }
            }
            combined = subName + "(" + yearQuest + ")";
            //MessageBox.Show(chkTopic.Count.ToString());
            //return;
            foreach (var topicItem in chkTopic)
            {
                combined += string.Format(" - {0}", topicItem);
            }
            //claers the strip of an old collection
            menuStrip1.Items.Clear();
            //Create toolstip dynamically and Add subject Name to toolstrip
            ToolStripItem subItem = new ToolStripMenuItem(combined);
            subItem.Click += new EventHandler(subItemClick);
            menuStrip1.Items.Add(subItem);

            //return;
            //Capitalizes and adds the year so it could point to a particular table
           // dbTableName = capitalizeSub(subName) + YearList.Text;
            QuestCounterInListDbID = 0; questionNum = 1;

            dbQueryForAllYear();
            last50Visible(counting);
        }
        int countAllYearsQuestnNumbers = 0;
      
        /// <summary>
        /// Look where i am
        /// </summary>
        
        private void dbQueryForAllYear()
        {
         // fghh
            //return;
           // dbTableName = capitalizeSub(subName) + YearList.Text;
            
       
                for (int yearStart = 2000; yearStart < 2020; yearStart++)
                {
                   yearCollection.Add(capitalizeSub(subName) + yearStart.ToString());
                }
               
                string unionquery = string.Format("SELECT * FROM {0}  UNION ALL SELECT * FROM {1}  UNION ALL SELECT * FROM {2}  UNION ALL SELECT * FROM {3} UNION ALL SELECT * FROM {4} UNION ALL SELECT * FROM {5} UNION ALL SELECT * FROM {6} UNION ALL SELECT * FROM {7} UNION ALL SELECT * FROM {8} UNION ALL SELECT * FROM {9} UNION ALL SELECT * FROM {10} UNION ALL SELECT * FROM {11} UNION ALL SELECT * FROM {12} UNION ALL SELECT * FROM {13} UNION ALL SELECT * FROM {14} UNION ALL SELECT * FROM {15} UNION ALL SELECT * FROM {16} UNION ALL SELECT * FROM {17} UNION ALL SELECT * FROM {18} UNION ALL SELECT * FROM {19} ORDER BY TOPIC_NAME", yearCollection[0], yearCollection[1], yearCollection[2],yearCollection[3], yearCollection[4], yearCollection[5], yearCollection[6], yearCollection[7], yearCollection[8], yearCollection[9], yearCollection[10], yearCollection[11], yearCollection[12], yearCollection[13], yearCollection[14], yearCollection[15], yearCollection[16], yearCollection[17], yearCollection[18], yearCollection[19] );
                   SQLiteDataAdapter sda = new SQLiteDataAdapter(unionquery, con);
                   DataTable dtTableforAllYear = new DataTable();
                   sda.Fill(dtTableforAllYear); //DbID = new string[dt.Rows.Count];
                   FilteredTable = dtTableforAllYear.Clone();
                   foreach (DataRow dr in dtTableforAllYear.Rows)
                   {
          
                       object o =( dr[@"TOPIC_NAME"]);
                       if (o !=DBNull.Value) // check for null
                       {
                           string desiredTopic = o.ToString();
                           foreach (string item in chkTopic)
                           {
                               if (desiredTopic== item)
                               {
                                   counting++;
                                 //  FilteredTable = dtTableforAllYear.Clone();
                                  FilteredTable.ImportRow(dr);
                                 // FilteredTable.Rows.Add(dr.ItemArray);
                                   FilteredTable.Rows[counting-1]["ID"] = counting;
                                   DbID.Add(FilteredTable.Rows[counting - 1]["ID"].ToString());
                                
                               }
                           }
                       }
                   }

                   FilteredTable.AcceptChanges();
                   //dtValidData = dsbmVillagedata.Tables[0].Clone(); // place this line outside the loop.

                   //foreach (DataRow dr in dsbmVillagedata.Tables[0].Rows)
                   //{
                   //    dtValidData = dsbmVillagedata.Tables[0].Clone();
                   //    DataRow drNew = dtValidData.NewRow();
                   //    drNew.ItemArray = dr.ItemArray;
                   //    dtValidData.Rows.Add(drNew);
                   //    int a = dtValidData.Rows.Count;
                   //}
            dataTableDisplay(counting);
        }
       
        private void gettheAlphabet()
        {
            //if (YearList.Text != "All Year")
            //{
            //    //QuestCounterInListDbID = Convert.ToInt32(txt);
            //    //getQuestBasedOnCounter(QuestCounterInListDbID);
            //}
            //else
            //{

            //    questionNum = Convert.ToInt32(txt);

            //    dataTableDisplay(counting);

            //}

            getAlphaFunct(arrayUserOptions, questionNum);
     
        }
        private void getAlphaFunct(string[] ary, int SubCounter)
        {
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

        private void getQuestBasedOnCounter(int counter)
        {
            //MessageBox.Show(pileupID[counter].ToString());
            //return;
      
            //  #region
              string selectQuery = string.Format("Select * from {0} where ID='" + DbID[counter-1] + "' ", dbTableName);
            SQLiteDataAdapter sda = new SQLiteDataAdapter(selectQuery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            qstNo.Text = string.Format("Questions {0} of {1}", questionNum, DbID.Count);
            if (questionNum <= DbID.Count)
            {
                qstNo.Text = string.Format("Questions {0} of {1}", questionNum, DbID.Count);
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
                   // MessageBox.Show("TypeOfStringEmpty");
                    pictureBox1.Visible = false;
                }
                else if (chk.ToString() == string.Empty)
                {
                   // MessageBox.Show("TypeOfString Empty");
                    pictureBox1.Visible = false;
                }
                else
                {
                    Type datatype = (dt.Rows[0]["QUESTION_IMAGE"]).GetType();
                    if (datatype == typeof(string))
                    {
                       // pictureBox1.Visible = true;
                       //// MessageBox.Show("TypeOfString");
                       // string s = (string)(dt.Rows[0]["QUESTION_IMAGE"]);
                       // image = Encoding.ASCII.GetBytes(s);
                       // //string base64 = Convert.ToBase64String(image, 0, image.Length);
                       // //Image img = byteArrayToImage(image);
                       // MemoryStream MS = new MemoryStream(image);

                       // pictureBox1.Image = Image.FromStream(MS);
                       // pictureBox1.Visible = true;
                        //This is a wrong datatype for storing images in database
                    }
                    else if (datatype == typeof(byte[]))
                    {
                        image = (byte[])(dt.Rows[0]["QUESTION_IMAGE"]);
                        Image img = byteArrayToImage(image);
                        pictureBox1.Image = img;
                        pictureBox1.Visible = true;
                        //MessageBox.Show("byte data");
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
                CorrectAns.Text = "Correct answer: " + dt.Rows[0]["CORRECT_OPTION"].ToString();
                ExplanationPanel.DocumentText = dt.Rows[0]["CORRECT_ANS"].ToString();
            }
        }
        private void increaseCounterBasedOnSubjectName()
        {

            if (YearList.Text != "All Year")
            {
               QuestCounterInListDbID++;
               questionNum++;
                //countSub = QuestCounter;
               getQuestBasedOnCounter(questionNum);

            }
            else
            {
                QuestCounterInListDbID++;
                questionNum++;
                dataTableDisplay(counting);
            }
        }
        private void decreaseCounterBasedOnSubjectName()
        {
            if (YearList.Text != "All Year")
            {
                QuestCounterInListDbID--;
                questionNum--;
                getQuestBasedOnCounter(questionNum);
            }
            else
            {
                 QuestCounterInListDbID--;
                questionNum--;
                dataTableDisplay(counting);
            }
         
        }
        public Image byteArrayToImage(byte[] byt)
        {
            using (MemoryStream mstream = new MemoryStream(byt))
            {
                return Image.FromStream(mstream);
            }
        }
        private void loadAllYearTopic()
        {
            checkedTopicList.Items.Clear();
            foreach (string topicID in mathsGenTopicList)
            {
                checkedTopicList.Items.Add(topicID);
            }
        }
       
        List<int> pileupID = new List<int>();

        List<string> chkTopic = new List<string>();
        private void SubjList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubjList.SelectedIndex > 0)
            {
                YearList.Enabled = true;
            }
        }
        List<string> DbID = new List<string>();
        private void loadCbtByTopic()
        {
            dbTableName = capitalizeSub(subName) + YearList.Text;
           
            foreach (var item in chkTopic)
            {
                string selectQuery = string.Format("Select * from {0} where TOPIC_NAME=@Items ", dbTableName);

                SQLiteCommand cmd = con.CreateCommand(); cmd.CommandText = selectQuery; cmd.CommandType = CommandType.Text;
                SQLiteParameter param = new SQLiteParameter();
                param.ParameterName = "@Items";
                param.Value = item;
                cmd.Parameters.Add(param);
               SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
               
                sda.Fill(dt); //DbID = new string[dt.Rows.Count];
                for (int a = 0; a < dt.Rows.Count; a++)
                {
                    DbID.Add(dt.Rows[a]["ID"].ToString());
                   // DbID[a] = dt.Rows[a]["ID"].ToString();
                }
            }
            dbQuery(dbTableName, DbID[QuestCounterInListDbID], DbID.Count);
           // dataTableForSingleYear = dt;
            last50Visible(DbID.Count);
        }
        //int i;
        private void dbQuery(string tableofName, string SomeId, int noOfQuestions)
        {
            //return;
            string selectQuery = string.Format("Select * from {0} where  ID='"+SomeId+"'  ", tableofName);
            //  string selectQuery = string.Format("Select * from {0} Where ID = {1}", tableName, IndexMe);//Where ID= {1}", tableName, Index);
            SQLiteDataAdapter sda = new SQLiteDataAdapter(selectQuery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int i;
            i = dt.Rows.Count;
      

            // qstNo.Text = string.Format("Questions {0} of {1}", counterMaths, i);
            if (i <= noOfQuestions)
            {
                //this is no more needed
                qstNo.Text = string.Format("Questions {0} of {1}", questionNum, noOfQuestions);
                byte[] image = new byte[0];

                string instruct = dt.Rows[0]["EXAM_INSTRUCTION"].ToString();
                string comprehense = dt.Rows[0]["COMPREHENSION_QUESTION"].ToString();

                if (instruct == string.Empty)
                {
                    QuestionsInstr.Visible = false;
                }
                else
                {
                    QuestionsInstr.DocumentText = instruct;
                    QuestionsInstr.Visible = true;
                }
                txtComprehension.DocumentText = comprehense;

                qstions.DocumentText = dt.Rows[0]["QUESTION"].ToString();

                string optA = dt.Rows[0]["OPTION_A"].ToString();
                string optB = dt.Rows[0]["OPTION_B"].ToString();
                string optC = dt.Rows[0]["OPTION_C"].ToString();
                string optD = dt.Rows[0]["OPTION_D"].ToString();

                optn1.Text = "A. " + regexOpx(optA);
                optn2.Text = "B. " + regexOpx(optB);
                optn3.Text = "C. " + regexOpx(optC);
                optn4.Text = "D. " + regexOpx(optD);

                //optn1.Text = "A. " + dt.Rows[0]["OPTION_A"].ToString();
                //optn2.Text = "B. " + dt.Rows[0]["OPTION_B"].ToString();
                //optn3.Text = "C. " + dt.Rows[0]["OPTION_C"].ToString();
                //optn4.Text = "D. " + dt.Rows[0]["OPTION_D"].ToString();
                // return;
                //coverts the blob field to object, So I can compare if the field is empty
              //  object chk = (dt.Rows[0]["QUESTION_IMAGE"]);
                if ((dt.Rows[0]["QUESTION_IMAGE"]) is System.DBNull)
                {
                    pictureBox1.Visible = false;
                }
                else if ((dt.Rows[0]["QUESTION_IMAGE"]).ToString() == string.Empty)
                {
                    pictureBox1.Visible = false;
                }
                else
                {
                    Type datatype = (dt.Rows[0]["QUESTION_IMAGE"]).GetType();
                    if (datatype == typeof(string))
                    {
                        //This is a wrong datatype for storing images in database
                        //So do not cos it will produce error.
                        //string s = (string)(dt.Rows[0]["QUESTION_IMAGE"]);
                        //image = Encoding.ASCII.GetBytes(s);
                        ////string base64 = Convert.ToBase64String(image, 0, image.Length);
                        ////Image img = byteArrayToImage(image);
                        //MemoryStream MS = new MemoryStream(image);

                        //pictureBox1.Image = Image.FromStream(MS);
                        //pictureBox1.Visible = true;

                    }
                    else if (datatype == typeof(byte[]))
                    {
                        image = (byte[])(dt.Rows[0]["QUESTION_IMAGE"]);
                        Image img = byteArrayToImage(image);
                        pictureBox1.Image = img;
                        pictureBox1.Visible = true;
                    }

                }


            }
             

          

        }

    
        private void loadTopic()
        {
            subName = SubjList.Text;
            yearQuest = YearList.Text;
           /// topic = TopicList.Text;
            combined = string.Format("{0} - {1}", subName, topic);
            List<string> pileup = new List<string>();
            dbTableName = capitalizeSub(subName) + YearList.Text;
            // nameT = capitalizeSub(firstsub);
            string selectQuery = string.Format("SELECT DISTINCT TOPIC_NAME FROM {0}", dbTableName);
            SQLiteDataAdapter sda = new SQLiteDataAdapter(selectQuery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            checkedTopicList.Items.Clear();
           // TopicList.Items.Clear();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    TopicList.Items.Add(dt.Rows[i]["TOPIC_NAME"]);
            //}
            // List<string> names = new List<string>(); ;
            foreach (DataRow rw in dt.Rows)
            {
                string ray = (rw["TOPIC_NAME"]).ToString();
                if (ray == null || ray == string.Empty)
                {
                    //return;
                }
                else
                {
                    //pileup.Add(ray);
                    checkedTopicList.Items.Add(rw["TOPIC_NAME"]);
                }

            }
            //foreach (var item in pileup)
            //{
            //    names = pileup.Distinct().ToList();
            //}
            //foreach (string item in names)
            //{
            //    TopicList.Items.Add(item);
            //}

        }
        private string capitalizeSub(string sub)
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
        private void YearList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubjList.SelectedIndex == 0)
            {
               // MessageBox.Show("Select a subject", " Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            
            else
            {
                if (YearList.SelectedIndex ==1)
                {
                    loadAllYearTopic();
                }
                else
                {
                    loadTopic();
                }
            }
        }
        private void removeCheck()
        {
            optn1.Checked = false;
            optn2.Checked = false;
            optn3.Checked = false;
            optn4.Checked = false;
        }
        private string checkRad()
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
                chkTrue = "B";
                UserAnswer.Text = "Your answer:  B";
                // MessageBox.Show("B");

            }
            else if (optn3.Checked == true)
            {
                chkTrue = "C";
                UserAnswer.Text = "Your answer:  C";
                //MessageBox.Show("C");
            }
            else if (optn4.Checked == true)
            {
                chkTrue = "D";
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
            if (qstNo.Text == string.Format("Questions {0} of {0}", DbID.Count) || qstNo.Text == string.Format("Questions {0} of {0}", counting))
            {
                MessageBox.Show("You are on the last question", " Alert!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            else
            {
                    increaseCounterBasedOnSubjectName();
                    removeCheck();
                    gettheAlphabet();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (qstNo.Text == string.Format("Questions 1 of {0}", DbID.Count) || qstNo.Text == string.Format("Questions 1 of {0}", counting))
            {
                MessageBox.Show("You are on the first question", " Alert!", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            else
            {
               
                    decreaseCounterBasedOnSubjectName();
                    removeCheck();
                    gettheAlphabet();
            }
        }
        private void StoreAns()
        {
            if (YearList.Text != "All Year")
            {
                arrayUserOptions[questionNum-1] = checkRad();
            }
            else
            {

               // questionNum = Convert.ToInt32(txt);
                arrayUserOptions[questionNum-1] = checkRad();
                //dataTableDisplay(counting);

            }
          
            //MessageBox.Show(arrayUserOptions[QuestCounter].ToString());
        }
        private void optn_Click(object sender, EventArgs e)
        {
            checkRad(); StoreAns();
            foreach (Control c in panel7.Controls)
            {
                if (c is Button)
                {
                    Button bun = c as Button;
                    var btnText = bun.Text;
                    for (int v = 1; v <= DbID.Count; v++)
                    {
                       // MessageBox.Show(i.ToString());
                        if (btnText == v.ToString() && btnText == questionNum.ToString())
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
        private void last50Visible( int TotalRowNo)
        {
            // Bunifu.UI.WinForms.BunifuButton.BunifuButton
            //Panel pn = find
            foreach (Control c in panel7.Controls)
            {
                if (c is Button)
                {
                    Button bun = c as Button;
                    for (int rn = 1; rn <= TotalRowNo; rn++)
                    {
                        if (bun.Text == rn.ToString())
                        {
                            bun.Visible = true;
                        }
                        //else
                        //{
                        //    bun.Visible = false;
                        //}
                    }
                }
            }
        }

        private void extractAnswers()
        {
            //this loops through selected subject
           // hhhhh
                //converts each subject to database right format
            if (YearList.Text != "All Year")
            {
                //dataTableForSingleYear
                string[] DbAns = new string[DbID.Count];
                foreach (var item in chkTopic)
                {

                     string selectQuery = string.Format("Select * from {0} where TOPIC_NAME=@Items ", dbTableName);

                SQLiteCommand cmd = con.CreateCommand(); cmd.CommandText = selectQuery; cmd.CommandType = CommandType.Text;
                SQLiteParameter param = new SQLiteParameter();
                param.ParameterName = "@Items";
                param.Value = item;
                cmd.Parameters.Add(param);
                SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();   
                    sda.Fill(dt);
                   // you never filled sda with dt
                    for (int a = 0; a < dt.Rows.Count; a++)
                    {

                        DbAns[a] = dt.Rows[a]["CORRECT_OPTION"].ToString();
                       // MessageBox.Show(DbAns[a].ToString());
                    }
                }

                var intersect = DbAns.Intersect(knowDSubjforCompare());

                foreach (string item in intersect)
                {
                    if (item == string.Empty || item == null)
                    {
                        counts += 0;
                    }
                    else
                    {
                        counts++;
                    }
                }
                if (counts > 0   )
                {
                    counts = DbAns.Intersect(knowDSubjforCompare()).Count();
                    int percent = (int)Math.Round((double)(counts * 100) / DbAns.Length);
                    percentage = percent.ToString();
                   
                }
                else
                {
                    percentage = "0";
                    counts = 0;
                }
               // MessageBox.Show(counts.ToString());
                //MessageBox.Show(percentage.ToString()+ "%");
                Scorecard=counts;
                TotalQuest = DbAns.Length.ToString();
               // int countAns = DbAns.Intersect(knowDSubjforCompare()).Count();
                //string totqst = dt.Rows.Count.ToString();
                UserScore.Text = string.Format("Score: {0}/{1}", counts, DbAns.Length.ToString());
                qstNo.Text = string.Format("Questions {0} of {1}", questionNum, DbAns.Length.ToString());
               
               
            }
            else
            {

             string[] DbAns = new string[FilteredTable.Rows.Count];

                for (int a = 0; a < FilteredTable.Rows.Count; a++)
                {

                    DbAns[a] = FilteredTable.Rows[a]["CORRECT_OPTION"].ToString();
                }

                counts = DbAns.Intersect(knowDSubjforCompare()).Count();

                int percent = (int)Math.Round((double)(counts * 100) / DbAns.Length);
                percentage= percent.ToString();
               // MessageBox.Show(counts.ToString());
                //MessageBox.Show(percentage.ToString()+ "%");
                Scorecard=counts;
                TotalQuest=FilteredTable.Rows.Count.ToString();
                
                UserScore.Text = string.Format("Score: {0}/{1}", counts, DbAns.Length.ToString());

                qstNo.Text = string.Format("Questions {0} of {1}", questionNum, DbAns.Length.ToString());
            }

               

         

       

        }
         private string[] knowDSubjforCompare( )
         {         
              //Creating and initializing the peculiar array to userOptions array
             userOptions = new string[arrayUserOptions.Length];
             Array.Copy(arrayUserOptions, userOptions, arrayUserOptions.Length);

             return userOptions;
         }
       private void btnSubmit_Click(object sender, EventArgs e)
       {
           //loadCbtByTopic();
           if (panel4.Visible == true && panel1.Visible == true)
           {
               if (panelCorrections.Visible != true)
               {
                   if (MessageBox.Show("Do you want to Submit?", " Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                   {

                       if (YearList.SelectedIndex == 1)
                       {
                          
                           extractAnswers();
                           QuestCounterInListDbID = 0; questionNum = 1;
                           dataTableDisplay(counting);
                           removeCheck();
                           gettheAlphabet();
                       }
                       else
                       {
                           extractAnswers();
                           QuestCounterInListDbID = 0;
                           questionNum = 1;
                           dbQuery(dbTableName, DbID[QuestCounterInListDbID], DbID.Count);
                           
                           removeCheck();
                           gettheAlphabet();
                       }
                       
                       panelCorrections.Visible = true;
                       timer1.Enabled = false;
                       
                       panel6.Enabled = false;
                      
                       //Result_Summary frm = new Result_Summary();
                       //frm.Show();
                       //this.Hide();
                   }
                   else
                   {

                       return;
                   }
               }
           }
           else
           {
               MessageBox.Show("Please Make sure you select the Subject of Choice and Click Proceed?", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
       }

       
       private void subNumClick(object sender, EventArgs e)
       {
           // HTMLText = HttpUtility.HtmlDecode(HTMLText);

           var butn = sender as Button;
           var btnText = butn.Text;
           for (int i = 1; i <= 100; i++)
           {

               if (btnText == i.ToString())
               {
                   //MessageBox.Show(btnText);
                    
                       CounterBasedOnSubjectName(btnText);
                      
                       gettheAlphabet();
                       butn.Focus();

                

                   break;
               }

           }
       }
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
       private void CounterBasedOnSubjectName(string txt)
       {
           if (YearList.Text != "All Year")
           {
               questionNum = Convert.ToInt32(txt);
               getQuestBasedOnCounter(questionNum);
           }
           else
           {

               questionNum = Convert.ToInt32(txt);
             
               dataTableDisplay(counting);

           }
          
           // countSub = counterCRK;
       }

       private void timer1_Tick(object sender, EventArgs e)
       {
           
           if ((minutes == 0) && (hours == 0) && (seconds == 0))
           {
               // If the time is over, clear all settings and fields.
               // Also, show the message, notifying that the time is over.
              


               // MessageBox.Show(textBox4.Text);
               timeLimit.Text = "Time Limit: 00hr : 00min : 00sec ";
               if (YearList.SelectedIndex == 1)
               {

                   extractAnswers();
                   QuestCounterInListDbID = 0; questionNum = 1;
                   dataTableDisplay(counting);
                   removeCheck();
                   gettheAlphabet();
               }
               else
               {
                   extractAnswers();
                   QuestCounterInListDbID = 0;
                   questionNum = 1;
                   dbQuery(dbTableName, DbID[QuestCounterInListDbID], DbID.Count);

                   removeCheck();
                   gettheAlphabet();
               }

               panelCorrections.Visible = true;
               panel6.Enabled = false;
              
               timer1.Enabled = false;
               Result_Summary frm = new Result_Summary();
               frm.Show();
               this.Close();
           }
           else if ((minutes <= 5) && (hours == 0) && (seconds <= 60))
           {
              
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

       private void pictureBox1_DoubleClick(object sender, EventArgs e)
       {
           pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
       }

       private void panel7_Paint(object sender, PaintEventArgs e)
       {
           
       }

       private void pictureBox1_Click(object sender, EventArgs e)
       {
           pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
       }

       private void bunifuFlatButton1_Click(object sender, EventArgs e)
       {
           panel6.Controls.Remove(panel6.Controls.Find("MyCalculator", true)[0]);
           btnCalc.Visible = true;
           bunifuFlatButton1.Visible = false;
           btnCalc.BringToFront();
       }

       private void btnCalc_Click(object sender, EventArgs e)
       {
           if( panel4.Visible != false)
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
           else
           {
              // MessageBox.Show("Test");
           }

          
       }
           
    }
}
