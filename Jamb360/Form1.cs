using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Jamb360
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            //Thread t = new Thread(new ThreadStart(splash));
            //t.Start();
            //Thread.Sleep(15630);
            InitializeComponent();

            //t.Abort();
        }
        WaitFormFunct waitForm = new WaitFormFunct();
        public void splash()
        {
            Application.Run(new SplashScreen());
        }
        private void MainCbtPractice_Click(object sender, EventArgs e)
        {
            try
            {
                waitForm.Show(this);
                Subject_Combo sc = new Subject_Combo();

                sc.Show();
                waitForm.Close();
                timer1.Stop();
                this.Hide();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        private void mainQuickMaths_Click(object sender, EventArgs e)
        {

            try
            {
                waitForm.Show(this);
               
                QuickMaths QMaths = new QuickMaths();
                QMaths.Show();
                waitForm.Close();
                timer1.Stop();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        private void mainSweetSixteen_Click(object sender, EventArgs e)
        {
            try
            {
                waitForm.Show(this);
                Sweet_Sixteen Swt = new Sweet_Sixteen();
                Swt.Show();
                waitForm.Close();
                timer1.Stop();
                this.Hide();
            }
            catch (Exception)
            {
                
                throw;
            }
       
        }

        private void mainDailyEngish_Click(object sender, EventArgs e)
        {
            try
            {
               waitForm.Show(this); 
                Daily_English dail = new Daily_English();
                dail.Show();
                waitForm.Close();
                timer1.Stop();
                this.Hide();
             }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void mainEnglishFreebies_Click(object sender, EventArgs e)
        {
            try
            {
                waitForm.Show(this);           
                English_Freebies engfr = new English_Freebies();
                engfr.Show();
                waitForm.Close();
                timer1.Stop();
                    this.Hide();
             }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void mainTopicChoice_Click(object sender, EventArgs e)
        {
            try
            {
                waitForm.Show(this);
                CBT_By_Topic topic = new CBT_By_Topic();
                topic.Show();
                waitForm.Close();
                timer1.Stop();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
              
        }


        private void CbtBtn_Click(object sender, EventArgs e)
        {
            try
            {
                waitForm.Show(this);
                Subject_Combo sc = new Subject_Combo();

                sc.Show();
                waitForm.Close();
                timer1.Stop();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            try
            {
                waitForm.Show(this);
                CBT_By_Topic topic = new CBT_By_Topic();
                topic.Show();
                waitForm.Close();
                timer1.Stop();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMaths_Click(object sender, EventArgs e)
        {
            try
            {
                waitForm.Show(this);

                QuickMaths QMaths = new QuickMaths();
                QMaths.Show();
                waitForm.Close();
                timer1.Stop();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSwtSixteen_Click(object sender, EventArgs e)
        {
            try
            {
                waitForm.Show(this);
                Sweet_Sixteen Swt = new Sweet_Sixteen();
                Swt.Show();
                waitForm.Close();
                timer1.Stop();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDailyEngish_Click(object sender, EventArgs e)
        {
            try
            {
                waitForm.Show(this);
                Daily_English dail = new Daily_English();
                dail.Show();
                waitForm.Close();
                timer1.Stop();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEnglishFreebies_Click(object sender, EventArgs e)
        {
            try
            {
                waitForm.Show(this);
                English_Freebies engfr = new English_Freebies();
                engfr.Show();
                waitForm.Close();
                timer1.Stop();
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CbtBtn_MouseHover(object sender, EventArgs e)
        {
            LabWelcome.Text = "Get Acquainted with Past Questions, Over 10,000 Available  ";
        }


    }
}
