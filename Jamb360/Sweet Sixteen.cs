using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Speech.Synthesis;

namespace Jamb360
{
    public partial class Sweet_Sixteen : Form
    {
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
      //  private SpeechSynthesizer _ss = new SpeechSynthesizer();
        public Sweet_Sixteen()
        {
            InitializeComponent();
            //foreach (object obj in _ss.GetInstalledVoices())
            //{
            //    var voice = (InstalledVoice)obj;
            //    listBox1.Items.Add(voice.VoiceInfo.Name);

            //}
            //_ss.Volume = 80;
            //_ss.Rate = 1;

        }
        SQLiteConnection con = new SQLiteConnection(@"Data Source=.\Jamb_360.db; Version= 3;");
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the text?", " Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void Sweet_Sixteen_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dbQuery("SWEET_SIXTEEN_CHAPTER_01", 1);
        }

        private void dbQuery(string tableName, int chap)
        {
            string selectQuery = string.Format("Select * from {0} ", tableName);
                SQLiteDataAdapter sda = new SQLiteDataAdapter(selectQuery, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                labTitle.Text = string.Format("CHAPTER {0} : {1} (SUMMARY)", chap, dt.Rows[0]["CHAPTER_NAME"].ToString());
              string summary=dt.Rows[0]["SUMMARY"].ToString();
            //  txtSummary.Text = HtmlTransformer.toPlainText(summary);
              htmlRender.DocumentText = summary;
        }

        private void btnChap1_Click(object sender, EventArgs e)
        {
            dbQuery("SWEET_SIXTEEN_CHAPTER_01", 1); startReadIFVoiceHasStarted();
        }

        private void btnChap2_Click(object sender, EventArgs e)
        {
            dbQuery("SWEET_SIXTEEN_CHAPTER_02", 2);
            startReadIFVoiceHasStarted();
        }

        private void btnChap3_Click(object sender, EventArgs e)
        {
            dbQuery("SWEET_SIXTEEN_CHAPTER_03", 3);
            startReadIFVoiceHasStarted();
        }

        private void btnChap4_Click(object sender, EventArgs e)
        {
            dbQuery("SWEET_SIXTEEN_CHAPTER_04", 4);
            startReadIFVoiceHasStarted();
        }

        private void btnChap5_Click(object sender, EventArgs e)
        {
            dbQuery("SWEET_SIXTEEN_CHAPTER_05", 5);
            startReadIFVoiceHasStarted();
        }

        private void btnChap6_Click(object sender, EventArgs e)
        {
            dbQuery("SWEET_SIXTEEN_CHAPTER_06", 6);
            startReadIFVoiceHasStarted();
        }

        private void btnChap7_Click(object sender, EventArgs e)
        {
            dbQuery("SWEET_SIXTEEN_CHAPTER_07", 7);
            startReadIFVoiceHasStarted();
        }

        private void startReadIFVoiceHasStarted()
        {
            if (speechSynthesizer != null)
            {
                if (speechSynthesizer.State == SynthesizerState.Speaking)
                {
                    speechSynthesizer.SpeakAsyncCancelAll();
                    string toSpeak = htmlRender.DocumentText;
                    speechSynthesizer.SpeakAsync(toSpeak);
                    //speechSynthesizer.Dispose();
                }
               
            }
                
        }
        private void btnAudio_Click(object sender, EventArgs e)
        {
            if (htmlRender.DocumentText.Trim().Length <= 0)
            {

            }
            else
            {
                if (speechSynthesizer != null)
                {
                    if (speechSynthesizer.State == SynthesizerState.Speaking)
                    {
                        speechSynthesizer.SpeakAsyncCancelAll();
                    }
                    string toSpeak = htmlRender.DocumentText;
                    speechSynthesizer.SpeakAsync(toSpeak);
                    //speechSynthesizer.Dispose();
                }
                
               
               //
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            speechSynthesizer.SpeakAsyncCancelAll();
            base.OnClosing(e);
        }

        private void Sweet_Sixteen_Resize(object sender, EventArgs e)
        {
            //bunifuButton2.Dock = DockStyle.None;
            if (this.WindowState == FormWindowState.Minimized)
            {
                //
                if (speechSynthesizer != null)
                {
                    if (speechSynthesizer.State == SynthesizerState.Speaking)
                    {
                        speechSynthesizer.Pause();
                    }
                }

            }
            else
            {
            }
                //bunifuButton2.Width = panel3.Width; }
        }
    }
}
