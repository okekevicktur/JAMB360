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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            //this.BackColor = Color.Black;// FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.TransparencyKey = Color.Black;// FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(77))))); 
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if (panel2.Width >= 256)
            {
                timer1.Stop();
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
        
        }
    }
}
