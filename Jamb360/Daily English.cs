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

namespace Jamb360
{
    public partial class Daily_English : Form
    {
        public Daily_English()
        {
            InitializeComponent();
            
        }
        SQLiteConnection con = new SQLiteConnection(@"Data Source=.\Jamb_360.db; Version= 3;");

        private void bunifuShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", " Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void Daily_English_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            NewSetofRandomWords();
           // dbQuery("IDIOMS", 2, txtNewIdiom, idiomWordAns, "WORD", "IDIOMS");
   
        }

        /// <summary>
        /// Stoped Here... Continue on dynamibc looping
        /// </summary>
        private void NewSetofRandomWords()
        {
            for (int i = 0; i <= 5; i++)
			{
                chap = rd.Next(1, 81);
                IdiomsCache.Add(chap);
                SynonymCache.Add(rd.Next(1, 149));
                AntonymCache.Add(rd.Next(1, 263));
               // MessageBox.Show(SynonymCache[i].ToString());
			}
           dbQuery("IDIOMS", IdiomsCache[1], txtNewIdiom, idiomWordAns,"IDIOMS");
           dbQuery("ANTONYMS", AntonymCache[1], txtNewAnt, antWordAns,"ANTONYM");
           dbQuery("SYNONYM", SynonymCache[1], txtNewSyn, synWordAns, "SYNONYM");
             // MessageBox.Show(SynonymCache[1].ToString());
           //string selectQuerySyn = string.Format("Select * from {0} Where ID = '" + SynonymCache[1] + "' ", "SYNONYM");//Where ID= {1}", tableName, Index);
           //SQLiteDataAdapter sda1 = new SQLiteDataAdapter(selectQuerySyn, con);
           //DataTable dt1 = new DataTable();
           //sda1.Fill(dt1);

           //txtNewSyn.Text = dt1.Rows[0]["WORD"].ToString();
           //synWordAns.Text = dt1.Rows[0]["SYNONYM"].ToString();
        }
        Random rd = new Random();
        List<Int32> IdiomsCache = new List<Int32>(5);
        List<Int32> AntonymCache = new List<Int32>(5); 
        List<Int32> SynonymCache = new List<Int32>(5);
        int chap; 
         
        private void dbQuery(string tableName, int IndexMe , Label newWord , RichTextBox Ans, string colAns )
        {
           //return;
            string selectQuery = string.Format("Select * from {0} where id='" + IndexMe + "' ", tableName);
          //  string selectQuery = string.Format("Select * from {0} Where ID = {1}", tableName, IndexMe);//Where ID= {1}", tableName, Index);
            SQLiteDataAdapter sda = new SQLiteDataAdapter(selectQuery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);            
        
            newWord.Text = dt.Rows[0]["WORD"].ToString();
            Ans.Text = dt.Rows[0][colAns].ToString();

        }
        int CountSyn = 1; int CountAnt = 1; int CountIdiom = 1;
        private void btnNxtSyn_Click(object sender, EventArgs e)
        {
            if (CountSyn == 5)
            {
                MessageBox.Show("You are on the last word", " Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                CountSyn++;
                dbQuery("SYNONYM", SynonymCache[CountSyn], txtNewSyn, synWordAns, "SYNONYM");

            }
        }

        private void btnPrevSyn_Click(object sender, EventArgs e)
        {
            if (CountSyn == 1)
            {
                MessageBox.Show("You are on the first word", " Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                CountSyn--;
                dbQuery("SYNONYM", SynonymCache[CountSyn], txtNewSyn, synWordAns, "SYNONYM");

            }
        }

        private void btnPreAnt_Click(object sender, EventArgs e)
        {
            if (CountAnt == 1)
            {
                MessageBox.Show("You are on the first word", " Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                CountAnt--;
                dbQuery("ANTONYMS", AntonymCache[CountAnt], txtNewAnt, antWordAns, "ANTONYM");

            }
        }

        private void btnNxtAnt_Click(object sender, EventArgs e)
        {
            if (CountAnt == 5)
            {
                MessageBox.Show("You are on the last word", " Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                CountAnt++;
                dbQuery("ANTONYMS", AntonymCache[CountAnt], txtNewAnt, antWordAns, "ANTONYM");

            }
        }

        private void btnPrevIdiom_Click(object sender, EventArgs e)
        {
            if (CountIdiom == 1)
            {
                MessageBox.Show("You are on the first word", " Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                CountIdiom--; dbQuery("IDIOMS", IdiomsCache[CountIdiom], txtNewIdiom, idiomWordAns, "IDIOMS");

            }
        }

        private void btnNxtIdiom_Click(object sender, EventArgs e)
        {
            if (CountIdiom == 5)
            {
                MessageBox.Show("You are on the last word", " Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                CountIdiom++;
                dbQuery("IDIOMS", IdiomsCache[CountIdiom], txtNewIdiom, idiomWordAns, "IDIOMS");
            }
        }
    }
}
